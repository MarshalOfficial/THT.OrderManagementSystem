namespace THT.OrderManagementSystem.Forms
{
    partial class frmVisitLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisitLog));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FilterPanel = new DevExpress.XtraEditors.PanelControl();
            this.BtnResetFilters = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearFilters = new DevExpress.XtraEditors.SimpleButton();
            this.filtercmbCustomer = new DevExpress.XtraEditors.LookUpEdit();
            this.filtercmbVisitor = new DevExpress.XtraEditors.LookUpEdit();
            this.btnFilterSearch = new DevExpress.XtraEditors.SimpleButton();
            this.filtertbxToTime = new Atf.UI.DateTimeSelector();
            this.filtertbxFromTime = new Atf.UI.DateTimeSelector();
            this.filtertbxMemo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvMain = new DevExpress.XtraGrid.GridControl();
            this.dgvMains = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.VisitorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaveTimeFa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Latitude = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Longitude = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.SaveDateFa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.tsMenuItemExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.CustomerRegionNo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilterPanel)).BeginInit();
            this.FilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbVisitor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbxMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FilterPanel);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(914, 498);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.TabIndex = 0;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.BtnResetFilters);
            this.FilterPanel.Controls.Add(this.btnClearFilters);
            this.FilterPanel.Controls.Add(this.filtercmbCustomer);
            this.FilterPanel.Controls.Add(this.filtercmbVisitor);
            this.FilterPanel.Controls.Add(this.btnFilterSearch);
            this.FilterPanel.Controls.Add(this.filtertbxToTime);
            this.FilterPanel.Controls.Add(this.filtertbxFromTime);
            this.FilterPanel.Controls.Add(this.filtertbxMemo);
            this.FilterPanel.Controls.Add(this.labelControl5);
            this.FilterPanel.Controls.Add(this.labelControl4);
            this.FilterPanel.Controls.Add(this.labelControl3);
            this.FilterPanel.Controls.Add(this.labelControl2);
            this.FilterPanel.Controls.Add(this.labelControl1);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(914, 69);
            this.FilterPanel.TabIndex = 0;
            // 
            // BtnResetFilters
            // 
            this.BtnResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResetFilters.Location = new System.Drawing.Point(24, 35);
            this.BtnResetFilters.Name = "BtnResetFilters";
            this.BtnResetFilters.Size = new System.Drawing.Size(100, 26);
            this.BtnResetFilters.TabIndex = 10;
            this.BtnResetFilters.Text = "مقدار اولیه فیلترها";
            this.BtnResetFilters.Click += new System.EventHandler(this.BtnResetFilters_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilters.Location = new System.Drawing.Point(130, 35);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(100, 26);
            this.btnClearFilters.TabIndex = 9;
            this.btnClearFilters.Text = "خالی کردن فیتلرها";
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // filtercmbCustomer
            // 
            this.filtercmbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtercmbCustomer.Location = new System.Drawing.Point(402, 12);
            this.filtercmbCustomer.Name = "filtercmbCustomer";
            this.filtercmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filtercmbCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("THesabcode", "کد طرف حساب"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TName", "نام و نام خانوادگی")});
            this.filtercmbCustomer.Properties.NullText = "";
            this.filtercmbCustomer.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.filtercmbCustomer.Size = new System.Drawing.Size(200, 20);
            this.filtercmbCustomer.TabIndex = 1;
            // 
            // filtercmbVisitor
            // 
            this.filtercmbVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtercmbVisitor.Location = new System.Drawing.Point(651, 12);
            this.filtercmbVisitor.Name = "filtercmbVisitor";
            this.filtercmbVisitor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filtercmbVisitor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Visitor_Code", "کد ویزیتور"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Visitor_Name", "نام و نام خانوادگی")});
            this.filtercmbVisitor.Properties.NullText = "";
            this.filtercmbVisitor.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.filtercmbVisitor.Size = new System.Drawing.Size(200, 20);
            this.filtercmbVisitor.TabIndex = 0;
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterSearch.Location = new System.Drawing.Point(237, 35);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(100, 26);
            this.btnFilterSearch.TabIndex = 5;
            this.btnFilterSearch.Text = "جستجو";
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // filtertbxToTime
            // 
            this.filtertbxToTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtertbxToTime.Format = Atf.UI.DateTimeSelectorFormat.Long;
            this.filtertbxToTime.Location = new System.Drawing.Point(402, 36);
            this.filtertbxToTime.Name = "filtertbxToTime";
            this.filtertbxToTime.Size = new System.Drawing.Size(200, 22);
            this.filtertbxToTime.TabIndex = 4;
            this.filtertbxToTime.UsePersianFormat = true;
            // 
            // filtertbxFromTime
            // 
            this.filtertbxFromTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtertbxFromTime.Format = Atf.UI.DateTimeSelectorFormat.Long;
            this.filtertbxFromTime.Location = new System.Drawing.Point(651, 36);
            this.filtertbxFromTime.Name = "filtertbxFromTime";
            this.filtertbxFromTime.Size = new System.Drawing.Size(200, 22);
            this.filtertbxFromTime.TabIndex = 3;
            this.filtertbxFromTime.UsePersianFormat = true;
            // 
            // filtertbxMemo
            // 
            this.filtertbxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtertbxMemo.Location = new System.Drawing.Point(24, 10);
            this.filtertbxMemo.Name = "filtertbxMemo";
            this.filtertbxMemo.Size = new System.Drawing.Size(313, 20);
            this.filtertbxMemo.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(342, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "توضیحات";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(617, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "تا";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(857, 41);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(7, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "از";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(606, 15);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "مشتری";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(856, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ویزیتور";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMain);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gMapControl1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(914, 425);
            this.splitContainer2.SplitterDistance = 467;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvMain
            // 
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MainView = this.dgvMains;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvMain.Size = new System.Drawing.Size(467, 425);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMains});
            // 
            // dgvMains
            // 
            this.dgvMains.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.VisitorName,
            this.CustomerName,
            this.SaveTimeFa,
            this.Memo,
            this.CustomerRegionNo,
            this.Address,
            this.Latitude,
            this.Longitude,
            this.ID,
            this.Result});
            this.dgvMains.GridControl = this.dgvMain;
            this.dgvMains.Name = "dgvMains";
            this.dgvMains.OptionsBehavior.Editable = false;
            this.dgvMains.OptionsPrint.AutoWidth = false;
            this.dgvMains.OptionsView.ColumnAutoWidth = false;
            this.dgvMains.OptionsView.ShowFooter = true;
            this.dgvMains.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.dgvMains_PopupMenuShowing);
            this.dgvMains.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvMains_FocusedRowChanged);
            // 
            // VisitorName
            // 
            this.VisitorName.Caption = "ویزیتور";
            this.VisitorName.FieldName = "VisitorName";
            this.VisitorName.Name = "VisitorName";
            this.VisitorName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "VisitorName", "تعداد ={0:N0}")});
            this.VisitorName.Visible = true;
            this.VisitorName.VisibleIndex = 0;
            this.VisitorName.Width = 63;
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "مشتری";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 1;
            this.CustomerName.Width = 100;
            // 
            // SaveTimeFa
            // 
            this.SaveTimeFa.Caption = "تاریخ";
            this.SaveTimeFa.FieldName = "SaveTimeFa";
            this.SaveTimeFa.Name = "SaveTimeFa";
            this.SaveTimeFa.Visible = true;
            this.SaveTimeFa.VisibleIndex = 2;
            this.SaveTimeFa.Width = 110;
            // 
            // Memo
            // 
            this.Memo.Caption = "توضیحات";
            this.Memo.FieldName = "Memo";
            this.Memo.Name = "Memo";
            this.Memo.Visible = true;
            this.Memo.VisibleIndex = 4;
            this.Memo.Width = 100;
            // 
            // Address
            // 
            this.Address.Caption = "آدرس مشتری";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 6;
            this.Address.Width = 100;
            // 
            // Latitude
            // 
            this.Latitude.Caption = "طول جغرافیایی";
            this.Latitude.FieldName = "Latitude";
            this.Latitude.Name = "Latitude";
            this.Latitude.Visible = true;
            this.Latitude.VisibleIndex = 7;
            this.Latitude.Width = 40;
            // 
            // Longitude
            // 
            this.Longitude.Caption = "عرض جغرافیایی";
            this.Longitude.FieldName = "Longitude";
            this.Longitude.Name = "Longitude";
            this.Longitude.Visible = true;
            this.Longitude.VisibleIndex = 8;
            this.Longitude.Width = 40;
            // 
            // ID
            // 
            this.ID.Caption = "شناسه";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // Result
            // 
            this.Result.Caption = "نتیجه";
            this.Result.FieldName = "Result";
            this.Result.Name = "Result";
            this.Result.Visible = true;
            this.Result.VisibleIndex = 3;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 20;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(443, 425);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gMapControl1_OnMarkerClick);
            // 
            // SaveDateFa
            // 
            this.SaveDateFa.Caption = "تاریخ";
            this.SaveDateFa.FieldName = "SaveDateFa";
            this.SaveDateFa.Name = "SaveDateFa";
            this.SaveDateFa.Visible = true;
            this.SaveDateFa.VisibleIndex = 2;
            this.SaveDateFa.Width = 55;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "تاریخ";
            this.gridColumn1.FieldName = "SaveDateFa";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 55;
            // 
            // radialMenu1
            // 
            this.radialMenu1.AutoExpand = true;
            this.radialMenu1.Glyph = ((System.Drawing.Image)(resources.GetObject("radialMenu1.Glyph")));
            this.radialMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.tsMenuItemExportExcel)});
            this.radialMenu1.Manager = this.barManager1;
            this.radialMenu1.Name = "radialMenu1";
            // 
            // tsMenuItemExportExcel
            // 
            this.tsMenuItemExportExcel.Caption = "خروجی اکسل";
            this.tsMenuItemExportExcel.Id = 0;
            this.tsMenuItemExportExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuItemExportExcel.ImageOptions.Image")));
            this.tsMenuItemExportExcel.Name = "tsMenuItemExportExcel";
            this.tsMenuItemExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsMenuItemExportExcel_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tsMenuItemExportExcel});
            this.barManager1.MaxItemId = 1;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(914, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 498);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(914, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 498);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(914, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 498);
            // 
            // CustomerRegionNo
            // 
            this.CustomerRegionNo.Caption = "منطقه";
            this.CustomerRegionNo.FieldName = "CustomerRegionNo";
            this.CustomerRegionNo.Name = "CustomerRegionNo";
            this.CustomerRegionNo.Visible = true;
            this.CustomerRegionNo.VisibleIndex = 5;
            // 
            // frmVisitLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 498);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "frmVisitLog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش لاگ ویزیت کاربران";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVisitLog_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilterPanel)).EndInit();
            this.FilterPanel.ResumeLayout(false);
            this.FilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbVisitor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbxMemo.Properties)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PanelControl FilterPanel;
        private DevExpress.XtraEditors.TextEdit filtertbxMemo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl dgvMain;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMains;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private Atf.UI.DateTimeSelector filtertbxToTime;
        private Atf.UI.DateTimeSelector filtertbxFromTime;
        private DevExpress.XtraEditors.SimpleButton btnFilterSearch;
        private DevExpress.XtraGrid.Columns.GridColumn VisitorName;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn SaveTimeFa;
        private DevExpress.XtraGrid.Columns.GridColumn Memo;
        private DevExpress.XtraGrid.Columns.GridColumn Latitude;
        private DevExpress.XtraGrid.Columns.GridColumn Longitude;
        private DevExpress.XtraEditors.LookUpEdit filtercmbCustomer;
        private DevExpress.XtraEditors.LookUpEdit filtercmbVisitor;
        private DevExpress.XtraEditors.SimpleButton btnClearFilters;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn SaveDateFa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraEditors.SimpleButton BtnResetFilters;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarButtonItem tsMenuItemExportExcel;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn Result;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerRegionNo;
    }
}