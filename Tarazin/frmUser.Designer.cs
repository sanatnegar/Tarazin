namespace Tarazin
{
    partial class frmUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbUserActive = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRepeatitive = new System.Windows.Forms.Label();
            this.cmbAccessLevel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbUserActive);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblRepeatitive);
            this.groupBox1.Controls.Add(this.cmbAccessLevel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLastname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 211);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مشخصات کاربر";
            // 
            // cmbUserActive
            // 
            this.cmbUserActive.FormattingEnabled = true;
            this.cmbUserActive.Location = new System.Drawing.Point(113, 169);
            this.cmbUserActive.Name = "cmbUserActive";
            this.cmbUserActive.Size = new System.Drawing.Size(66, 24);
            this.cmbUserActive.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "فعال:";
            // 
            // lblRepeatitive
            // 
            this.lblRepeatitive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeatitive.ForeColor = System.Drawing.Color.Red;
            this.lblRepeatitive.Location = new System.Drawing.Point(8, 83);
            this.lblRepeatitive.Name = "lblRepeatitive";
            this.lblRepeatitive.Size = new System.Drawing.Size(61, 16);
            this.lblRepeatitive.TabIndex = 20;
            this.lblRepeatitive.Text = "تکراری";
            this.lblRepeatitive.Visible = false;
            // 
            // cmbAccessLevel
            // 
            this.cmbAccessLevel.FormattingEnabled = true;
            this.cmbAccessLevel.Location = new System.Drawing.Point(75, 139);
            this.cmbAccessLevel.Name = "cmbAccessLevel";
            this.cmbAccessLevel.Size = new System.Drawing.Size(104, 24);
            this.cmbAccessLevel.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "سطح دسترسی:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(75, 109);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(104, 23);
            this.txtPassword.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "کلمه عبور:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(75, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(104, 23);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "نام کاربری:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(8, 51);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(171, 23);
            this.txtLastname.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "نام خانوادگی:";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(94, 22);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(85, 23);
            this.txtfirstname.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "نام:";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(13, 229);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(127, 35);
            this.btnAction.TabIndex = 11;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(179, 229);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 35);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.ComboBox cmbAccessLevel;
        private System.Windows.Forms.Label lblRepeatitive;
        public System.Windows.Forms.ComboBox cmbUserActive;
        private System.Windows.Forms.Label label6;
    }
}