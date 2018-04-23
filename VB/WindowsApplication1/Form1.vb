Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.Utils.Drawing

Namespace WindowsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

		End Sub

		Public Sub InitData()
			For i As Integer = 0 To 1000
				dataSet11.DataTable1.Rows.Add(New Object() { 0, i,DateTime.Today, i })
			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()
		End Sub

		Private Sub gridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As ColumnHeaderCustomDrawEventArgs) Handles gridView1.CustomDrawColumnHeader
			Dim view As GridView = TryCast(sender, GridView)
            If e.Column Is view.FocusedColumn Then
                e.Info.State = ObjectState.Hot
            End If
        End Sub

		Private Sub gridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles gridView1.FocusedColumnChanged
			CType(sender, GridView).InvalidateColumnHeader(e.FocusedColumn)
			CType(sender, GridView).InvalidateColumnHeader(e.PrevFocusedColumn)
		End Sub

		Private Sub gridView1_Layout(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.Layout
			CType(sender, GridView).InvalidateColumnHeader(Nothing)
		End Sub


	End Class
End Namespace
