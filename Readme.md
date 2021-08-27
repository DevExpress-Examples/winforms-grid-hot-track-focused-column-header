<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629332/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E342)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
<!-- default file list end -->
# How to hot track a focused column


<p>You should handle the <strong>GridView.CustomDrawColumnHeader</strong> event. In this event handler, change the ColumnHeaderCustomDrawEventArgs.Info.State property to ObjectState.Hot for the focused column.</p><p>When the focused column is changed and the GridView layout is changed, the column headers need to be forced to repaint. You should use the <strong>FocusedColumnChanged</strong> and <strong>GridView.Layout</strong>event and <strong>InvalidateColumnHeader</strong> method for this.</p>

<br/>


