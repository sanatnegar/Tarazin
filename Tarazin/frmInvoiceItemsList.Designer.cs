namespace Tarazin
{
    partial class frmInvoiceItemsList
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
            this.txtCustomerFullName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCutomerCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvoiceDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnInvoiceAddItem = new System.Windows.Forms.Button();
            this.btnInvoiceEditItem = new System.Windows.Forms.Button();
            this.btnInvoiceDeleteItem = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerFullName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCutomerCode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtInvoiceDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtInvoiceNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات فاکتور";
            // 
            // txtCustomerFullName
            // 
            this.txtCustomerFullName.Location = new System.Drawing.Point(6, 68);
            this.txtCustomerFullName.Name = "txtCustomerFullName";
            this.txtCustomerFullName.ReadOnly = true;
            this.txtCustomerFullName.Size = new System.Drawing.Size(187, 23);
            this.txtCustomerFullName.TabIndex = 7;
            this.txtCustomerFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "نام و نام خانوادگی مشتری:";
            // 
            // txtCutomerCode
            // 
            this.txtCutomerCode.Location = new System.Drawing.Point(93, 26);
            this.txtCutomerCode.Name = "txtCutomerCode";
            this.txtCutomerCode.ReadOnly = true;
            this.txtCutomerCode.Size = new System.Drawing.Size(100, 23);
            this.txtCutomerCode.TabIndex = 5;
            this.txtCutomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "کد مشتری:";
            // 
            // txtInvoiceDate
            // 
            this.txtInvoiceDate.Location = new System.Drawing.Point(375, 68);
            this.txtInvoiceDate.Name = "txtInvoiceDate";
            this.txtInvoiceDate.ReadOnly = true;
            this.txtInvoiceDate.Size = new System.Drawing.Size(100, 23);
            this.txtInvoiceDate.TabIndex = 3;
            this.txtInvoiceDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "تاریخ:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(375, 26);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(100, 23);
            this.txtInvoiceNo.TabIndex = 1;
            this.txtInvoiceNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "شماره فاکتور:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnInvoiceAddItem
            // 
            this.btnInvoiceAddItem.Location = new System.Drawing.Point(552, 388);
            this.btnInvoiceAddItem.Name = "btnInvoiceAddItem";
            this.btnInvoiceAddItem.Size = new System.Drawing.Size(33, 23);
            this.btnInvoiceAddItem.TabIndex = 2;
            this.btnInvoiceAddItem.Text = "+";
            this.btnInvoiceAddItem.UseVisualStyleBackColor = true;
            this.btnInvoiceAddItem.Click += new System.EventHandler(this.btnInvoiceAddItem_Click);
            // 
            // btnInvoiceEditItem
            // 
            this.btnInvoiceEditItem.Location = new System.Drawing.Point(513, 388);
            this.btnInvoiceEditItem.Name = "btnInvoiceEditItem";
            this.btnInvoiceEditItem.Size = new System.Drawing.Size(33, 23);
            this.btnInvoiceEditItem.TabIndex = 3;
            this.btnInvoiceEditItem.Text = "...";
            this.btnInvoiceEditItem.UseVisualStyleBackColor = true;
            this.btnInvoiceEditItem.Click += new System.EventHandler(this.btnInvoiceEditItem_Click);
            // 
            // btnInvoiceDeleteItem
            // 
            this.btnInvoiceDeleteItem.Location = new System.Drawing.Point(474, 388);
            this.btnInvoiceDeleteItem.Name = "btnInvoiceDeleteItem";
            this.btnInvoiceDeleteItem.Size = new System.Drawing.Size(33, 23);
            this.btnInvoiceDeleteItem.TabIndex = 4;
            this.btnInvoiceDeleteItem.Text = "-";
            this.btnInvoiceDeleteItem.UseVisualStyleBackColor = true;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(12, 388);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 23);
            this.txtTotalPrice.TabIndex = 6;
            this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "جمع کل:";
            // 
            // txtTotalTax
            // 
            this.txtTotalTax.Location = new System.Drawing.Point(180, 388);
            this.txtTotalTax.Name = "txtTotalTax";
            this.txtTotalTax.ReadOnly = true;
            this.txtTotalTax.Size = new System.Drawing.Size(100, 23);
            this.txtTotalTax.TabIndex = 8;
            this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "جمع مالیات بر ارزش افزوده:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 417);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 42);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInvoiceItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 471);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInvoiceDeleteItem);
            this.Controls.Add(this.btnInvoiceEditItem);
            this.Controls.Add(this.btnInvoiceAddItem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInvoiceItemsList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فاکتور";
            this.Load += new System.EventHandler(this.frmInvoiceItemsList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnInvoiceAddItem;
        private System.Windows.Forms.Button btnInvoiceEditItem;
        private System.Windows.Forms.Button btnInvoiceDeleteItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.TextBox txtCustomerFullName;
        public System.Windows.Forms.TextBox txtCutomerCode;
        public System.Windows.Forms.TextBox txtInvoiceDate;
        public System.Windows.Forms.TextBox txtInvoiceNo;
        public System.Windows.Forms.TextBox txtTotalPrice;
        public System.Windows.Forms.TextBox txtTotalTax;
    }
}