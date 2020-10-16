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
    public partial class frmOrders : DevExpress.XtraEditors.XtraForm
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            try
            {
                filtercmbVisitor.Properties.DisplayMember = "Visitor_Name";
                filtercmbVisitor.Properties.ValueMember = "Visitor_Code";
                filtercmbVisitor.Properties.DataSource = GlobalService.Repository.GetAllVisitors();
                filtercmbCustomer.Properties.DisplayMember = "TName";
                filtercmbCustomer.Properties.ValueMember = "THesabcode";
                filtercmbCustomer.Properties.DataSource = GlobalService.Repository.GetAllCustomers();
                filtertbxFromTime.Value = filtertbxToTime.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void btnFilterSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int? fvisitorcode = null;
                var fthesabcode = string.Empty;
                if (filtercmbVisitor.EditValue != null)
                {
                    fvisitorcode = filtercmbVisitor.EditValue.ToInt();
                }

                if (filtercmbCustomer.EditValue != null)
                {
                    fthesabcode = filtercmbCustomer.EditValue.ToString();
                }

                
                dgvOrders.DataSource = GlobalService.Repository.GetAllInvHeaders(fvisitorcode,
                    fthesabcode, filtertbxMemo.Text, filtertbxFromTime.Value,
                    filtertbxToTime.Value); 
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            try
            {
                filtercmbVisitor.EditValue = filtercmbCustomer.EditValue = null;
                filtertbxMemo.Text = string.Empty;
                filtertbxFromTime.Value = filtertbxToTime.Value = null;
                btnFilterSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void BtnResetFilters_Click(object sender, EventArgs e)
        {
            try
            {
                filtercmbVisitor.EditValue = filtercmbCustomer.EditValue = null;
                filtertbxMemo.Text = string.Empty;
                filtertbxFromTime.Value = filtertbxToTime.Value = DateTime.Now;
                btnFilterSearch_Click(null, null);
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void dgvOrderss_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if (dgvOrderss.IsFilterRow(dgvOrderss.FocusedRowHandle)) return;
                var selected = dgvOrderss.GetSelectedRows();
                if (selected == null || selected.Length <= 0) return;
                var id = dgvOrderss.GetRowCellDisplayText(dgvOrderss.FocusedRowHandle, dgvOrderss.Columns["PInv_Code"]);
                if(string.IsNullOrWhiteSpace(id)) return;
                dgvOrderDetails.DataSource = GlobalService.Repository.GetAllInvDetailsByHeader(id);
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void dgvOrderDetails_Click(object sender, EventArgs e)
        {

        }
    }
}