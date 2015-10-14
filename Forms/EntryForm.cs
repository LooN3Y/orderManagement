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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
            
            
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {
            DataManipulation CustomerFileConnection = new DataManipulation("customers.txt");
            //DataManipulation OrdersFileConnection = new DataManipulation("orders.txt");

            customersGrid.DataSource = CustomerFileConnection.CustomersFetch();
        }

        private void custCreateBtn_Click(object sender, EventArgs e)
        {
            CustomerCreate cc = new CustomerCreate();
            cc.Show();
        }

        private void custFindBtn_Click(object sender, EventArgs e)
        {
            CustomerFind cf = new CustomerFind();
            cf.Show();
        }

        // Menu Quit Button
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Button to open Orders form
        private void SelectedCustomerOrders_Click(object sender, EventArgs e)
        {
            OrdersForm ord = new OrdersForm();
            ord.Show();
        }

        private void custFormCustDeleteBtn_Click(object sender, EventArgs e)
        {
            CustomerDelete cd = new CustomerDelete();
            cd.Show();
        }

        private void customersGrid_Click(object sender, EventArgs e)
        {
            this.customersGrid.Update();
            this.customersGrid.Refresh();
        }



    }
}
