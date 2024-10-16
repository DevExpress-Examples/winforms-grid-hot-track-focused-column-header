<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629332/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E342)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Highlight the focused column header

This example handles the [CustomDrawColumnHeader](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawColumnHeader) event to apply a hot-track state for the focused column.

The example also handles [FocusedColumnChanged](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FocusedColumnChanged) and [Layout](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.BaseView.Layout) events to call the [InvalidateColumnHeader](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.InvalidateColumnHeader(DevExpress.XtraGrid.Columns.GridColumn)) mehthod to forcibly repaint column headers when the focused column or the GridView's layout is changed.

![WinForms Data Grid - Highlight the focused column header](https://raw.githubusercontent.com/DevExpress-Examples/how-to-hot-track-a-focused-column-e342/13.1.4%2B/media/winforms-grid-highlight-focused-column-header.png)

```csharp
private void gridView1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e) {
    GridView view = sender as GridView;
    if (e.Column?.FieldName == view.FocusedColumn.FieldName)
        e.Info.State = ObjectState.Hot;
}
private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
    ((GridView)sender).InvalidateColumnHeader(e.FocusedColumn);
    ((GridView)sender).InvalidateColumnHeader(e.PrevFocusedColumn);
}
private void gridView1_Layout(object sender, EventArgs e) {
    ((GridView)sender).InvalidateColumnHeader(null);
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-hot-track-focused-column-header&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-hot-track-focused-column-header&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
