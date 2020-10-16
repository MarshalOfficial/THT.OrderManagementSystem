namespace THT.OrderManagementSystem.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.rbtnBrandBank = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnLocationLog = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnVisitLog = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnShopScan = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiSkins = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnCurrentDate = new DevExpress.XtraBars.BarButtonItem();
            this.rbtnOrders = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.rbtnDeviceMap = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonMain
            // 
            this.ribbonMain.ExpandCollapseItem.Id = 0;
            this.ribbonMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonMain.ExpandCollapseItem,
            this.rbtnBrandBank,
            this.rbtnLocationLog,
            this.rbtnVisitLog,
            this.rbtnShopScan,
            this.rgbiSkins,
            this.btnCurrentDate,
            this.rbtnOrders,
            this.rbtnDeviceMap});
            this.ribbonMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.MaxItemId = 11;
            this.ribbonMain.Name = "ribbonMain";
            this.ribbonMain.PageHeaderItemLinks.Add(this.rgbiSkins);
            this.ribbonMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonMain.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonMain.Size = new System.Drawing.Size(831, 165);
            this.ribbonMain.StatusBar = this.ribbonStatusBar1;
            // 
            // rbtnBrandBank
            // 
            this.rbtnBrandBank.Caption = "بانک برندهای بازار";
            this.rbtnBrandBank.Id = 1;
            this.rbtnBrandBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnBrandBank.ImageOptions.Image")));
            this.rbtnBrandBank.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnBrandBank.ImageOptions.LargeImage")));
            this.rbtnBrandBank.Name = "rbtnBrandBank";
            this.rbtnBrandBank.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnBrandBank_ItemClick);
            // 
            // rbtnLocationLog
            // 
            this.rbtnLocationLog.Caption = "لاگ موقعیت مکانی کاربران";
            this.rbtnLocationLog.Id = 2;
            this.rbtnLocationLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnLocationLog.ImageOptions.Image")));
            this.rbtnLocationLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnLocationLog.ImageOptions.LargeImage")));
            this.rbtnLocationLog.Name = "rbtnLocationLog";
            this.rbtnLocationLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnLocationLog_ItemClick);
            // 
            // rbtnVisitLog
            // 
            this.rbtnVisitLog.Caption = "لاگ ویزیت";
            this.rbtnVisitLog.Id = 3;
            this.rbtnVisitLog.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnVisitLog.ImageOptions.Image")));
            this.rbtnVisitLog.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnVisitLog.ImageOptions.LargeImage")));
            this.rbtnVisitLog.Name = "rbtnVisitLog";
            this.rbtnVisitLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnVisitLog_ItemClick);
            // 
            // rbtnShopScan
            // 
            this.rbtnShopScan.Caption = "گزارش اسکن فروشگاه";
            this.rbtnShopScan.Id = 4;
            this.rbtnShopScan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnShopScan.ImageOptions.Image")));
            this.rbtnShopScan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnShopScan.ImageOptions.LargeImage")));
            this.rbtnShopScan.Name = "rbtnShopScan";
            this.rbtnShopScan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnShopScan_ItemClick);
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "skinRibbonGalleryBarItem1";
            this.rgbiSkins.Id = 7;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // btnCurrentDate
            // 
            this.btnCurrentDate.Id = 8;
            this.btnCurrentDate.Name = "btnCurrentDate";
            // 
            // rbtnOrders
            // 
            this.rbtnOrders.Caption = "درخواست ها";
            this.rbtnOrders.Id = 9;
            this.rbtnOrders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnOrders.ImageOptions.Image")));
            this.rbtnOrders.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnOrders.ImageOptions.LargeImage")));
            this.rbtnOrders.Name = "rbtnOrders";
            this.rbtnOrders.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnOrders_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "منوی اصلی";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.rbtnBrandBank);
            this.ribbonPageGroup1.ItemLinks.Add(this.rbtnDeviceMap);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "اطلاعات اولیه";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.rbtnOrders);
            this.ribbonPageGroup2.ItemLinks.Add(this.rbtnLocationLog);
            this.ribbonPageGroup2.ItemLinks.Add(this.rbtnVisitLog);
            this.ribbonPageGroup2.ItemLinks.Add(this.rbtnShopScan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "گزارشات";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.btnCurrentDate);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 468);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonMain;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(831, 21);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Name = "galleryDropDown1";
            this.galleryDropDown1.Ribbon = this.ribbonMain;
            // 
            // rbtnDeviceMap
            // 
            this.rbtnDeviceMap.Caption = "تنظیمات سقف پورسانت و ویزیت";
            this.rbtnDeviceMap.Id = 10;
            this.rbtnDeviceMap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("rbtnDeviceMap.ImageOptions.Image")));
            this.rbtnDeviceMap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnDeviceMap.ImageOptions.LargeImage")));
            this.rbtnDeviceMap.Name = "rbtnDeviceMap";
            this.rbtnDeviceMap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.rbtnDeviceMap_ItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 489);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonMain);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonMain;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "سیستم مدیریت پخش مویرگی عرفان";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonMain;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem rbtnBrandBank;
        private DevExpress.XtraBars.BarButtonItem rbtnLocationLog;
        private DevExpress.XtraBars.BarButtonItem rbtnVisitLog;
        private DevExpress.XtraBars.BarButtonItem rbtnShopScan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem btnCurrentDate;
        private DevExpress.XtraBars.BarButtonItem rbtnOrders;
        private DevExpress.XtraBars.BarButtonItem rbtnDeviceMap;
    }
}