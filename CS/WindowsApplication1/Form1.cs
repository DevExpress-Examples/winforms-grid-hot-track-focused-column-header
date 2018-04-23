using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils.Drawing;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        public void InitData() {
            for (int i = 0; i <= 1000; i++) {
                dataSet11.DataTable1.Rows.Add(new object[] {  0, i,DateTime.Today, i });
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
          }

        private void gridView1_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e) {
            GridView view = sender as GridView;
            if (e.Column == view.FocusedColumn ) {
                e.Info.State = ObjectState.Hot;         
            }
        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e) {
            ((GridView)sender).InvalidateColumnHeader(e.FocusedColumn);
            ((GridView)sender).InvalidateColumnHeader(e.PrevFocusedColumn);
        }

        private void gridView1_Layout(object sender, EventArgs e) {
            ((GridView)sender).InvalidateColumnHeader(null);
        }


    }
}
