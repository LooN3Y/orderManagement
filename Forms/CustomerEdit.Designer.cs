namespace orderManagement.Forms
{
    partial class CustomerEdit
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
            this.custEditOKBtn = new System.Windows.Forms.Button();
            this.custEditCancelBtn = new System.Windows.Forms.Button();
            this.custEditGb = new System.Windows.Forms.GroupBox();
            this.cIdTB = new System.Windows.Forms.TextBox();
            this.cNameTB = new System.Windows.Forms.TextBox();
            this.cPhoneTB = new System.Windows.Forms.TextBox();
            this.cAddressTB = new System.Windows.Forms.TextBox();
            this.custEditIDLbl = new System.Windows.Forms.Label();
            this.custEditNameLbl = new System.Windows.Forms.Label();
            this.custEditPhoneLbl = new System.Windows.Forms.Label();
            this.custEditAddressLbl = new System.Windows.Forms.Label();
            this.custEditGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // custEditOKBtn
            // 
            this.custEditOKBtn.Location = new System.Drawing.Point(12, 231);
            this.custEditOKBtn.Name = "custEditOKBtn";
            this.custEditOKBtn.Size = new System.Drawing.Size(75, 23);
            this.custEditOKBtn.TabIndex = 0;
            this.custEditOKBtn.Text = "OK";
            this.custEditOKBtn.UseVisualStyleBackColor = true;
            this.custEditOKBtn.Click += new System.EventHandler(this.custEditOKBtn_Click);
            // 
            // custEditCancelBtn
            // 
            this.custEditCancelBtn.Location = new System.Drawing.Point(201, 231);
            this.custEditCancelBtn.Name = "custEditCancelBtn";
            this.custEditCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.custEditCancelBtn.TabIndex = 1;
            this.custEditCancelBtn.Text = "Cancel";
            this.custEditCancelBtn.UseVisualStyleBackColor = true;
            this.custEditCancelBtn.Click += new System.EventHandler(this.custEditCancelBtn_Click);
            // 
            // custEditGb
            // 
            this.custEditGb.Controls.Add(this.custEditAddressLbl);
            this.custEditGb.Controls.Add(this.custEditPhoneLbl);
            this.custEditGb.Controls.Add(this.custEditNameLbl);
            this.custEditGb.Controls.Add(this.custEditIDLbl);
            this.custEditGb.Controls.Add(this.cAddressTB);
            this.custEditGb.Controls.Add(this.cPhoneTB);
            this.custEditGb.Controls.Add(this.cNameTB);
            this.custEditGb.Controls.Add(this.cIdTB);
            this.custEditGb.Location = new System.Drawing.Point(12, 12);
            this.custEditGb.Name = "custEditGb";
            this.custEditGb.Size = new System.Drawing.Size(264, 211);
            this.custEditGb.TabIndex = 2;
            this.custEditGb.TabStop = false;
            this.custEditGb.Text = "Customer Details";
            // 
            // cIdTB
            // 
            this.cIdTB.Location = new System.Drawing.Point(81, 33);
            this.cIdTB.Name = "cIdTB";
            this.cIdTB.Size = new System.Drawing.Size(64, 20);
            this.cIdTB.TabIndex = 0;
            // 
            // cNameTB
            // 
            this.cNameTB.Location = new System.Drawing.Point(81, 68);
            this.cNameTB.Name = "cNameTB";
            this.cNameTB.Size = new System.Drawing.Size(149, 20);
            this.cNameTB.TabIndex = 1;
            // 
            // cPhoneTB
            // 
            this.cPhoneTB.Location = new System.Drawing.Point(81, 108);
            this.cPhoneTB.Name = "cPhoneTB";
            this.cPhoneTB.Size = new System.Drawing.Size(100, 20);
            this.cPhoneTB.TabIndex = 2;
            // 
            // cAddressTB
            // 
            this.cAddressTB.Location = new System.Drawing.Point(81, 145);
            this.cAddressTB.Name = "cAddressTB";
            this.cAddressTB.Size = new System.Drawing.Size(165, 20);
            this.cAddressTB.TabIndex = 3;
            // 
            // custEditIDLbl
            // 
            this.custEditIDLbl.AutoSize = true;
            this.custEditIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEditIDLbl.Location = new System.Drawing.Point(51, 36);
            this.custEditIDLbl.Name = "custEditIDLbl";
            this.custEditIDLbl.Size = new System.Drawing.Size(24, 13);
            this.custEditIDLbl.TabIndex = 4;
            this.custEditIDLbl.Text = "ID:";
            // 
            // custEditNameLbl
            // 
            this.custEditNameLbl.AutoSize = true;
            this.custEditNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEditNameLbl.Location = new System.Drawing.Point(32, 71);
            this.custEditNameLbl.Name = "custEditNameLbl";
            this.custEditNameLbl.Size = new System.Drawing.Size(43, 13);
            this.custEditNameLbl.TabIndex = 5;
            this.custEditNameLbl.Text = "Name:";
            // 
            // custEditPhoneLbl
            // 
            this.custEditPhoneLbl.AutoSize = true;
            this.custEditPhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEditPhoneLbl.Location = new System.Drawing.Point(28, 111);
            this.custEditPhoneLbl.Name = "custEditPhoneLbl";
            this.custEditPhoneLbl.Size = new System.Drawing.Size(47, 13);
            this.custEditPhoneLbl.TabIndex = 6;
            this.custEditPhoneLbl.Text = "Phone:";
            // 
            // custEditAddressLbl
            // 
            this.custEditAddressLbl.AutoSize = true;
            this.custEditAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custEditAddressLbl.Location = new System.Drawing.Point(19, 148);
            this.custEditAddressLbl.Name = "custEditAddressLbl";
            this.custEditAddressLbl.Size = new System.Drawing.Size(56, 13);
            this.custEditAddressLbl.TabIndex = 7;
            this.custEditAddressLbl.Text = "Address:";
            // 
            // CustomerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 266);
            this.Controls.Add(this.custEditGb);
            this.Controls.Add(this.custEditCancelBtn);
            this.Controls.Add(this.custEditOKBtn);
            this.Name = "CustomerEdit";
            this.Text = "CustomerEdit";
            this.custEditGb.ResumeLayout(false);
            this.custEditGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button custEditOKBtn;
        private System.Windows.Forms.Button custEditCancelBtn;
        private System.Windows.Forms.GroupBox custEditGb;
        private System.Windows.Forms.Label custEditAddressLbl;
        private System.Windows.Forms.Label custEditPhoneLbl;
        private System.Windows.Forms.Label custEditNameLbl;
        private System.Windows.Forms.Label custEditIDLbl;
        private System.Windows.Forms.TextBox cAddressTB;
        private System.Windows.Forms.TextBox cPhoneTB;
        private System.Windows.Forms.TextBox cNameTB;
        private System.Windows.Forms.TextBox cIdTB;
    }
}