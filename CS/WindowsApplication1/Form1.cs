using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void InitData()
        {
            var dt = new DataTable();
            dt.Columns.Add("BoolProperty", typeof(bool));
            dt.Columns.Add("StringProperty", typeof(string));
            dt.Columns.Add("CurrentDate", typeof(DateTime));
            dt.Columns.Add("IntProperty", typeof(Int32));
            for (int i = 0; i <= 1000; i++)
                dt.Rows.Add(new object[] { 0, i, DateTime.Today, i });
            gridControl1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
        }
        private void gridView1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column?.FieldName == view.FocusedColumn.FieldName)
                e.Info.State = ObjectState.Hot;
        }
        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            ((GridView)sender).InvalidateColumnHeader(e.FocusedColumn);
            ((GridView)sender).InvalidateColumnHeader(e.PrevFocusedColumn);
        }
        private void gridView1_Layout(object sender, EventArgs e)
        {
            ((GridView)sender).InvalidateColumnHeader(null);
        }
    }
}
