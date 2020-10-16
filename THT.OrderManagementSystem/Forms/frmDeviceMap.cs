using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using THT.OrderManagementSystem.Framework;
using THT.OrderManagementSystem.Services;

namespace THT.OrderManagementSystem.Forms
{
    public partial class frmDeviceMap : DevExpress.XtraEditors.XtraForm
    {
        public frmDeviceMap()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            try
            {
                var lst = GlobalService.Repository.GetAllDeviceMap();
                dgvDeviceMap.DataSource = lst;
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void Edit()
        {
            try
            {
                var selected = dgvDeviceMaps.GetSelectedRows();
                if (selected == null || selected.Length <= 0) return;
                var id = Convert.ToInt32(dgvDeviceMaps.GetRowCellDisplayText(dgvDeviceMaps.FocusedRowHandle, dgvDeviceMaps.Columns["ID"]));
                var obj = GlobalService.Repository.GetDeviceMap(id);
                if (obj != null)
                {
                    var frm = new frmDeviceMapManage(obj);
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        GlobalService.Repository.UpdateDeviceMap(frm.CurrentDeviceMap);
                        BindGrid();
                    }
                }
                else
                {
                    MessageBox.Show(@"ردیفی انتخاب نشده است ، لطفا ردیف مورد نظر را برای ویرایش انتخاب کنید");
                }
                
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }
        private void tsMenuBarEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Edit();
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void tsMenuEdit_ItemClick(object sender, TileItemEventArgs e)
        {
            try
            {
                Edit();
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void dgvDeviceMaps_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (!dgvDeviceMaps.IsFilterRow(dgvDeviceMaps.FocusedRowHandle) || dgvDeviceMaps.RowCount == 0)
            {
                e.Allow = false;
                radialMenu1.ShowPopup(dgvDeviceMap.PointToScreen(e.Point));
            }
            else
            {
                e.Allow = true;
            }
        }

        private void frmDeviceMap_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}