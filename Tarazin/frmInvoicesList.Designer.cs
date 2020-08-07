namespace Tarazin
{
    partial class frmInvoicesList
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLast100Invoices = new System.Windows.Forms.Button();
            this.btnNewInvoice = new System.Windows.Forms.Button();
            this.btnShowEditInvoiceInfo = new System.Windows.Forms.Button();
            this.btnShowEditInvoiceItems = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbFDate = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtFDate1 = new System.Windows.Forms.TextBox();
            this.txtFDate2 = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber1 = new System.Windows.Forms.TextBox();
            this.txtInvoiceNumber2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(751, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(190, 48);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnLast100Invoices
            // 
            this.btnLast100Invoices.Location = new System.Drawing.Point(751, 66);
            this.btnLast100Invoices.Name = "btnLast100Invoices";
            this.btnLast100Invoices.Size = new System.Drawing.Size(190, 48);
            this.btnLast100Invoices.TabIndex = 1;
            this.btnLast100Invoices.Text = "100 فاکتور آخر";
            this.btnLast100Invoices.UseVisualStyleBackColor = true;
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Location = new System.Drawing.Point(751, 120);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(190, 48);
            this.btnNewInvoice.TabIndex = 2;
            this.btnNewInvoice.Text = "ایجاد فاکتور جدید";
            this.btnNewInvoice.UseVisualStyleBackColor = true;
            // 
            // btnShowEditInvoiceInfo
            // 
            this.btnShowEditInvoiceInfo.Location = new System.Drawing.Point(751, 174);
            this.btnShowEditInvoiceInfo.Name = "btnShowEditInvoiceInfo";
            this.btnShowEditInvoiceInfo.Size = new System.Drawing.Size(190, 48);
            this.btnShowEditInvoiceInfo.TabIndex = 3;
            this.btnShowEditInvoiceInfo.Text = "نمایش / ویرایش اطلاعات فاکتور";
            this.btnShowEditInvoiceInfo.UseVisualStyleBackColor = true;
            // 
            // btnShowEditInvoiceItems
            // 
            this.btnShowEditInvoiceItems.Location = new System.Drawing.Point(751, 228);
            this.btnShowEditInvoiceItems.Name = "btnShowEditInvoiceItems";
            this.btnShowEditInvoiceItems.Size = new System.Drawing.Size(190, 48);
            this.btnShowEditInvoiceItems.TabIndex = 4;
            this.btnShowEditInvoiceItems.Text = "نمایش / ویرایش اقلام فاکتور";
            this.btnShowEditInvoiceItems.UseVisualStyleBackColor = true;
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.Location = new System.Drawing.Point(751, 282);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(190, 48);
            this.btnDeleteInvoice.TabIndex = 5;
            this.btnDeleteInvoice.Text = "حذف فاکتور";
            this.btnDeleteInvoice.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(751, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 48);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(733, 444);
            this.dataGridView1.TabIndex = 7;
            // 
            // rbFDate
            // 
            this.rbFDate.AutoSize = true;
            this.rbFDate.Location = new System.Drawing.Point(681, 26);
            this.rbFDate.Name = "rbFDate";
            this.rbFDate.Size = new System.Drawing.Size(64, 20);
            this.rbFDate.TabIndex = 8;
            this.rbFDate.TabStop = true;
            this.rbFDate.Text = "از تاریخ";
            this.rbFDate.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(268, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(109, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "از شماره فاکتور";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtFDate1
            // 
            this.txtFDate1.Location = new System.Drawing.Point(576, 25);
            this.txtFDate1.Name = "txtFDate1";
            this.txtFDate1.Size = new System.Drawing.Size(100, 23);
            this.txtFDate1.TabIndex = 10;
            // 
            // txtFDate2
            // 
            this.txtFDate2.Location = new System.Drawing.Point(436, 25);
            this.txtFDate2.Name = "txtFDate2";
            this.txtFDate2.Size = new System.Drawing.Size(100, 23);
            this.txtFDate2.TabIndex = 11;
            // 
            // txtInvoiceNumber1
            // 
            this.txtInvoiceNumber1.Location = new System.Drawing.Point(156, 26);
            this.txtInvoiceNumber1.Name = "txtInvoiceNumber1";
            this.txtInvoiceNumber1.Size = new System.Drawing.Size(100, 23);
            this.txtInvoiceNumber1.TabIndex = 12;
            // 
            // txtInvoiceNumber2
            // 
            this.txtInvoiceNumber2.Location = new System.Drawing.Point(16, 25);
            this.txtInvoiceNumber2.Name = "txtInvoiceNumber2";
            this.txtInvoiceNumber2.Size = new System.Drawing.Size(100, 23);
            this.txtInvoiceNumber2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "الی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "الی";
            // 
            // frmInvoicesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 522);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInvoiceNumber2);
            this.Controls.Add(this.txtInvoiceNumber1);
            this.Controls.Add(this.txtFDate2);
            this.Controls.Add(this.txtFDate1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbFDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.btnShowEditInvoiceItems);
            this.Controls.Add(this.btnShowEditInvoiceInfo);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.btnLast100Invoices);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmInvoicesList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست فاکتورها";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLast100Invoices;
        private System.Windows.Forms.Button btnNewInvoice;
        private System.Windows.Forms.Button btnShowEditInvoiceInfo;
        private System.Windows.Forms.Button btnShowEditInvoiceItems;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbFDate;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtFDate1;
        private System.Windows.Forms.TextBox txtFDate2;
        private System.Windows.Forms.TextBox txtInvoiceNumber1;
        private System.Windows.Forms.TextBox txtInvoiceNumber2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}