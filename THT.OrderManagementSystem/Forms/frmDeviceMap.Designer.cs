namespace THT.OrderManagementSystem.Forms
{
    partial class frmDeviceMap
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
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeviceMap));
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tsMenuEdit = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.dgvDeviceMap = new DevExpress.XtraGrid.GridControl();
            this.dgvDeviceMaps = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.radialMenu1 = new DevExpress.XtraBars.Ribbon.RadialMenu(this.components);
            this.tsMenuBarEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitorCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MapColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TargetValue11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.VisitLogCountTarget11 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceMaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.tileBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 4;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1027, 102);
            this.tileBar1.TabIndex = 8;
            this.tileBar1.Text = "tileBar1";
            this.tileBar1.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Center;
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.tsMenuEdit);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // tsMenuEdit
            // 
            this.tsMenuEdit.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.Text = "ویرایش";
            this.tsMenuEdit.Elements.Add(tileItemElement5);
            this.tsMenuEdit.Id = 0;
            this.tsMenuEdit.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tsMenuEdit.Name = "tsMenuEdit";
            this.tsMenuEdit.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tsMenuEdit_ItemClick);
            // 
            // dgvDeviceMap
            // 
            this.dgvDeviceMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDeviceMap.Location = new System.Drawing.Point(0, 102);
            this.dgvDeviceMap.MainView = this.dgvDeviceMaps;
            this.dgvDeviceMap.MenuManager = this.barManager1;
            this.dgvDeviceMap.Name = "dgvDeviceMap";
            this.dgvDeviceMap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDeviceMap.Size = new System.Drawing.Size(1027, 313);
            this.dgvDeviceMap.TabIndex = 9;
            this.dgvDeviceMap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDeviceMaps});
            // 
            // dgvDeviceMaps
            // 
            this.dgvDeviceMaps.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.VisitorCode,
            this.MapColor,
            this.VName,
            this.VValue,
            this.TargetValue,
            this.TargetValue1,
            this.TargetValue2,
            this.TargetValue3,
            this.TargetValue4,
            this.TargetValue5,
            this.TargetValue6,
            this.TargetValue7,
            this.TargetValue8,
            this.TargetValue9,
            this.TargetValue10,
            this.TargetValue11,
            this.VisitLogCountTarget,
            this.VisitLogCountTarget1,
            this.VisitLogCountTarget2,
            this.VisitLogCountTarget3,
            this.VisitLogCountTarget4,
            this.VisitLogCountTarget5,
            this.VisitLogCountTarget6,
            this.VisitLogCountTarget7,
            this.VisitLogCountTarget8,
            this.VisitLogCountTarget9,
            this.VisitLogCountTarget10,
            this.VisitLogCountTarget11});
            this.dgvDeviceMaps.GridControl = this.dgvDeviceMap;
            this.dgvDeviceMaps.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "ID", null, "* تعداد ={0:N0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InvPrice", null, "* مبلغ کل ={0:N0}")});
            this.dgvDeviceMaps.Name = "dgvDeviceMaps";
            this.dgvDeviceMaps.OptionsBehavior.Editable = false;
            this.dgvDeviceMaps.OptionsPrint.AutoWidth = false;
            this.dgvDeviceMaps.OptionsView.ColumnAutoWidth = false;
            this.dgvDeviceMaps.OptionsView.ShowFooter = true;
            this.dgvDeviceMaps.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.dgvDeviceMaps_PopupMenuShowing);
            // 
            // radialMenu1
            // 
            this.radialMenu1.AutoExpand = true;
            this.radialMenu1.Glyph = ((System.Drawing.Image)(resources.GetObject("radialMenu1.Glyph")));
            this.radialMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.tsMenuBarEdit)});
            this.radialMenu1.Manager = this.barManager1;
            this.radialMenu1.Name = "radialMenu1";
            // 
            // tsMenuBarEdit
            // 
            this.tsMenuBarEdit.Caption = "ویرایش";
            this.tsMenuBarEdit.Id = 1;
            this.tsMenuBarEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsMenuBarEditDaramad.ImageOptions.Image")));
            this.tsMenuBarEdit.Name = "tsMenuBarEdit";
            this.tsMenuBarEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsMenuBarEdit_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tsMenuBarEdit});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 102);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1027, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 415);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1027, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 102);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 313);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1027, 102);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 313);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // VName
            // 
            this.VName.Caption = "نام ویزیتور";
            this.VName.FieldName = "Name";
            this.VName.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.VName.Name = "VName";
            this.VName.Visible = true;
            this.VName.VisibleIndex = 0;
            this.VName.Width = 112;
            // 
            // VValue
            // 
            this.VValue.Caption = "نام دستگاه";
            this.VValue.FieldName = "Value";
            this.VValue.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.VValue.Name = "VValue";
            this.VValue.Visible = true;
            this.VValue.VisibleIndex = 1;
            this.VValue.Width = 115;
            // 
            // VisitorCode
            // 
            this.VisitorCode.Caption = "کد ویزیتور";
            this.VisitorCode.FieldName = "VisitorCode";
            this.VisitorCode.Name = "VisitorCode";
            this.VisitorCode.Width = 100;
            // 
            // MapColor
            // 
            this.MapColor.Caption = "رنگ در نقشه";
            this.MapColor.FieldName = "MapColor";
            this.MapColor.Name = "MapColor";
            this.MapColor.Width = 100;
            // 
            // TargetValue
            // 
            this.TargetValue.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue.Caption = "فروردین";
            this.TargetValue.DisplayFormat.FormatString = "N0";
            this.TargetValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue.FieldName = "TargetValue";
            this.TargetValue.Name = "TargetValue";
            this.TargetValue.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue", "SUM={0:N0}")});
            this.TargetValue.Visible = true;
            this.TargetValue.VisibleIndex = 0;
            this.TargetValue.Width = 100;
            // 
            // TargetValue1
            // 
            this.TargetValue1.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue1.Caption = "اردیبهشت";
            this.TargetValue1.DisplayFormat.FormatString = "N0";
            this.TargetValue1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue1.FieldName = "TargetValue1";
            this.TargetValue1.Name = "TargetValue1";
            this.TargetValue1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue1", "SUM={0:N0}")});
            this.TargetValue1.Visible = true;
            this.TargetValue1.VisibleIndex = 1;
            this.TargetValue1.Width = 100;
            // 
            // TargetValue2
            // 
            this.TargetValue2.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue2.Caption = "خرداد";
            this.TargetValue2.DisplayFormat.FormatString = "N0";
            this.TargetValue2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue2.FieldName = "TargetValue2";
            this.TargetValue2.Name = "TargetValue2";
            this.TargetValue2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue2", "SUM={0:N0}")});
            this.TargetValue2.Visible = true;
            this.TargetValue2.VisibleIndex = 2;
            this.TargetValue2.Width = 100;
            // 
            // TargetValue3
            // 
            this.TargetValue3.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue3.Caption = "تیر";
            this.TargetValue3.DisplayFormat.FormatString = "N0";
            this.TargetValue3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue3.FieldName = "TargetValue3";
            this.TargetValue3.Name = "TargetValue3";
            this.TargetValue3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue3", "SUM={0:N0}")});
            this.TargetValue3.Visible = true;
            this.TargetValue3.VisibleIndex = 3;
            this.TargetValue3.Width = 100;
            // 
            // TargetValue4
            // 
            this.TargetValue4.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue4.Caption = "مرداد";
            this.TargetValue4.DisplayFormat.FormatString = "N0";
            this.TargetValue4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue4.FieldName = "TargetValue4";
            this.TargetValue4.Name = "TargetValue4";
            this.TargetValue4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue4", "SUM={0:N0}")});
            this.TargetValue4.Visible = true;
            this.TargetValue4.VisibleIndex = 4;
            this.TargetValue4.Width = 100;
            // 
            // TargetValue5
            // 
            this.TargetValue5.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue5.Caption = "شهریور";
            this.TargetValue5.DisplayFormat.FormatString = "N0";
            this.TargetValue5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue5.FieldName = "TargetValue5";
            this.TargetValue5.Name = "TargetValue5";
            this.TargetValue5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue5", "SUM={0:N0}")});
            this.TargetValue5.Visible = true;
            this.TargetValue5.VisibleIndex = 5;
            this.TargetValue5.Width = 100;
            // 
            // TargetValue6
            // 
            this.TargetValue6.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue6.Caption = "مهر";
            this.TargetValue6.DisplayFormat.FormatString = "N0";
            this.TargetValue6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue6.FieldName = "TargetValue6";
            this.TargetValue6.Name = "TargetValue6";
            this.TargetValue6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue6", "SUM={0:N0}")});
            this.TargetValue6.Visible = true;
            this.TargetValue6.VisibleIndex = 6;
            this.TargetValue6.Width = 100;
            // 
            // TargetValue7
            // 
            this.TargetValue7.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue7.Caption = "آبان";
            this.TargetValue7.DisplayFormat.FormatString = "N0";
            this.TargetValue7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue7.FieldName = "TargetValue7";
            this.TargetValue7.Name = "TargetValue7";
            this.TargetValue7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue7", "SUM={0:N0}")});
            this.TargetValue7.Visible = true;
            this.TargetValue7.VisibleIndex = 7;
            this.TargetValue7.Width = 100;
            // 
            // TargetValue8
            // 
            this.TargetValue8.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue8.Caption = "آذر";
            this.TargetValue8.DisplayFormat.FormatString = "N0";
            this.TargetValue8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue8.FieldName = "TargetValue8";
            this.TargetValue8.Name = "TargetValue8";
            this.TargetValue8.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue8", "SUM={0:N0}")});
            this.TargetValue8.Visible = true;
            this.TargetValue8.VisibleIndex = 8;
            this.TargetValue8.Width = 100;
            // 
            // TargetValue9
            // 
            this.TargetValue9.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue9.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue9.Caption = "دی";
            this.TargetValue9.DisplayFormat.FormatString = "N0";
            this.TargetValue9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue9.FieldName = "TargetValue9";
            this.TargetValue9.Name = "TargetValue9";
            this.TargetValue9.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue9", "SUM={0:N0}")});
            this.TargetValue9.Visible = true;
            this.TargetValue9.VisibleIndex = 9;
            this.TargetValue9.Width = 100;
            // 
            // TargetValue10
            // 
            this.TargetValue10.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue10.Caption = "بهمن";
            this.TargetValue10.DisplayFormat.FormatString = "N0";
            this.TargetValue10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue10.FieldName = "TargetValue10";
            this.TargetValue10.Name = "TargetValue10";
            this.TargetValue10.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue10", "SUM={0:N0}")});
            this.TargetValue10.Visible = true;
            this.TargetValue10.VisibleIndex = 10;
            this.TargetValue10.Width = 100;
            // 
            // TargetValue11
            // 
            this.TargetValue11.AppearanceCell.Options.UseTextOptions = true;
            this.TargetValue11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TargetValue11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TargetValue11.Caption = "اسفند";
            this.TargetValue11.DisplayFormat.FormatString = "N0";
            this.TargetValue11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TargetValue11.FieldName = "TargetValue11";
            this.TargetValue11.Name = "TargetValue11";
            this.TargetValue11.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TargetValue11", "SUM={0:N0}")});
            this.TargetValue11.Visible = true;
            this.TargetValue11.VisibleIndex = 11;
            this.TargetValue11.Width = 100;
            // 
            // VisitLogCountTarget
            // 
            this.VisitLogCountTarget.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget.Caption = "لاگ فروردین";
            this.VisitLogCountTarget.FieldName = "VisitLogCountTarget";
            this.VisitLogCountTarget.Name = "VisitLogCountTarget";
            this.VisitLogCountTarget.Visible = true;
            this.VisitLogCountTarget.VisibleIndex = 12;
            this.VisitLogCountTarget.Width = 100;
            // 
            // VisitLogCountTarget1
            // 
            this.VisitLogCountTarget1.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget1.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget1.Caption = "لاگ اردیبهشت";
            this.VisitLogCountTarget1.FieldName = "VisitLogCountTarget1";
            this.VisitLogCountTarget1.Name = "VisitLogCountTarget1";
            this.VisitLogCountTarget1.Visible = true;
            this.VisitLogCountTarget1.VisibleIndex = 13;
            this.VisitLogCountTarget1.Width = 100;
            // 
            // VisitLogCountTarget2
            // 
            this.VisitLogCountTarget2.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget2.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget2.Caption = "لاگ خرداد";
            this.VisitLogCountTarget2.FieldName = "VisitLogCountTarget2";
            this.VisitLogCountTarget2.Name = "VisitLogCountTarget2";
            this.VisitLogCountTarget2.Visible = true;
            this.VisitLogCountTarget2.VisibleIndex = 14;
            this.VisitLogCountTarget2.Width = 100;
            // 
            // VisitLogCountTarget3
            // 
            this.VisitLogCountTarget3.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget3.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget3.Caption = "لاگ تیر";
            this.VisitLogCountTarget3.FieldName = "VisitLogCountTarget3";
            this.VisitLogCountTarget3.Name = "VisitLogCountTarget3";
            this.VisitLogCountTarget3.Visible = true;
            this.VisitLogCountTarget3.VisibleIndex = 15;
            this.VisitLogCountTarget3.Width = 100;
            // 
            // VisitLogCountTarget4
            // 
            this.VisitLogCountTarget4.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget4.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget4.Caption = "لاگ مرداد";
            this.VisitLogCountTarget4.FieldName = "VisitLogCountTarget4";
            this.VisitLogCountTarget4.Name = "VisitLogCountTarget4";
            this.VisitLogCountTarget4.Visible = true;
            this.VisitLogCountTarget4.VisibleIndex = 16;
            this.VisitLogCountTarget4.Width = 100;
            // 
            // VisitLogCountTarget5
            // 
            this.VisitLogCountTarget5.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget5.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget5.Caption = "لاگ شهریور";
            this.VisitLogCountTarget5.FieldName = "VisitLogCountTarget5";
            this.VisitLogCountTarget5.Name = "VisitLogCountTarget5";
            this.VisitLogCountTarget5.Visible = true;
            this.VisitLogCountTarget5.VisibleIndex = 17;
            this.VisitLogCountTarget5.Width = 100;
            // 
            // VisitLogCountTarget6
            // 
            this.VisitLogCountTarget6.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget6.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget6.Caption = "لاگ مهر";
            this.VisitLogCountTarget6.FieldName = "VisitLogCountTarget6";
            this.VisitLogCountTarget6.Name = "VisitLogCountTarget6";
            this.VisitLogCountTarget6.Visible = true;
            this.VisitLogCountTarget6.VisibleIndex = 18;
            this.VisitLogCountTarget6.Width = 100;
            // 
            // VisitLogCountTarget7
            // 
            this.VisitLogCountTarget7.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget7.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget7.Caption = "لاگ آبان";
            this.VisitLogCountTarget7.FieldName = "VisitLogCountTarget7";
            this.VisitLogCountTarget7.Name = "VisitLogCountTarget7";
            this.VisitLogCountTarget7.Visible = true;
            this.VisitLogCountTarget7.VisibleIndex = 19;
            this.VisitLogCountTarget7.Width = 100;
            // 
            // VisitLogCountTarget8
            // 
            this.VisitLogCountTarget8.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget8.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget8.Caption = "لاگ آذر";
            this.VisitLogCountTarget8.FieldName = "VisitLogCountTarget8";
            this.VisitLogCountTarget8.Name = "VisitLogCountTarget8";
            this.VisitLogCountTarget8.Visible = true;
            this.VisitLogCountTarget8.VisibleIndex = 20;
            this.VisitLogCountTarget8.Width = 100;
            // 
            // VisitLogCountTarget9
            // 
            this.VisitLogCountTarget9.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget9.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget9.Caption = "لاگ دی";
            this.VisitLogCountTarget9.FieldName = "VisitLogCountTarget9";
            this.VisitLogCountTarget9.Name = "VisitLogCountTarget9";
            this.VisitLogCountTarget9.Visible = true;
            this.VisitLogCountTarget9.VisibleIndex = 21;
            this.VisitLogCountTarget9.Width = 100;
            // 
            // VisitLogCountTarget10
            // 
            this.VisitLogCountTarget10.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget10.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget10.Caption = "لاگ بهمن";
            this.VisitLogCountTarget10.FieldName = "VisitLogCountTarget10";
            this.VisitLogCountTarget10.Name = "VisitLogCountTarget10";
            this.VisitLogCountTarget10.Visible = true;
            this.VisitLogCountTarget10.VisibleIndex = 22;
            this.VisitLogCountTarget10.Width = 100;
            // 
            // VisitLogCountTarget11
            // 
            this.VisitLogCountTarget11.AppearanceCell.Options.UseTextOptions = true;
            this.VisitLogCountTarget11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.VisitLogCountTarget11.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.VisitLogCountTarget11.Caption = "لاگ اسفند";
            this.VisitLogCountTarget11.FieldName = "VisitLogCountTarget11";
            this.VisitLogCountTarget11.Name = "VisitLogCountTarget11";
            this.VisitLogCountTarget11.Visible = true;
            this.VisitLogCountTarget11.VisibleIndex = 25;
            this.VisitLogCountTarget11.Width = 100;
            // 
            // frmDeviceMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 415);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.dgvDeviceMap);
            this.Controls.Add(this.tileBar1);
            this.Name = "frmDeviceMap";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات سقف پورسانت و تعداد ویزیت";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDeviceMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeviceMaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem tsMenuEdit;
        private DevExpress.XtraGrid.GridControl dgvDeviceMap;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDeviceMaps;
        private DevExpress.XtraBars.Ribbon.RadialMenu radialMenu1;
        private DevExpress.XtraBars.BarButtonItem tsMenuBarEdit;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn VisitorCode;
        private DevExpress.XtraGrid.Columns.GridColumn MapColor;
        private DevExpress.XtraGrid.Columns.GridColumn VName;
        private DevExpress.XtraGrid.Columns.GridColumn VValue;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue1;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue2;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue3;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue4;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue5;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue6;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue7;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue8;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue9;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue10;
        private DevExpress.XtraGrid.Columns.GridColumn TargetValue11;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget1;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget2;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget3;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget4;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget5;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget6;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget7;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget8;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget9;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget10;
        private DevExpress.XtraGrid.Columns.GridColumn VisitLogCountTarget11;
    }
}