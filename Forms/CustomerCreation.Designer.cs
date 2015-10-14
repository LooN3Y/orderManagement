namespace orderManagement
{
    partial class CustomerCreate
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
            this.newCustomerName = new System.Windows.Forms.Label();
            this.newCustNameText = new System.Windows.Forms.TextBox();
            this.newCustomerID = new System.Windows.Forms.Label();
            this.newCustIdText = new System.Windows.Forms.TextBox();
            this.newCustomerPhone = new System.Windows.Forms.Label();
            this.newCustPhoneText = new System.Windows.Forms.TextBox();
            this.newCustomerAddress = new System.Windows.Forms.Label();
            this.newCustAddressText = new System.Windows.Forms.TextBox();
            this.custCreateOK = new System.Windows.Forms.Button();
            this.custCreateCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.custCreateResultLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newCustomerName
            // 
            this.newCustomerName.AutoSize = true;
            this.newCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerName.Location = new System.Drawing.Point(23, 69);
            this.newCustomerName.Name = "newCustomerName";
            this.newCustomerName.Size = new System.Drawing.Size(43, 13);
            this.newCustomerName.TabIndex = 0;
            this.newCustomerName.Text = "Name:";
            // 
            // newCustNameText
            // 
            this.newCustNameText.Location = new System.Drawing.Point(72, 66);
            this.newCustNameText.Name = "newCustNameText";
            this.newCustNameText.Size = new System.Drawing.Size(158, 20);
            this.newCustNameText.TabIndex = 1;
            // 
            // newCustomerID
            // 
            this.newCustomerID.AutoSize = true;
            this.newCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerID.Location = new System.Drawing.Point(42, 33);
            this.newCustomerID.Name = "newCustomerID";
            this.newCustomerID.Size = new System.Drawing.Size(24, 13);
            this.newCustomerID.TabIndex = 2;
            this.newCustomerID.Text = "ID:";
            // 
            // newCustIdText
            // 
            this.newCustIdText.Location = new System.Drawing.Point(72, 30);
            this.newCustIdText.Name = "newCustIdText";
            this.newCustIdText.Size = new System.Drawing.Size(48, 20);
            this.newCustIdText.TabIndex = 3;
            // 
            // newCustomerPhone
            // 
            this.newCustomerPhone.AutoSize = true;
            this.newCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerPhone.Location = new System.Drawing.Point(19, 106);
            this.newCustomerPhone.Name = "newCustomerPhone";
            this.newCustomerPhone.Size = new System.Drawing.Size(47, 13);
            this.newCustomerPhone.TabIndex = 4;
            this.newCustomerPhone.Text = "Phone:";
            // 
            // newCustPhoneText
            // 
            this.newCustPhoneText.Location = new System.Drawing.Point(72, 103);
            this.newCustPhoneText.Name = "newCustPhoneText";
            this.newCustPhoneText.Size = new System.Drawing.Size(100, 20);
            this.newCustPhoneText.TabIndex = 5;
            // 
            // newCustomerAddress
            // 
            this.newCustomerAddress.AutoSize = true;
            this.newCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCustomerAddress.Location = new System.Drawing.Point(10, 144);
            this.newCustomerAddress.Name = "newCustomerAddress";
            this.newCustomerAddress.Size = new System.Drawing.Size(56, 13);
            this.newCustomerAddress.TabIndex = 6;
            this.newCustomerAddress.Text = "Address:";
            // 
            // newCustAddressText
            // 
            this.newCustAddressText.Location = new System.Drawing.Point(72, 141);
            this.newCustAddressText.Name = "newCustAddressText";
            this.newCustAddressText.Size = new System.Drawing.Size(183, 20);
            this.newCustAddressText.TabIndex = 7;
            // 
            // custCreateOK
            // 
            this.custCreateOK.Location = new System.Drawing.Point(101, 231);
            this.custCreateOK.Name = "custCreateOK";
            this.custCreateOK.Size = new System.Drawing.Size(75, 23);
            this.custCreateOK.TabIndex = 8;
            this.custCreateOK.Text = "OK";
            this.custCreateOK.UseVisualStyleBackColor = true;
            this.custCreateOK.Click += new System.EventHandler(this.custCreateOK_Click);
            // 
            // custCreateCancel
            // 
            this.custCreateCancel.Location = new System.Drawing.Point(193, 231);
            this.custCreateCancel.Name = "custCreateCancel";
            this.custCreateCancel.Size = new System.Drawing.Size(75, 23);
            this.custCreateCancel.TabIndex = 9;
            this.custCreateCancel.Text = "Cancel";
            this.custCreateCancel.UseVisualStyleBackColor = true;
            this.custCreateCancel.Click += new System.EventHandler(this.custCreateCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.newCustomerID);
            this.groupBox1.Controls.Add(this.newCustomerName);
            this.groupBox1.Controls.Add(this.newCustomerPhone);
            this.groupBox1.Controls.Add(this.newCustomerAddress);
            this.groupBox1.Controls.Add(this.newCustAddressText);
            this.groupBox1.Controls.Add(this.newCustPhoneText);
            this.groupBox1.Controls.Add(this.newCustIdText);
            this.groupBox1.Controls.Add(this.newCustNameText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 177);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New customer details:";
            // 
            // custCreateResultLbl
            // 
            this.custCreateResultLbl.AutoSize = true;
            this.custCreateResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCreateResultLbl.ForeColor = System.Drawing.Color.Red;
            this.custCreateResultLbl.Location = new System.Drawing.Point(22, 192);
            this.custCreateResultLbl.Name = "custCreateResultLbl";
            this.custCreateResultLbl.Size = new System.Drawing.Size(0, 15);
            this.custCreateResultLbl.TabIndex = 11;
            this.custCreateResultLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CustomerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 270);
            this.Controls.Add(this.custCreateResultLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.custCreateCancel);
            this.Controls.Add(this.custCreateOK);
            this.Name = "CustomerCreate";
            this.Text = "Create new customer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCustomerName;
        private System.Windows.Forms.TextBox newCustNameText;
        private System.Windows.Forms.Label newCustomerID;
        private System.Windows.Forms.TextBox newCustIdText;
        private System.Windows.Forms.Label newCustomerPhone;
        private System.Windows.Forms.TextBox newCustPhoneText;
        private System.Windows.Forms.Label newCustomerAddress;
        private System.Windows.Forms.TextBox newCustAddressText;
        private System.Windows.Forms.Button custCreateOK;
        private System.Windows.Forms.Button custCreateCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label custCreateResultLbl;
    }
}