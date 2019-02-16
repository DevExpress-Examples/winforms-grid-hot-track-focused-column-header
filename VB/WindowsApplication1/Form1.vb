Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub InitData()
            Dim dt = New DataTable()
            dt.Columns.Add("BoolProperty", GetType(Boolean))
            dt.Columns.Add("StringProperty", GetType(String))
            dt.Columns.Add("CurrentDate", GetType(Date))
            dt.Columns.Add("IntProperty", GetType(Int32))
            For i As Integer = 0 To 1000
                dt.Rows.Add(New Object() { 0, i, Date.Today, i })
            Next i
            gridControl1.DataSource = dt
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            InitData()
        End Sub
        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
            Dim view As GridView = TryCast(sender, GridView)
            If e.Column?.FieldName = view.FocusedColumn.FieldName Then
                e.Info.State = ObjectState.Hot
            End If
        End Sub
        Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
            DirectCast(sender, GridView).InvalidateColumnHeader(e.FocusedColumn)
            DirectCast(sender, GridView).InvalidateColumnHeader(e.PrevFocusedColumn)
        End Sub
        Private Sub gridView1_Layout(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.Layout
            DirectCast(sender, GridView).InvalidateColumnHeader(Nothing)
        End Sub
    End Class
End Namespace
