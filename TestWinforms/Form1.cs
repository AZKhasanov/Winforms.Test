using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestWinforms
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.siteTableAdapter.Fill(this.testDataSet.Site);
        }

        private void btnInsert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            vwMain.DataController.AddNewRow();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshDataSet();
        }

        private void RefreshDataSet()
        {
            this.siteTableAdapter.Fill(this.testDataSet.Site);
        }

        private void UpdateDataset()
        {
            if(vwMain.PostEditor())
                vwMain.UpdateCurrentRow();
            if (testDataSet.HasChanges())
                siteTableAdapter.Update(testDataSet.Site);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteFocusedRecord();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            Application.Exit();
        }

        private void vwMain_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

            UpdateDataset();
        }

        private void vwMain_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateDataset();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteFocusedRecord();
        }

        private void DeleteFocusedRecord()
        {
            if (vwMain.RowCount > 0)
            {
                vwMain.DataController.DeleteRow(vwMain.GetSelectedRows()[0]);
                UpdateDataset();
            }
        }

        private void vwMain_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if(e.Button == MouseButtons.Right )
            {
                var p = PointToScreen(e.Location);
                pmMenu.ShowPopup(p);
            }
        }
    }
}
