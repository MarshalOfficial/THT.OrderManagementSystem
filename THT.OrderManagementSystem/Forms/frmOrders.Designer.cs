namespace THT.OrderManagementSystem.Forms
{
    partial class frmOrders
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
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
            this.dgvOrderDetails = new DevExpress.XtraGrid.GridControl();
            this.dgvOrderDetailss = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.K_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BarCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.K_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PK_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Reduction_p = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RowPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgvOrders = new DevExpress.XtraGrid.GridControl();
            this.dgvOrderss = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PInv_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SaveTimeFa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvMemo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InvPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbVisitor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbxMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderss)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panelControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1019, 482);
            this.splitContainer1.SplitterDistance = 74;
            this.splitContainer1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BtnResetFilters);
            this.panelControl1.Controls.Add(this.btnClearFilters);
            this.panelControl1.Controls.Add(this.filtercmbCustomer);
            this.panelControl1.Controls.Add(this.filtercmbVisitor);
            this.panelControl1.Controls.Add(this.btnFilterSearch);
            this.panelControl1.Controls.Add(this.filtertbxToTime);
            this.panelControl1.Controls.Add(this.filtertbxFromTime);
            this.panelControl1.Controls.Add(this.filtertbxMemo);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelControl1.Size = new System.Drawing.Size(1019, 74);
            this.panelControl1.TabIndex = 0;
            // 
            // BtnResetFilters
            // 
            this.BtnResetFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnResetFilters.Location = new System.Drawing.Point(136, 37);
            this.BtnResetFilters.Name = "BtnResetFilters";
            this.BtnResetFilters.Size = new System.Drawing.Size(100, 26);
            this.BtnResetFilters.TabIndex = 23;
            this.BtnResetFilters.Text = "مقدار اولیه فیلترها";
            this.BtnResetFilters.Click += new System.EventHandler(this.BtnResetFilters_Click);
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearFilters.Location = new System.Drawing.Point(242, 37);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(100, 26);
            this.btnClearFilters.TabIndex = 22;
            this.btnClearFilters.Text = "خالی کردن فیتلرها";
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // filtercmbCustomer
            // 
            this.filtercmbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtercmbCustomer.Location = new System.Drawing.Point(514, 14);
            this.filtercmbCustomer.Name = "filtercmbCustomer";
            this.filtercmbCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filtercmbCustomer.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("THesabcode", "کد طرف حساب"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TName", "نام و نام خانوادگی")});
            this.filtercmbCustomer.Properties.NullText = "";
            this.filtercmbCustomer.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.filtercmbCustomer.Size = new System.Drawing.Size(200, 20);
            this.filtercmbCustomer.TabIndex = 13;
            // 
            // filtercmbVisitor
            // 
            this.filtercmbVisitor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtercmbVisitor.Location = new System.Drawing.Point(763, 14);
            this.filtercmbVisitor.Name = "filtercmbVisitor";
            this.filtercmbVisitor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filtercmbVisitor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Visitor_Code", "کد ویزیتور"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Visitor_Name", "نام و نام خانوادگی")});
            this.filtercmbVisitor.Properties.NullText = "";
            this.filtercmbVisitor.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.filtercmbVisitor.Size = new System.Drawing.Size(200, 20);
            this.filtercmbVisitor.TabIndex = 11;
            // 
            // btnFilterSearch
            // 
            this.btnFilterSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilterSearch.Location = new System.Drawing.Point(349, 37);
            this.btnFilterSearch.Name = "btnFilterSearch";
            this.btnFilterSearch.Size = new System.Drawing.Size(100, 26);
            this.btnFilterSearch.TabIndex = 19;
            this.btnFilterSearch.Text = "جستجو";
            this.btnFilterSearch.Click += new System.EventHandler(this.btnFilterSearch_Click);
            // 
            // filtertbxToTime
            // 
            this.filtertbxToTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtertbxToTime.Format = Atf.UI.DateTimeSelectorFormat.Long;
            this.filtertbxToTime.Location = new System.Drawing.Point(514, 38);
            this.filtertbxToTime.Name = "filtertbxToTime";
            this.filtertbxToTime.Size = new System.Drawing.Size(200, 22);
            this.filtertbxToTime.TabIndex = 17;
            this.filtertbxToTime.UsePersianFormat = true;
            // 
            // filtertbxFromTime
            // 
            this.filtertbxFromTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtertbxFromTime.Format = Atf.UI.DateTimeSelectorFormat.Long;
            this.filtertbxFromTime.Location = new System.Drawing.Point(763, 38);
            this.filtertbxFromTime.Name = "filtertbxFromTime";
            this.filtertbxFromTime.Size = new System.Drawing.Size(200, 22);
            this.filtertbxFromTime.TabIndex = 16;
            this.filtertbxFromTime.UsePersianFormat = true;
            // 
            // filtertbxMemo
            // 
            this.filtertbxMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filtertbxMemo.Location = new System.Drawing.Point(136, 12);
            this.filtertbxMemo.Name = "filtertbxMemo";
            this.filtertbxMemo.Size = new System.Drawing.Size(313, 20);
            this.filtertbxMemo.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(454, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "توضیحات";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(729, 43);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "تا";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(969, 43);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(7, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "از";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(718, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "مشتری";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(968, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 12;
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
            this.splitContainer2.Panel1.Controls.Add(this.dgvOrderDetails);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvOrders);
            this.splitContainer2.Size = new System.Drawing.Size(1019, 404);
            this.splitContainer2.SplitterDistance = 486;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetails.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetails.MainView = this.dgvOrderDetailss;
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOrderDetails.Size = new System.Drawing.Size(486, 404);
            this.dgvOrderDetails.TabIndex = 1;
            this.dgvOrderDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvOrderDetailss});
            this.dgvOrderDetails.Click += new System.EventHandler(this.dgvOrderDetails_Click);
            // 
            // dgvOrderDetailss
            // 
            this.dgvOrderDetailss.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.K_Name,
            this.BarCode,
            this.K_Price,
            this.PK_Amount,
            this.Reduction_p,
            this.RowPrice});
            this.dgvOrderDetailss.GridControl = this.dgvOrderDetails;
            this.dgvOrderDetailss.Name = "dgvOrderDetailss";
            this.dgvOrderDetailss.OptionsBehavior.Editable = false;
            this.dgvOrderDetailss.OptionsView.ShowFooter = true;
            // 
            // K_Name
            // 
            this.K_Name.Caption = "نام کالا";
            this.K_Name.FieldName = "K_Name";
            this.K_Name.Name = "K_Name";
            this.K_Name.Visible = true;
            this.K_Name.VisibleIndex = 0;
            this.K_Name.Width = 120;
            // 
            // BarCode
            // 
            this.BarCode.Caption = "بارکد";
            this.BarCode.FieldName = "BarCode";
            this.BarCode.Name = "BarCode";
            this.BarCode.Visible = true;
            this.BarCode.VisibleIndex = 1;
            // 
            // K_Price
            // 
            this.K_Price.Caption = "قیمت واحد";
            this.K_Price.DisplayFormat.FormatString = "N0";
            this.K_Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.K_Price.FieldName = "K_Price";
            this.K_Price.Name = "K_Price";
            this.K_Price.Visible = true;
            this.K_Price.VisibleIndex = 2;
            // 
            // PK_Amount
            // 
            this.PK_Amount.Caption = "تعداد";
            this.PK_Amount.DisplayFormat.FormatString = "N0";
            this.PK_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PK_Amount.FieldName = "PK_Amount";
            this.PK_Amount.Name = "PK_Amount";
            this.PK_Amount.Visible = true;
            this.PK_Amount.VisibleIndex = 3;
            // 
            // Reduction_p
            // 
            this.Reduction_p.Caption = "تخفیف";
            this.Reduction_p.DisplayFormat.FormatString = "N0";
            this.Reduction_p.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Reduction_p.FieldName = "Reduction_p";
            this.Reduction_p.Name = "Reduction_p";
            this.Reduction_p.Visible = true;
            this.Reduction_p.VisibleIndex = 4;
            // 
            // RowPrice
            // 
            this.RowPrice.AppearanceCell.Options.UseTextOptions = true;
            this.RowPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RowPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.RowPrice.Caption = "مبلغ کل ردیف";
            this.RowPrice.DisplayFormat.FormatString = "N0";
            this.RowPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RowPrice.FieldName = "RowPrice";
            this.RowPrice.GroupFormat.FormatString = "N0";
            this.RowPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RowPrice.Name = "RowPrice";
            this.RowPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RowPrice", "کل ={0:N0}")});
            this.RowPrice.Visible = true;
            this.RowPrice.VisibleIndex = 5;
            // 
            // dgvOrders
            // 
            this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrders.Location = new System.Drawing.Point(0, 0);
            this.dgvOrders.MainView = this.dgvOrderss;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOrders.Size = new System.Drawing.Size(529, 404);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvOrderss});
            // 
            // dgvOrderss
            // 
            this.dgvOrderss.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.PInv_Code,
            this.VisitorName,
            this.CustomerName,
            this.SaveTimeFa,
            this.InvMemo,
            this.Address,
            this.InvPrice});
            this.dgvOrderss.GridControl = this.dgvOrders;
            this.dgvOrderss.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", null, "* تعداد ={0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InvPrice", null, "* مبلغ کل ={0:N0}")});
            this.dgvOrderss.Name = "dgvOrderss";
            this.dgvOrderss.OptionsBehavior.Editable = false;
            this.dgvOrderss.OptionsView.ShowFooter = true;
            this.dgvOrderss.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvOrderss_FocusedRowChanged);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // PInv_Code
            // 
            this.PInv_Code.Caption = "PInv_Code";
            this.PInv_Code.FieldName = "PInv_Code";
            this.PInv_Code.Name = "PInv_Code";
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
            this.VisitorName.Width = 82;
            // 
            // CustomerName
            // 
            this.CustomerName.Caption = "مشتری";
            this.CustomerName.FieldName = "CustomerName";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Visible = true;
            this.CustomerName.VisibleIndex = 1;
            this.CustomerName.Width = 82;
            // 
            // SaveTimeFa
            // 
            this.SaveTimeFa.Caption = "تاریخ";
            this.SaveTimeFa.FieldName = "SaveTimeFa";
            this.SaveTimeFa.Name = "SaveTimeFa";
            this.SaveTimeFa.Visible = true;
            this.SaveTimeFa.VisibleIndex = 2;
            this.SaveTimeFa.Width = 93;
            // 
            // InvMemo
            // 
            this.InvMemo.Caption = "توضیحات";
            this.InvMemo.FieldName = "InvMemo";
            this.InvMemo.Name = "InvMemo";
            this.InvMemo.Visible = true;
            this.InvMemo.VisibleIndex = 3;
            this.InvMemo.Width = 73;
            // 
            // Address
            // 
            this.Address.Caption = "آدرس";
            this.Address.FieldName = "Address";
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 4;
            this.Address.Width = 77;
            // 
            // InvPrice
            // 
            this.InvPrice.AppearanceCell.Options.UseTextOptions = true;
            this.InvPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.InvPrice.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.InvPrice.Caption = "مبلغ درخواست";
            this.InvPrice.DisplayFormat.FormatString = "N0";
            this.InvPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.InvPrice.FieldName = "InvPrice";
            this.InvPrice.GroupFormat.FormatString = "N0";
            this.InvPrice.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.InvPrice.Name = "InvPrice";
            this.InvPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InvPrice", "کل ={0:N0}")});
            this.InvPrice.Visible = true;
            this.InvPrice.VisibleIndex = 5;
            this.InvPrice.Width = 120;
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 482);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmOrders";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درخواست ها";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtercmbVisitor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtertbxMemo.Properties)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetailss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderss)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraGrid.GridControl dgvOrderDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvOrderDetailss;
        private DevExpress.XtraGrid.GridControl dgvOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvOrderss;
        private DevExpress.XtraEditors.SimpleButton BtnResetFilters;
        private DevExpress.XtraEditors.SimpleButton btnClearFilters;
        private DevExpress.XtraEditors.LookUpEdit filtercmbCustomer;
        private DevExpress.XtraEditors.LookUpEdit filtercmbVisitor;
        private DevExpress.XtraEditors.SimpleButton btnFilterSearch;
        private Atf.UI.DateTimeSelector filtertbxToTime;
        private Atf.UI.DateTimeSelector filtertbxFromTime;
        private DevExpress.XtraEditors.TextEdit filtertbxMemo;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn PInv_Code;
        private DevExpress.XtraGrid.Columns.GridColumn VisitorName;
        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn SaveTimeFa;
        private DevExpress.XtraGrid.Columns.GridColumn InvMemo;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraGrid.Columns.GridColumn K_Name;
        private DevExpress.XtraGrid.Columns.GridColumn BarCode;
        private DevExpress.XtraGrid.Columns.GridColumn K_Price;
        private DevExpress.XtraGrid.Columns.GridColumn PK_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn Reduction_p;
        private DevExpress.XtraGrid.Columns.GridColumn RowPrice;
        private DevExpress.XtraGrid.Columns.GridColumn InvPrice;
    }
}