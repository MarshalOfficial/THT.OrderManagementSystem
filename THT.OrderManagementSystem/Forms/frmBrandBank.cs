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
using THT.OrderManagementSystem.Data;
using THT.OrderManagementSystem.Framework;
using THT.OrderManagementSystem.Services;

namespace THT.OrderManagementSystem.Forms
{
    public partial class frmBrandBank : DevExpress.XtraEditors.XtraForm
    {
        public frmBrandBank()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            try
            {
                dgvMain.DataSource = GlobalService.Repository.GetAllBrandBanks();
                tbxBrandName.Focus();
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void frmBrandBank_Load(object sender, EventArgs e)
        {
            try
            {
                BindGrid();
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void btnAddNewBrand_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (string.IsNullOrWhiteSpace(tbxBrandName.Text))
                {
                    errorProvider1.SetError(tbxBrandName,"نام برند را وارد نمایید");
                    tbxBrandName.Focus();
                    return;
                }

                if (GlobalService.Repository.GetBrandByByName(tbxBrandName.Text) != null)
                {
                    errorProvider1.SetError(tbxBrandName, "برندی با این نام در سیستم موجود است");
                    tbxBrandName.Focus();
                    tbxBrandName.SelectAll();
                    return;
                }

                GlobalService.Repository.AddBrandBank(new BrandBank() {Title = tbxBrandName.Text});
                tbxBrandName.Text = string.Empty;
                BindGrid();
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void tsMenuItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                radialMenu1.Collapse(false);
                var selected = dgvMains.GetSelectedRows();
                if (selected == null || selected.Length <= 0) return;
                if (MessageBox.Show("ردیف جاری حذف می شود ، آیا اطمینان دارید؟", "توجه", MessageBoxButtons.OKCancel) != DialogResult.OK) return;
                var id = Convert.ToInt32(dgvMains.GetRowCellDisplayText(dgvMains.FocusedRowHandle, dgvMains.Columns["ID"]));
                GlobalService.Repository.DeleteBrandBank(id);
                BindGrid();
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void dgvMains_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                if (!dgvMains.IsFilterRow(dgvMains.FocusedRowHandle) || dgvMains.RowCount == 0)
                {
                    e.Allow = false;
                    radialMenu1.ShowPopup(dgvMain.PointToScreen(e.Point));
                }
                else
                {
                    e.Allow = true;
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }
    }
}