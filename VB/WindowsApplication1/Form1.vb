Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports System
Imports System.Data
Imports System.Windows.Forms

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub InitData()
            Dim dt = New DataTable()
            dt.Columns.Add("BoolProperty", GetType(Boolean))
            dt.Columns.Add("StringProperty", GetType(String))
            dt.Columns.Add("CurrentDate", GetType(Date))
            dt.Columns.Add("IntProperty", GetType(Integer))
            For i As Integer = 0 To 1000
                dt.Rows.Add(New Object() {0, i, Date.Today, i})
            Next

            gridControl1.DataSource = dt
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitData()
        End Sub

        Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As ColumnHeaderCustomDrawEventArgs)
            Dim view As GridView = TryCast(sender, GridView)
            If Equals(e.Column?.FieldName, view.FocusedColumn.FieldName) Then e.Info.State = ObjectState.Hot
        End Sub

        Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs)
            CType(sender, GridView).InvalidateColumnHeader(e.FocusedColumn)
            CType(sender, GridView).InvalidateColumnHeader(e.PrevFocusedColumn)
        End Sub

        Private Sub gridView1_Layout(ByVal sender As Object, ByVal e As EventArgs)
            CType(sender, GridView).InvalidateColumnHeader(Nothing)
        End Sub
    End Class
End Namespace
