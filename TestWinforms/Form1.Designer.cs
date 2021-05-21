
namespace TestWinforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridControl grdMain;
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new TestWinforms.TestDataSet();
            this.vwMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSiteId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiteName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSiteUrl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRefreshInterval = new DevExpress.XtraGrid.Columns.GridColumn();
            this.brmMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dsSites = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.siteTableAdapter = new TestWinforms.TestDataSetTableAdapters.SiteTableAdapter();
            this.pmDeleteRecord = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.pmMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            grdMain = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmDeleteRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMain
            // 
            grdMain.DataSource = this.siteBindingSource;
            grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            grdMain.Location = new System.Drawing.Point(0, 20);
            grdMain.MainView = this.vwMain;
            grdMain.MenuManager = this.brmMain;
            grdMain.Name = "grdMain";
            grdMain.Size = new System.Drawing.Size(1441, 511);
            grdMain.TabIndex = 14;
            grdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vwMain});
            // 
            // siteBindingSource
            // 
            this.siteBindingSource.DataMember = "Site";
            this.siteBindingSource.DataSource = this.testDataSet;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "TestDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwMain
            // 
            this.vwMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSiteId,
            this.colSiteName,
            this.colSiteUrl,
            this.colRefreshInterval});
            this.vwMain.GridControl = grdMain;
            this.vwMain.Name = "vwMain";
            this.vwMain.OptionsCustomization.AllowGroup = false;
            this.vwMain.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.vwMain.OptionsView.ShowGroupPanel = false;
            this.vwMain.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.vwMain_RowClick);
            this.vwMain.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.vwMain_InitNewRow);
            this.vwMain.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.vwMain_FocusedRowChanged);
            // 
            // colSiteId
            // 
            this.colSiteId.FieldName = "SiteId";
            this.colSiteId.Name = "colSiteId";
            this.colSiteId.OptionsColumn.AllowEdit = false;
            // 
            // colSiteName
            // 
            this.colSiteName.FieldName = "SiteName";
            this.colSiteName.Name = "colSiteName";
            this.colSiteName.Visible = true;
            this.colSiteName.VisibleIndex = 0;
            // 
            // colSiteUrl
            // 
            this.colSiteUrl.FieldName = "SiteUrl";
            this.colSiteUrl.Name = "colSiteUrl";
            this.colSiteUrl.Visible = true;
            this.colSiteUrl.VisibleIndex = 1;
            // 
            // colRefreshInterval
            // 
            this.colRefreshInterval.FieldName = "RefreshInterval";
            this.colRefreshInterval.Name = "colRefreshInterval";
            this.colRefreshInterval.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colRefreshInterval.Visible = true;
            this.colRefreshInterval.VisibleIndex = 2;
            // 
            // brmMain
            // 
            this.brmMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.brmMain.DockControls.Add(this.barDockControlTop);
            this.brmMain.DockControls.Add(this.barDockControlBottom);
            this.brmMain.DockControls.Add(this.barDockControlLeft);
            this.brmMain.DockControls.Add(this.barDockControlRight);
            this.brmMain.Form = this;
            this.brmMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnInsert,
            this.btnDelete,
            this.btnExit,
            this.btnRefresh,
            this.barButtonItem1});
            this.brmMain.MainMenu = this.bar2;
            this.brmMain.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Обновить";
            this.btnRefresh.Id = 3;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "Добавить запись";
            this.btnInsert.Id = 0;
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInsert_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Удалить выделенную запись";
            this.btnDelete.Id = 1;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Выход";
            this.btnExit.Id = 2;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.brmMain;
            this.barDockControlTop.Size = new System.Drawing.Size(1441, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Manager = this.brmMain;
            this.barDockControlBottom.Size = new System.Drawing.Size(1441, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.brmMain;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 511);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1441, 20);
            this.barDockControlRight.Manager = this.brmMain;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 511);
            // 
            // dsSites
            // 
            this.dsSites.ConnectionName = "TestWinforms.Properties.Settings.TestConnectionString";
            this.dsSites.Name = "dsSites";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "select\r\n  SiteId = s.SiteId,\r\n  SiteName = s.SiteName,\r\n  SiteUrl = s.SiteUrl,\r\n " +
    " RefreshInterval = s.RefreshInterval\r\nfrom dbo.Site as s";
            this.dsSites.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.dsSites.ResultSchemaSerializable = resources.GetString("dsSites.ResultSchemaSerializable");
            // 
            // siteTableAdapter
            // 
            this.siteTableAdapter.ClearBeforeFill = true;
            // 
            // pmDeleteRecord
            // 
            this.pmDeleteRecord.Manager = this.brmMain;
            this.pmDeleteRecord.Name = "pmDeleteRecord";
            // 
            // bar1
            // 
            this.bar1.BarName = "barContext";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 3";
            // 
            // bar3
            // 
            this.bar3.BarName = "Custom 4";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 2;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.Text = "Custom 4";
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 4";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 2;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Custom 4";
            // 
            // pmMenu
            // 
            this.pmMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.pmMenu.Manager = this.brmMain;
            this.pmMenu.Name = "pmMenu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Удалить";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 531);
            this.Controls.Add(grdMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmDeleteRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager brmMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.DataAccess.Sql.SqlDataSource dsSites;
        private DevExpress.XtraGrid.Views.Grid.GridView vwMain;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteId;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteName;
        private DevExpress.XtraGrid.Columns.GridColumn colSiteUrl;
        private DevExpress.XtraGrid.Columns.GridColumn colRefreshInterval;
        private TestDataSet testDataSet;
        private System.Windows.Forms.BindingSource siteBindingSource;
        private TestDataSetTableAdapters.SiteTableAdapter siteTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.PopupMenu pmDeleteRecord;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.PopupMenu pmMenu;
    }
}

