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
using orderManagement.Forms;

namespace orderManagement
{
    public partial class CustomerFind : Form
    {
        public CustomerFind()
        {
            InitializeComponent();
        }

        private void custSearchBtn_Click(object sender, EventArgs e)
        {
            int n;
            
            if (!string.IsNullOrWhiteSpace(this.wantedCustomerTXT.Text) && (int.TryParse(this.wantedCustomerTXT.Text, out n)))
            {
                // call func to return wanted customersobj
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

        private void custFindFormOKbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void custFoundEditBtn_Click(object sender, EventArgs e)
        {
            CustomerEdit ce = new CustomerEdit(int.Parse(this.custSearchIDresult.Text),
                this.custSearchNameResult.Text,
                long.Parse(this.custSearchPhoneResult.Text),
                this.custSearchAddressResult.Text);
            ce.Show();
        }

    }
}
