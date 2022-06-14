namespace PRN_SE1621_WinFormsApp
{

    partial class FrmAddProduct
    {

        private Label lbProductID;
        private Label lbProductName;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private Label lbUnitPrice;
        private Label lbCreateDate;
        private MaskedTextBox maskedTextBox1;
        private Label lbDesc;
        private TextBox txtDesc;
        private MaskedTextBox mskUnitPrice;
        private Button btnSave;
        private Button btnCancel;
        private Label lbContinue;
        private GroupBox grpContinued;
        private RadioButton raDisContinued;
        private RadioButton raContinued;


        private System.ComponentModel.IContainer components = null;


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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddProduct));
            this.lbProductID = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbCreateDate = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.mskUnitPrice = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbContinue = new System.Windows.Forms.Label();
            this.grpContinued = new System.Windows.Forms.GroupBox();
            this.raDisContinued = new System.Windows.Forms.RadioButton();
            this.raContinued = new System.Windows.Forms.RadioButton();
            this.grpContinued.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(44, 42);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(97, 25);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(44, 89);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(126, 25);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "Product Name";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(227, 39);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(346, 31);
            this.txtProductId.TabIndex = 1;
            
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(230, 86);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(343, 31);
            this.txtProductName.TabIndex = 2;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(44, 140);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(86, 25);
            this.lbUnitPrice.TabIndex = 3;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbCreateDate
            // 
            this.lbCreateDate.AutoSize = true;
            this.lbCreateDate.Location = new System.Drawing.Point(44, 187);
            this.lbCreateDate.Name = "lbCreateDate";
            this.lbCreateDate.Size = new System.Drawing.Size(104, 25);
            this.lbCreateDate.TabIndex = 5;
            this.lbCreateDate.Text = "Create Date";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(233, 184);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(168, 31);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(47, 299);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(102, 25);
            this.lbDesc.TabIndex = 7;
            this.lbDesc.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(233, 299);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(338, 99);
            this.txtDesc.TabIndex = 8;
            // 
            // mskUnitPrice
            // 
            this.mskUnitPrice.Location = new System.Drawing.Point(233, 140);
            this.mskUnitPrice.Mask = "00000,00";
            this.mskUnitPrice.Name = "mskUnitPrice";
            this.mskUnitPrice.Size = new System.Drawing.Size(258, 31);
            this.mskUnitPrice.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbContinue
            // 
            this.lbContinue.AutoSize = true;
            this.lbContinue.Location = new System.Drawing.Point(44, 243);
            this.lbContinue.Name = "lbContinue";
            this.lbContinue.Size = new System.Drawing.Size(94, 25);
            this.lbContinue.TabIndex = 12;
            this.lbContinue.Text = "Continued";
            // 
            // grpContinued
            // 
            this.grpContinued.Controls.Add(this.raDisContinued);
            this.grpContinued.Controls.Add(this.raContinued);
            this.grpContinued.Location = new System.Drawing.Point(235, 221);
            this.grpContinued.Name = "grpContinued";
            this.grpContinued.Size = new System.Drawing.Size(316, 60);
            this.grpContinued.TabIndex = 13;
            this.grpContinued.TabStop = false;
            // 
            // raDisContinued
            // 
            this.raDisContinued.AutoSize = true;
            this.raDisContinued.Location = new System.Drawing.Point(159, 22);
            this.raDisContinued.Name = "raDisContinued";
            this.raDisContinued.Size = new System.Drawing.Size(141, 29);
            this.raDisContinued.TabIndex = 1;
            this.raDisContinued.Text = "Discontinued";
            this.raDisContinued.UseVisualStyleBackColor = true;
            // 
            // raContinued
            // 
            this.raContinued.AutoSize = true;
            this.raContinued.Checked = true;
            this.raContinued.Location = new System.Drawing.Point(19, 22);
            this.raContinued.Name = "raContinued";
            this.raContinued.Size = new System.Drawing.Size(119, 29);
            this.raContinued.TabIndex = 0;
            this.raContinued.TabStop = true;
            this.raContinued.Text = "Continued";
            this.raContinued.UseVisualStyleBackColor = true;
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 531);
            this.Controls.Add(this.grpContinued);
            this.Controls.Add(this.lbContinue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mskUnitPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lbCreateDate);
            this.Controls.Add(this.lbUnitPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbProductName);
            this.Controls.Add(this.lbProductID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ecommerce Product Managements";
            this.grpContinued.ResumeLayout(false);
            this.grpContinued.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
    }
}