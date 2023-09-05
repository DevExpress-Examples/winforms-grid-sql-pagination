<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/148460569/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T831243)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WinForms Data Grid - Implement a pager using the Data Navigator

In this example:

1. Enable the [GridControl.UseEmbeddedNavigator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.UseEmbeddedNavigator) property to display the Data Navigator within the Grid control.
2. Use the [GridControl.EmbeddedNavigator](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.EmbeddedNavigator) property and add two [custom buttons](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.NavigatorButtonsBase.CustomButtons) (**NextPage**, **PrevPage**).
3. Specify the [Tag](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.NavigatorButtonBase.Tag) property for each button to distinguish custom buttons in code.
4. Handle the [GridControl.EmbeddedNavigator.ButtonClick](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.NavigatorBase.ButtonClick) event to increment/decrement the current page index, retrieve a new data source, and assign it to the [GridControl.DataSource](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl.DataSource) property.

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

## Documentation

* [Data Navigator](https://docs.devexpress.com/WindowsForms/522/controls-and-libraries/data-grid/visual-elements/grid-control-elements/data-navigator)
* [How to: Hide Specific Buttons in the Embedded Navigator](https://docs.devexpress.com/WindowsForms/3057/controls-and-libraries/data-grid/examples/navigation-and-selection/how-to-hide-specific-buttons-in-the-embedded-navigator)
