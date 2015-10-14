using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using orderManagement.Classes;


namespace orderManagement.Forms
{
    public partial class CustomerDelete : Form
    {
        public CustomerDelete()
        {
            InitializeComponent();
        }

        private void custDelFormOKbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void custSearchBtn_Click(object sender, EventArgs e)
        {
            // Cust search by ID code HERE
            int n;

            // ID input check
            if (!String.IsNullOrWhiteSpace(this.wantedCustomerTXT.Text) && (int.TryParse(this.wantedCustomerTXT.Text, out n)))
            {
                DataManipulation dm = new DataManipulation("customers.txt");
                Customer cust = dm.CustomerFind(int.Parse(this.wantedCustomerTXT.Text));

                if (cust != null)
                {
                    this.custSearchResultLBL.Text = "Customer found!";
                    this.customerSearchResult.Enabled = true;
                    this.custSearchIDresult.Text = cust.ID.ToString();
                    this.custSearchNameResult.Text = cust.Name;
                    this.custSearchPhoneResult.Text = cust.Phone.ToString();
                    this.custSearchAddressResult.Text = cust.Address;
                }
                else
                {
                    this.customerSearchResult.Enabled = false;
                    this.custSearchResultLBL.Text = "There is no customer with ID: " + this.wantedCustomerTXT.Text + ".";
                }
            }
            else
            {
                this.custSearchResultLBL.ForeColor = System.Drawing.Color.Red;
                this.custSearchResultLBL.Text = "Enter a valid ID!";
            }
        }

        private void custFoundDelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?",
                            "Attention!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes )
            {
                // CDeletion Confirmed. Call Delete func here!!!!! ====================
                DataManipulation dm = new DataManipulation("customers.txt");

                if (dm.CustomerDelete(int.Parse(this.custSearchIDresult.Text)))
                    MessageBox.Show("Deletion OK!");
                else
                    MessageBox.Show("No deletion!");
            }
            else
                this.Close();
            
        }
    }
}
