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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.network;
        }




        private void btnok_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txtname.Text) || string.IsNullOrWhiteSpace(Txtpassword.Text))
                {
                    MessageBox.Show(@"نام کاربری و رمز عبور را وارد نمایید");
                    return;
                }

                var user = GlobalService.Repository.GetUser(Txtname.Text.ToInt(),
                    MD5Hasher.ComputeHashMIS(Txtpassword.Text));
                if (user != null)
                {
                    if (user.IsActive == false)
                    {
                        MessageBox.Show(@"کاربر غیرفعال است");
                        return;
                    }
                    GlobalService.LoginUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(@"نام کاربری یا رمز عبور اشتباه است");
                }
            }
            catch (Exception ex)
            {
                ErrorLog.SaveLog(ex);
            }
        }

        private void btncancell_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        

        private void Txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnok_Click(null, null);
            }
        }
    }
}