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

namespace orderManagement
{
    public partial class CustomerCreate : Form
    {
        public CustomerCreate()
        {
            InitializeComponent();
        }

        private void custCreateCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void custCreateOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
            // Form input checks:
            if (!String.IsNullOrWhiteSpace(newCustIdText.Text) 
                && !string.IsNullOrWhiteSpace(newCustNameText.Text) 
                && !string.IsNullOrWhiteSpace(newCustPhoneText.Text) 
                && !string.IsNullOrWhiteSpace(newCustAddressText.Text))
            {
                // ??? ===
                DataManipulation dm = new DataManipulation("customers.txt");

                if (dm.CustomerFind(int.Parse(newCustIdText.Text)) == null)
                {
                    // Customer DOES NOT exist, so Create new:
                    createCustomer(int.Parse(newCustIdText.Text),
                                    newCustNameText.Text,
                                    int.Parse(newCustPhoneText.Text),
                                    newCustAddressText.Text);

                    MessageBox.Show("New customer created: \n\r    - ID: " + newCustIdText.Text
                     + "\n\r    - Name: " + newCustNameText.Text
                     + "\n\r    - Phone: " + newCustPhoneText.Text
                     + "\n\r    - Address: " + newCustAddressText.Text
                     + "\n\r", "Success!");

                    this.Close();
                }
                else
                    this.custCreateResultLbl.Text = "Customer with ID: " + newCustIdText.Text + " already exists!";   
            }
            else
                this.custCreateResultLbl.Text = "No fields should be blank!";
        }

        private void createCustomer(int id, string name, long phone, string address)
        {
            Customer c = new Customer(id, name, phone, address);

            // NEEDS ERROR CHECKS ???

            //
            DataManipulation dm = new DataManipulation("customers.txt");
            dm.CustomerCreate(c);
        }
    }
}
