<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
<!-- default file list end -->
# How to hot track a focused column


<p>You should handle the <strong>GridView.CustomDrawColumnHeader</strong> event. In this event handler, change the ColumnHeaderCustomDrawEventArgs.Info.State property to ObjectState.Hot for the focused column.</p><p>When the focused column is changed and the GridView layout is changed, the column headers need to be forced to repaint. You should use the <strong>FocusedColumnChanged</strong> and <strong>GridView.Layout</strong>event and <strong>InvalidateColumnHeader</strong> method for this.</p>

<br/>


