Imports System
Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors

Namespace DxSample
	Partial Public Class MainForm
		Inherits XtraForm

		Private DataAdapter As SqlDataAdapter

		Public Sub New()
			InitializeComponent()
			OrdersGridView.OptionsCustomization.AllowFilter = False
			OrdersGridView.OptionsCustomization.AllowGroup = False
			OrdersGridView.OptionsCustomization.AllowSort = False
			OrdersGridView.OptionsFind.AllowFindPanel = False
			OrdersGridView.OptionsView.ShowGroupPanel = False
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConnectionString").ConnectionString
			Dim selectCommandText As String = "
select OrderID, OrderDate, Freight, ShipName
from Orders
order by OrderID
offset @offset rows
fetch next @size rows only
"
			Me.DataAdapter = New SqlDataAdapter(selectCommandText, connectionString)
			Me.DataAdapter.SelectCommand.Parameters.Add("@offset", SqlDbType.Int)
			Me.DataAdapter.SelectCommand.Parameters.Add("@size", SqlDbType.Int)
			Me.DataAdapter.SelectCommand.Parameters("@offset").Value = 0
			Me.DataAdapter.SelectCommand.Parameters("@size").Value = PageSize

			Me.DataAdapter.Fill(Me.dtOrders)

		End Sub

		Private fPageSize As Integer = 10
		Public Property PageSize() As Integer
			Get
				Return fPageSize
			End Get
			Set(ByVal value As Integer)
				fPageSize = value
			End Set
		End Property

		Private Sub EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs) Handles OrdersGrid.EmbeddedNavigator.ButtonClick
			If e.Button.ButtonType <> NavigatorButtonType.Custom Then
				Return
			End If
			e.Handled = True
			Dim offset As Integer = DirectCast(DataAdapter.SelectCommand.Parameters("@offset").Value, Integer)
			Dim tag As String = CStr(e.Button.Tag)
			Select Case tag
				Case "NextPage"
					offset += PageSize
				Case "PrevPage"
					offset -= PageSize
			End Select
			offset = Math.Max(0, offset)
			OrdersGrid.EmbeddedNavigator.Buttons.CustomButtons(0).Enabled = offset > 0
			DataAdapter.SelectCommand.Parameters("@offset").Value = offset
			dtOrders.Clear()
			DataAdapter.Fill(dtOrders)
			OrdersGrid.EmbeddedNavigator.Buttons.CustomButtons(1).Enabled = dtOrders.Rows.Count = PageSize
		End Sub

		Private Sub PageSizeEditor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles PageSizeEditor.EditValueChanged
			Dim editor As BarEditItem = DirectCast(sender, BarEditItem)
			PageSize = Integer.Parse(CStr(editor.EditValue))
			DataAdapter.SelectCommand.Parameters("@size").Value = PageSize
			dtOrders.Clear()
			DataAdapter.Fill(dtOrders)
		End Sub
	End Class
End Namespace
