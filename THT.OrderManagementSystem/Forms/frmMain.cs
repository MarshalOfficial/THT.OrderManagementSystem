using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using THT.OrderManagementSystem.Framework;
using THT.OrderManagementSystem.Services;

namespace THT.OrderManagementSystem.Forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly List<Form> lstForms;
        public frmMain()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(rgbiSkins);
            lstForms = new List<Form>();
            this.Icon = Properties.Resources.network;
            btnCurrentDate.Caption = Framework.Date.Methods.CurrentShamsiDate();
            rbtnDeviceMap.Visibility =
                (GlobalService.LoginUser.User_ID == 100 || GlobalService.LoginUser.User_ID == 3361)
                    ? BarItemVisibility.Always
                    : BarItemVisibility.Never;
        }

        private void rbtnBrandBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lstForms.Any(l => l.Name == "frmBrandBank"))
                {
                    var ff = lstForms.FirstOrDefault(l => l.Name == "frmBrandBank");
                    if (ff == null) return;
                    ff.WindowState = FormWindowState.Maximized;
                    ff.BringToFront();
                }
                else
                {
                    var frmHazine = new frmBrandBank { MdiParent = this };
                    frmHazine.FormClosed += FrmHazine_FormClosed;
                    lstForms.Add(frmHazine);
                    frmHazine.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void FrmHazine_FormClosed(object sender, FormClosedEventArgs e)
        {
            lstForms.Remove(sender as Form);
        }

        private void rbtnLocationLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lstForms.Any(l => l.Name == "frmLocationLog"))
                {
                    var ff = lstForms.FirstOrDefault(l => l.Name == "frmLocationLog");
                    if (ff == null) return;
                    ff.WindowState = FormWindowState.Maximized;
                    ff.BringToFront();
                }
                else
                {
                    var frmHazine = new frmLocationLog { MdiParent = this };
                    frmHazine.FormClosed += FrmHazine_FormClosed;
                    lstForms.Add(frmHazine);
                    frmHazine.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void rbtnVisitLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lstForms.Any(l => l.Name == "frmVisitLog"))
                {
                    var ff = lstForms.FirstOrDefault(l => l.Name == "frmVisitLog");
                    if (ff == null) return;
                    ff.WindowState = FormWindowState.Maximized;
                    ff.BringToFront();
                }
                else
                {
                    var frmHazine = new frmVisitLog { MdiParent = this };
                    frmHazine.FormClosed += FrmHazine_FormClosed;
                    lstForms.Add(frmHazine);
                    frmHazine.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void rbtnShopScan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lstForms.Any(l => l.Name == "frmShopScan"))
                {
                    var ff = lstForms.FirstOrDefault(l => l.Name == "frmShopScan");
                    if (ff == null) return;
                    ff.WindowState = FormWindowState.Maximized;
                    ff.BringToFront();
                }
                else
                {
                    var frmHazine = new frmShopScan { MdiParent = this };
                    frmHazine.FormClosed += FrmHazine_FormClosed;
                    lstForms.Add(frmHazine);
                    frmHazine.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void rbtnOrders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lstForms.Any(l => l.Name == "frmOrders"))
                {
                    var ff = lstForms.FirstOrDefault(l => l.Name == "frmOrders");
                    if (ff == null) return;
                    ff.WindowState = FormWindowState.Maximized;
                    ff.BringToFront();
                }
                else
                {
                    var frmHazine = new frmOrders { MdiParent = this };
                    frmHazine.FormClosed += FrmHazine_FormClosed;
                    lstForms.Add(frmHazine);
                    frmHazine.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void rbtnDeviceMap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (lstForms.Any(l => l.Name == "frmDeviceMap"))
                {
                    var ff = lstForms.FirstOrDefault(l => l.Name == "frmDeviceMap");
                    if (ff == null) return;
                    ff.WindowState = FormWindowState.Maximized;
                    ff.BringToFront();
                }
                else
                {
                    var frm = new frmDeviceMap { MdiParent = this };
                    frm.FormClosed += FrmHazine_FormClosed;
                    lstForms.Add(frm);
                    frm.Show();
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }
    }
}