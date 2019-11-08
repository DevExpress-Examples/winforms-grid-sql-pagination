Namespace DxSample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.OrdersGrid = New DevExpress.XtraGrid.GridControl()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.NorthwindDataSet = New System.Data.DataSet()
			Me.dtOrders = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.OrdersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFreight = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.PageSizeEditor = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			CType(Me.OrdersGrid, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dtOrders, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.OrdersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' OrdersGrid
			' 
			Me.OrdersGrid.DataSource = Me.ordersBindingSource
			Me.OrdersGrid.Dock = System.Windows.Forms.DockStyle.Fill
			Me.OrdersGrid.EmbeddedNavigator.Buttons.First.Visible = False
			Me.OrdersGrid.EmbeddedNavigator.Buttons.Last.Visible = False
			Me.OrdersGrid.EmbeddedNavigator.Buttons.NextPage.Visible = False
			Me.OrdersGrid.EmbeddedNavigator.Buttons.PrevPage.Visible = False
			Me.OrdersGrid.EmbeddedNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {
				New DevExpress.XtraEditors.NavigatorCustomButton(0, 1, False, True, "", "PrevPage"),
				New DevExpress.XtraEditors.NavigatorCustomButton(1, 4, True, True, "", "NextPage")
			})
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.OrdersGrid.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.EmbeddedNavigator_ButtonClick);
			Me.OrdersGrid.Location = New System.Drawing.Point(0, 29)
			Me.OrdersGrid.MainView = Me.OrdersGridView
			Me.OrdersGrid.Name = "OrdersGrid"
			Me.OrdersGrid.Size = New System.Drawing.Size(429, 232)
			Me.OrdersGrid.TabIndex = 0
			Me.OrdersGrid.UseEmbeddedNavigator = True
			Me.OrdersGrid.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.OrdersGridView})
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.NorthwindDataSet
			' 
			' NorthwindDataSet
			' 
			Me.NorthwindDataSet.DataSetName = "Norhtwind"
			Me.NorthwindDataSet.Tables.AddRange(New System.Data.DataTable() { Me.dtOrders})
			' 
			' dtOrders
			' 
			Me.dtOrders.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4})
			Me.dtOrders.TableName = "Orders"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "OrderID"
			Me.dataColumn1.DataType = GetType(Integer)
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "OrderDate"
			Me.dataColumn2.DataType = GetType(Date)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Freight"
			Me.dataColumn3.DataType = GetType(Decimal)
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "ShipName"
			' 
			' OrdersGridView
			' 
			Me.OrdersGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOrderID, Me.colOrderDate, Me.colFreight, Me.colShipName})
			Me.OrdersGridView.GridControl = Me.OrdersGrid
			Me.OrdersGridView.Name = "OrdersGridView"
			' 
			' colOrderID
			' 
			Me.colOrderID.FieldName = "OrderID"
			Me.colOrderID.Name = "colOrderID"
			Me.colOrderID.Visible = True
			Me.colOrderID.VisibleIndex = 0
			' 
			' colOrderDate
			' 
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 1
			' 
			' colFreight
			' 
			Me.colFreight.FieldName = "Freight"
			Me.colFreight.Name = "colFreight"
			Me.colFreight.Visible = True
			Me.colFreight.VisibleIndex = 2
			' 
			' colShipName
			' 
			Me.colShipName.FieldName = "ShipName"
			Me.colShipName.Name = "colShipName"
			Me.colShipName.Visible = True
			Me.colShipName.VisibleIndex = 3
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.PageSizeEditor})
			Me.barManager1.MaxItemId = 3
			Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1, Me.repositoryItemTextEdit1, Me.repositoryItemButtonEdit1})
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.PageSizeEditor)})
			Me.bar1.Text = "Tools"
			' 
			' PageSizeEditor
			' 
			Me.PageSizeEditor.Caption = "Page Size"
			Me.PageSizeEditor.Edit = Me.repositoryItemComboBox1
			Me.PageSizeEditor.EditValue = "10"
			Me.PageSizeEditor.Id = 0
			Me.PageSizeEditor.Name = "PageSizeEditor"
			Me.PageSizeEditor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.PageSizeEditor.EditValueChanged += new System.EventHandler(this.PageSizeEditor_EditValueChanged);
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "10", "50", "100", "200"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			Me.repositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Manager = Me.barManager1
			Me.barDockControlTop.Size = New System.Drawing.Size(429, 29)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 261)
			Me.barDockControlBottom.Manager = Me.barManager1
			Me.barDockControlBottom.Size = New System.Drawing.Size(429, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
			Me.barDockControlLeft.Manager = Me.barManager1
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 232)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(429, 29)
			Me.barDockControlRight.Manager = Me.barManager1
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 232)
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' repositoryItemButtonEdit1
			' 
			Me.repositoryItemButtonEdit1.AutoHeight = False
			Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(429, 261)
			Me.Controls.Add(Me.OrdersGrid)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "MainForm"
			Me.Text = "DX Sample"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.MainForm_Load);
			CType(Me.OrdersGrid, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dtOrders, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.OrdersGridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents OrdersGrid As DevExpress.XtraGrid.GridControl
		Private OrdersGridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colFreight As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipName As DevExpress.XtraGrid.Columns.GridColumn
		Private NorthwindDataSet As System.Data.DataSet
		Private dtOrders As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private WithEvents PageSizeEditor As DevExpress.XtraBars.BarEditItem
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
	End Class
End Namespace

