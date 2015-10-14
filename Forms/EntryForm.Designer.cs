namespace orderManagement
{
    partial class EntryForm
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
            this.custCreateBtn = new System.Windows.Forms.Button();
            this.custDeleteBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customerDeleteLabel = new System.Windows.Forms.Label();
            this.customerReadLabel = new System.Windows.Forms.Label();
            this.customerCreateLabel = new System.Windows.Forms.Label();
            this.custFindBtn = new System.Windows.Forms.Button();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.selectedCustOrderGroup = new System.Windows.Forms.GroupBox();
            this.SelectedCustomerOrders = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiteToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.customerListGB = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.selectedCustOrderGroup.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.customerListGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // custCreateBtn
            // 
            this.custCreateBtn.Location = new System.Drawing.Point(140, 29);
            this.custCreateBtn.Name = "custCreateBtn";
            this.custCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.custCreateBtn.TabIndex = 1;
            this.custCreateBtn.Text = "Create";
            this.custCreateBtn.UseVisualStyleBackColor = true;
            this.custCreateBtn.Click += new System.EventHandler(this.custCreateBtn_Click);
            // 
            // custDeleteBtn
            // 
            this.custDeleteBtn.Location = new System.Drawing.Point(140, 106);
            this.custDeleteBtn.Name = "custDeleteBtn";
            this.custDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.custDeleteBtn.TabIndex = 4;
            this.custDeleteBtn.Text = "Delete";
            this.custDeleteBtn.UseVisualStyleBackColor = true;
            this.custDeleteBtn.Click += new System.EventHandler(this.custFormCustDeleteBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerDeleteLabel);
            this.groupBox1.Controls.Add(this.customerReadLabel);
            this.groupBox1.Controls.Add(this.customerCreateLabel);
            this.groupBox1.Controls.Add(this.custCreateBtn);
            this.groupBox1.Controls.Add(this.custDeleteBtn);
            this.groupBox1.Controls.Add(this.custFindBtn);
            this.groupBox1.Location = new System.Drawing.Point(760, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 144);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Operations";
            // 
            // customerDeleteLabel
            // 
            this.customerDeleteLabel.AutoSize = true;
            this.customerDeleteLabel.Location = new System.Drawing.Point(29, 111);
            this.customerDeleteLabel.Name = "customerDeleteLabel";
            this.customerDeleteLabel.Size = new System.Drawing.Size(87, 13);
            this.customerDeleteLabel.TabIndex = 8;
            this.customerDeleteLabel.Text = "Delete customer:";
            // 
            // customerReadLabel
            // 
            this.customerReadLabel.AutoSize = true;
            this.customerReadLabel.Location = new System.Drawing.Point(39, 73);
            this.customerReadLabel.Name = "customerReadLabel";
            this.customerReadLabel.Size = new System.Drawing.Size(77, 13);
            this.customerReadLabel.TabIndex = 6;
            this.customerReadLabel.Text = "Find Customer:";
            // 
            // customerCreateLabel
            // 
            this.customerCreateLabel.AutoSize = true;
            this.customerCreateLabel.Location = new System.Drawing.Point(6, 34);
            this.customerCreateLabel.Name = "customerCreateLabel";
            this.customerCreateLabel.Size = new System.Drawing.Size(110, 13);
            this.customerCreateLabel.TabIndex = 5;
            this.customerCreateLabel.Text = "Create new customer:";
            // 
            // custFindBtn
            // 
            this.custFindBtn.Location = new System.Drawing.Point(140, 68);
            this.custFindBtn.Name = "custFindBtn";
            this.custFindBtn.Size = new System.Drawing.Size(75, 23);
            this.custFindBtn.TabIndex = 2;
            this.custFindBtn.Text = "Search";
            this.custFindBtn.UseVisualStyleBackColor = true;
            this.custFindBtn.Click += new System.EventHandler(this.custFindBtn_Click);
            // 
            // customersGrid
            // 
            this.customersGrid.AllowUserToAddRows = false;
            this.customersGrid.AllowUserToDeleteRows = false;
            this.customersGrid.AllowUserToOrderColumns = true;
            this.customersGrid.AllowUserToResizeRows = false;
            this.customersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Location = new System.Drawing.Point(13, 26);
            this.customersGrid.Margin = new System.Windows.Forms.Padding(10);
            this.customersGrid.MultiSelect = false;
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.ReadOnly = true;
            this.customersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersGrid.Size = new System.Drawing.Size(650, 503);
            this.customersGrid.TabIndex = 6;
            this.customersGrid.Click += new System.EventHandler(this.customersGrid_Click);
            // 
            // selectedCustOrderGroup
            // 
            this.selectedCustOrderGroup.Controls.Add(this.SelectedCustomerOrders);
            this.selectedCustOrderGroup.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectedCustOrderGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedCustOrderGroup.Location = new System.Drawing.Point(715, 533);
            this.selectedCustOrderGroup.Name = "selectedCustOrderGroup";
            this.selectedCustOrderGroup.Size = new System.Drawing.Size(137, 52);
            this.selectedCustOrderGroup.TabIndex = 7;
            this.selectedCustOrderGroup.TabStop = false;
            this.selectedCustOrderGroup.Text = "Show Customer\'s Orders";
            // 
            // SelectedCustomerOrders
            // 
            this.SelectedCustomerOrders.Location = new System.Drawing.Point(15, 23);
            this.SelectedCustomerOrders.Name = "SelectedCustomerOrders";
            this.SelectedCustomerOrders.Size = new System.Drawing.Size(104, 23);
            this.SelectedCustomerOrders.TabIndex = 0;
            this.SelectedCustomerOrders.Text = "Show Orders";
            this.SelectedCustomerOrders.UseVisualStyleBackColor = true;
            this.SelectedCustomerOrders.Click += new System.EventHandler(this.SelectedCustomerOrders_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1012, 24);
            this.mainMenu.TabIndex = 8;
            this.mainMenu.Text = "Menu";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem,
            this.quiteToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // quiteToolStripMenuItem
            // 
            this.quiteToolStripMenuItem.Name = "quiteToolStripMenuItem";
            this.quiteToolStripMenuItem.Size = new System.Drawing.Size(94, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newCustomerToolStripMenuItem.Text = "Create";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Read";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.readToolStripMenuItem,
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem2});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.orderToolStripMenuItem.Text = "Orders";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem.Text = "Read";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem2.Text = "Delete";
            // 
            // customerListGB
            // 
            this.customerListGB.Controls.Add(this.customersGrid);
            this.customerListGB.Location = new System.Drawing.Point(12, 56);
            this.customerListGB.Name = "customerListGB";
            this.customerListGB.Size = new System.Drawing.Size(676, 538);
            this.customerListGB.TabIndex = 9;
            this.customerListGB.TabStop = false;
            this.customerListGB.Text = "Customer List";
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 597);
            this.Controls.Add(this.customerListGB);
            this.Controls.Add(this.selectedCustOrderGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "EntryForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.selectedCustOrderGroup.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.customerListGB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button custCreateBtn;
        private System.Windows.Forms.Button custDeleteBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.GroupBox selectedCustOrderGroup;
        private System.Windows.Forms.Button SelectedCustomerOrders;
        private System.Windows.Forms.Label customerDeleteLabel;
        private System.Windows.Forms.Label customerCreateLabel;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator quiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label customerReadLabel;
        private System.Windows.Forms.Button custFindBtn;
        private System.Windows.Forms.GroupBox customerListGB;
    }
}

