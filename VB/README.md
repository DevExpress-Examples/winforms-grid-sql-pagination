# winforms-xtragrid-sqlpagination
.NET, WinForms, XtraGrid Suite 

### XtraGrid - How to implement a pager using Embedded Navigator

1. Enable Embedded Navigator using the [GridControl.UseEmbeddedNavigator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.UseEmbeddedNavigator) property.
2. Access Embedded Navigator using the [GridControl.EmbeddedNavigator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.EmbeddedNavigator) property and add two [custom buttons](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.NavigatorButtonsBase.CustomButtons) - **NextPage** and **PrevPage**. Then, specify [Tag](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.NavigatorButtonBase.Tag) for each button to distinguish buttons in code.
3. Handle the [GridControl.EmbeddedNavigator.ButtonClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.NavigatorBase.ButtonClick) event. In this event handler, increment/decrement the current page index, retrieve a new data source, and assign it to the [GridControl.DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.DataSource) property.

```csharp
private void EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e) {
    if (e.Button.ButtonType != NavigatorButtonType.Custom) return;
    e.Handled = true;
    string tag = (string)e.Button.Tag;
    switch(tag) {
        case "NextPage":
            this.CurrentPageIndex = Math.Min(this.CurrentPageIndex + 1, this.MaxPageIndex);
            break;
        case "PrevPage":
            this.CurrentPageIndex = Math.Max(0, this.CurrentPageIndex - 1);
            break;
    }
    this.GridControl.DataSource = GetData(this.CurrentPageIndex);
}
```
```vbnet
Private Sub EmbeddedNavigator_ButtonClick(ByVal sender As Object, ByVal e As NavigatorButtonClickEventArgs)
	If e.Button.ButtonType <> NavigatorButtonType.Custom Then
		Return
	End If
	e.Handled = True
	Dim tag As String = CStr(e.Button.Tag)
	Select Case tag
		Case "NextPage"
			Me.CurrentPageIndex = Math.Min(Me.CurrentPageIndex + 1, Me.MaxPageIndex)
		Case "PrevPage"
			Me.CurrentPageIndex = Math.Max(0, Me.CurrentPageIndex - 1)
	End Select
	Me.GridControl.DataSource = GetData(Me.CurrentPageIndex)
End Sub
```
