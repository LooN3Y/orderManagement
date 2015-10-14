namespace orderManagement
{
    partial class CustomerFind
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
            this.custSearchLbl = new System.Windows.Forms.Label();
            this.wantedCustomerTXT = new System.Windows.Forms.TextBox();
            this.custSearchBtn = new System.Windows.Forms.Button();
            this.custFoundEditBtn = new System.Windows.Forms.Button();
            this.customerSearchResult = new System.Windows.Forms.GroupBox();
            this.custSearchAddressResult = new System.Windows.Forms.Label();
            this.custSearchPhoneResult = new System.Windows.Forms.Label();
            this.custSearchNameResult = new System.Windows.Forms.Label();
            this.custSearchIDresult = new System.Windows.Forms.Label();
            this.AddressLBL = new System.Windows.Forms.Label();
            this.PhoneLBL = new System.Windows.Forms.Label();
            this.NameLBL = new System.Windows.Forms.Label();
            this.IdLBL = new System.Windows.Forms.Label();
            this.custFindFormOKbtn = new System.Windows.Forms.Button();
            this.custSearchResultLBL = new System.Windows.Forms.Label();
            this.custSearchPnl = new System.Windows.Forms.Panel();
            this.customerSearchResult.SuspendLayout();
            this.custSearchPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // custSearchLbl
            // 
            this.custSearchLbl.AutoSize = true;
            this.custSearchLbl.Location = new System.Drawing.Point(14, 17);
            this.custSearchLbl.Name = "custSearchLbl";
            this.custSearchLbl.Size = new System.Drawing.Size(104, 13);
            this.custSearchLbl.TabIndex = 0;
            this.custSearchLbl.Text = "Enter a customer ID:";
            // 
            // wantedCustomerTXT
            // 
            this.wantedCustomerTXT.Location = new System.Drawing.Point(124, 14);
            this.wantedCustomerTXT.Name = "wantedCustomerTXT";
            this.wantedCustomerTXT.Size = new System.Drawing.Size(59, 20);
            this.wantedCustomerTXT.TabIndex = 1;
            // 
            // custSearchBtn
            // 
            this.custSearchBtn.Location = new System.Drawing.Point(124, 52);
            this.custSearchBtn.Name = "custSearchBtn";
            this.custSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.custSearchBtn.TabIndex = 2;
            this.custSearchBtn.Text = "Search";
            this.custSearchBtn.UseVisualStyleBackColor = true;
            this.custSearchBtn.Click += new System.EventHandler(this.custSearchBtn_Click);
            // 
            // custFoundEditBtn
            // 
            this.custFoundEditBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.custFoundEditBtn.Location = new System.Drawing.Point(180, 162);
            this.custFoundEditBtn.Name = "custFoundEditBtn";
            this.custFoundEditBtn.Size = new System.Drawing.Size(75, 23);
            this.custFoundEditBtn.TabIndex = 5;
            this.custFoundEditBtn.Text = "Edit";
            this.custFoundEditBtn.UseVisualStyleBackColor = true;
            this.custFoundEditBtn.Click += new System.EventHandler(this.custFoundEditBtn_Click);
            // 
            // customerSearchResult
            // 
            this.customerSearchResult.Controls.Add(this.custSearchAddressResult);
            this.customerSearchResult.Controls.Add(this.custSearchPhoneResult);
            this.customerSearchResult.Controls.Add(this.custFoundEditBtn);
            this.customerSearchResult.Controls.Add(this.custSearchNameResult);
            this.customerSearchResult.Controls.Add(this.custSearchIDresult);
            this.customerSearchResult.Controls.Add(this.AddressLBL);
            this.customerSearchResult.Controls.Add(this.PhoneLBL);
            this.customerSearchResult.Controls.Add(this.NameLBL);
            this.customerSearchResult.Controls.Add(this.IdLBL);
            this.customerSearchResult.Enabled = false;
            this.customerSearchResult.Location = new System.Drawing.Point(12, 134);
            this.customerSearchResult.Name = "customerSearchResult";
            this.customerSearchResult.Size = new System.Drawing.Size(264, 191);
            this.customerSearchResult.TabIndex = 6;
            this.customerSearchResult.TabStop = false;
            this.customerSearchResult.Text = "Result";
            // 
            // custSearchAddressResult
            // 
            this.custSearchAddressResult.AutoSize = true;
            this.custSearchAddressResult.Location = new System.Drawing.Point(91, 127);
            this.custSearchAddressResult.Name = "custSearchAddressResult";
            this.custSearchAddressResult.Size = new System.Drawing.Size(16, 13);
            this.custSearchAddressResult.TabIndex = 7;
            this.custSearchAddressResult.Text = "...";
            // 
            // custSearchPhoneResult
            // 
            this.custSearchPhoneResult.AutoSize = true;
            this.custSearchPhoneResult.Location = new System.Drawing.Point(88, 97);
            this.custSearchPhoneResult.Name = "custSearchPhoneResult";
            this.custSearchPhoneResult.Size = new System.Drawing.Size(16, 13);
            this.custSearchPhoneResult.TabIndex = 6;
            this.custSearchPhoneResult.Text = "...";
            // 
            // custSearchNameResult
            // 
            this.custSearchNameResult.AutoSize = true;
            this.custSearchNameResult.Location = new System.Drawing.Point(88, 67);
            this.custSearchNameResult.Name = "custSearchNameResult";
            this.custSearchNameResult.Size = new System.Drawing.Size(16, 13);
            this.custSearchNameResult.TabIndex = 5;
            this.custSearchNameResult.Text = "...";
            // 
            // custSearchIDresult
            // 
            this.custSearchIDresult.AutoSize = true;
            this.custSearchIDresult.Location = new System.Drawing.Point(88, 39);
            this.custSearchIDresult.Name = "custSearchIDresult";
            this.custSearchIDresult.Size = new System.Drawing.Size(16, 13);
            this.custSearchIDresult.TabIndex = 4;
            this.custSearchIDresult.Text = "...";
            // 
            // AddressLBL
            // 
            this.AddressLBL.AutoSize = true;
            this.AddressLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLBL.Location = new System.Drawing.Point(24, 128);
            this.AddressLBL.Name = "AddressLBL";
            this.AddressLBL.Size = new System.Drawing.Size(56, 13);
            this.AddressLBL.TabIndex = 3;
            this.AddressLBL.Text = "Address:";
            // 
            // PhoneLBL
            // 
            this.PhoneLBL.AutoSize = true;
            this.PhoneLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLBL.Location = new System.Drawing.Point(31, 98);
            this.PhoneLBL.Name = "PhoneLBL";
            this.PhoneLBL.Size = new System.Drawing.Size(47, 13);
            this.PhoneLBL.TabIndex = 2;
            this.PhoneLBL.Text = "Phone:";
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.Location = new System.Drawing.Point(34, 67);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(43, 13);
            this.NameLBL.TabIndex = 1;
            this.NameLBL.Text = "Name:";
            // 
            // IdLBL
            // 
            this.IdLBL.AutoSize = true;
            this.IdLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLBL.Location = new System.Drawing.Point(53, 39);
            this.IdLBL.Name = "IdLBL";
            this.IdLBL.Size = new System.Drawing.Size(24, 13);
            this.IdLBL.TabIndex = 0;
            this.IdLBL.Text = "ID:";
            // 
            // custFindFormOKbtn
            // 
            this.custFindFormOKbtn.Location = new System.Drawing.Point(195, 331);
            this.custFindFormOKbtn.Name = "custFindFormOKbtn";
            this.custFindFormOKbtn.Size = new System.Drawing.Size(81, 23);
            this.custFindFormOKbtn.TabIndex = 7;
            this.custFindFormOKbtn.Text = "OK";
            this.custFindFormOKbtn.UseVisualStyleBackColor = true;
            this.custFindFormOKbtn.Click += new System.EventHandler(this.custFindFormOKbtn_Click);
            // 
            // custSearchResultLBL
            // 
            this.custSearchResultLBL.AutoSize = true;
            this.custSearchResultLBL.Location = new System.Drawing.Point(89, 118);
            this.custSearchResultLBL.Name = "custSearchResultLBL";
            this.custSearchResultLBL.Size = new System.Drawing.Size(0, 13);
            this.custSearchResultLBL.TabIndex = 8;
            // 
            // custSearchPnl
            // 
            this.custSearchPnl.Controls.Add(this.custSearchLbl);
            this.custSearchPnl.Controls.Add(this.wantedCustomerTXT);
            this.custSearchPnl.Controls.Add(this.custSearchBtn);
            this.custSearchPnl.Location = new System.Drawing.Point(39, 12);
            this.custSearchPnl.Name = "custSearchPnl";
            this.custSearchPnl.Size = new System.Drawing.Size(216, 92);
            this.custSearchPnl.TabIndex = 9;
            // 
            // CustomerFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 366);
            this.Controls.Add(this.custSearchPnl);
            this.Controls.Add(this.custSearchResultLBL);
            this.Controls.Add(this.custFindFormOKbtn);
            this.Controls.Add(this.customerSearchResult);
            this.Name = "CustomerFind";
            this.Text = "CustomerFind";
            this.customerSearchResult.ResumeLayout(false);
            this.customerSearchResult.PerformLayout();
            this.custSearchPnl.ResumeLayout(false);
            this.custSearchPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label custSearchLbl;
        private System.Windows.Forms.TextBox wantedCustomerTXT;
        private System.Windows.Forms.Button custSearchBtn;
        private System.Windows.Forms.Button custFoundEditBtn;
        private System.Windows.Forms.GroupBox customerSearchResult;
        private System.Windows.Forms.Label custSearchAddressResult;
        private System.Windows.Forms.Label custSearchPhoneResult;
        private System.Windows.Forms.Label custSearchNameResult;
        private System.Windows.Forms.Label custSearchIDresult;
        private System.Windows.Forms.Label AddressLBL;
        private System.Windows.Forms.Label PhoneLBL;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label IdLBL;
        private System.Windows.Forms.Button custFindFormOKbtn;
        private System.Windows.Forms.Label custSearchResultLBL;
        private System.Windows.Forms.Panel custSearchPnl;
    }
}