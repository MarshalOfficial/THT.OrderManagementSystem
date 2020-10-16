using System;
using System.Windows.Forms;
using THT.OrderManagementSystem.Data;
using THT.OrderManagementSystem.Framework;
using Exception = System.Exception;
namespace THT.OrderManagementSystem.Forms
{
    public partial class frmDeviceMapManage : DevExpress.XtraEditors.XtraForm
    {
        public DeviceMap CurrentDeviceMap;
        public frmDeviceMapManage(DeviceMap obj)
        {
            InitializeComponent();
            CurrentDeviceMap = obj;
        }

        private void frmDeviceMapManage_Load(object sender, EventArgs e)
        {
            try
            {
                if (CurrentDeviceMap != null)
                {
                    tbxVisitorName.Text = CurrentDeviceMap.Name;
                    tbxVisitorDeviceName.Text = CurrentDeviceMap.Value;
                    tbxTargetValue.EditValue = CurrentDeviceMap.TargetValue;
                    tbxTargetValue1.EditValue = CurrentDeviceMap.TargetValue1;
                    tbxTargetValue2.EditValue = CurrentDeviceMap.TargetValue2;
                    tbxTargetValue3.EditValue = CurrentDeviceMap.TargetValue3;
                    tbxTargetValue4.EditValue = CurrentDeviceMap.TargetValue4;
                    tbxTargetValue5.EditValue = CurrentDeviceMap.TargetValue5;
                    tbxTargetValue6.EditValue = CurrentDeviceMap.TargetValue6;
                    tbxTargetValue7.EditValue = CurrentDeviceMap.TargetValue7;
                    tbxTargetValue8.EditValue = CurrentDeviceMap.TargetValue8;
                    tbxTargetValue9.EditValue = CurrentDeviceMap.TargetValue9;
                    tbxTargetValue10.EditValue = CurrentDeviceMap.TargetValue10;
                    tbxTargetValue11.EditValue = CurrentDeviceMap.TargetValue11;
                    tbxVisitLogCountTarget.EditValue = CurrentDeviceMap.VisitLogCountTarget;
                    tbxVisitLogCountTarget1.EditValue = CurrentDeviceMap.VisitLogCountTarget1;
                    tbxVisitLogCountTarget2.EditValue = CurrentDeviceMap.VisitLogCountTarget2;
                    tbxVisitLogCountTarget3.EditValue = CurrentDeviceMap.VisitLogCountTarget3;
                    tbxVisitLogCountTarget4.EditValue = CurrentDeviceMap.VisitLogCountTarget4;
                    tbxVisitLogCountTarget5.EditValue = CurrentDeviceMap.VisitLogCountTarget5;
                    tbxVisitLogCountTarget6.EditValue = CurrentDeviceMap.VisitLogCountTarget6;
                    tbxVisitLogCountTarget7.EditValue = CurrentDeviceMap.VisitLogCountTarget7;
                    tbxVisitLogCountTarget8.EditValue = CurrentDeviceMap.VisitLogCountTarget8;
                    tbxVisitLogCountTarget9.EditValue = CurrentDeviceMap.VisitLogCountTarget9;
                    tbxVisitLogCountTarget10.EditValue = CurrentDeviceMap.VisitLogCountTarget10;
                    tbxVisitLogCountTarget11.EditValue = CurrentDeviceMap.VisitLogCountTarget11;
                }
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                CurrentDeviceMap.TargetValue = tbxTargetValue.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue1 = tbxTargetValue1.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue2 = tbxTargetValue2.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue3 = tbxTargetValue3.EditValue.ToDecimal(); 
                CurrentDeviceMap.TargetValue4 = tbxTargetValue4.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue5 = tbxTargetValue5.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue6 = tbxTargetValue6.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue7 = tbxTargetValue7.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue8 = tbxTargetValue8.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue9 = tbxTargetValue9.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue10 = tbxTargetValue10.EditValue.ToDecimal();
                CurrentDeviceMap.TargetValue11 = tbxTargetValue11.EditValue.ToDecimal();
                CurrentDeviceMap.VisitLogCountTarget = tbxVisitLogCountTarget.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget1 = tbxVisitLogCountTarget1.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget2 = tbxVisitLogCountTarget2.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget3 = tbxVisitLogCountTarget3.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget4 = tbxVisitLogCountTarget4.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget5 = tbxVisitLogCountTarget5.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget6 = tbxVisitLogCountTarget6.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget7 = tbxVisitLogCountTarget7.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget8 = tbxVisitLogCountTarget8.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget9 = tbxVisitLogCountTarget9.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget10 = tbxVisitLogCountTarget10.EditValue.ToInt();
                CurrentDeviceMap.VisitLogCountTarget11 = tbxVisitLogCountTarget11.EditValue.ToInt();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception)
            {
                ErrorLog.SaveLog(exception);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmDeviceMapManage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(null, null);
            }
        }
    }
}