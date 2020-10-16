namespace THT.OrderManagementSystem.Forms
{
    partial class frmLogin
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
            this.lblusername = new DevExpress.XtraEditors.LabelControl();
            this.lblpassword = new DevExpress.XtraEditors.LabelControl();
            this.Txtname = new DevExpress.XtraEditors.TextEdit();
            this.Txtpassword = new DevExpress.XtraEditors.TextEdit();
            this.btnok = new DevExpress.XtraEditors.SimpleButton();
            this.btncancell = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtpassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusername
            // 
            this.lblusername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblusername.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblusername.Appearance.Options.UseFont = true;
            this.lblusername.Location = new System.Drawing.Point(299, 40);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(58, 17);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "نام کاربری";
            // 
            // lblpassword
            // 
            this.lblpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpassword.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lblpassword.Appearance.Options.UseFont = true;
            this.lblpassword.Location = new System.Drawing.Point(315, 82);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(42, 17);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "رمزعبور";
            // 
            // Txtname
            // 
            this.Txtname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtname.EditValue = "";
            this.Txtname.EnterMoveNextControl = true;
            this.Txtname.Location = new System.Drawing.Point(77, 37);
            this.Txtname.Name = "Txtname";
            this.Txtname.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Txtname.Properties.Appearance.Options.UseFont = true;
            this.Txtname.Size = new System.Drawing.Size(215, 22);
            this.Txtname.TabIndex = 0;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtpassword.EditValue = "";
            this.Txtpassword.Location = new System.Drawing.Point(77, 80);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Txtpassword.Properties.Appearance.Options.UseFont = true;
            this.Txtpassword.Properties.PasswordChar = '*';
            this.Txtpassword.Size = new System.Drawing.Size(215, 22);
            this.Txtpassword.TabIndex = 1;
            this.Txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtpassword_KeyDown);
            // 
            // btnok
            // 
            this.btnok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnok.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btnok.Appearance.Options.UseFont = true;
            this.btnok.Location = new System.Drawing.Point(173, 116);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(90, 40);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "ورود";
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancell
            // 
            this.btncancell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancell.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btncancell.Appearance.Options.UseFont = true;
            this.btncancell.Location = new System.Drawing.Point(77, 116);
            this.btncancell.Name = "btncancell";
            this.btncancell.Size = new System.Drawing.Size(90, 40);
            this.btncancell.TabIndex = 3;
            this.btncancell.Text = "خروج";
            this.btncancell.Click += new System.EventHandler(this.btncancell_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 195);
            this.Controls.Add(this.btncancell);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.Txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.MaximumSize = new System.Drawing.Size(422, 234);
            this.MinimumSize = new System.Drawing.Size(422, 234);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سیستم";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.Txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txtpassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblusername;
        private DevExpress.XtraEditors.LabelControl lblpassword;
        private DevExpress.XtraEditors.TextEdit Txtname;
        private DevExpress.XtraEditors.TextEdit Txtpassword;
        private DevExpress.XtraEditors.SimpleButton btnok;
        private DevExpress.XtraEditors.SimpleButton btncancell;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}