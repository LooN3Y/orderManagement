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
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            DataManipulation DataBase = new DataManipulation("orders.txt");

            ordersGrid.DataSource = DataBase.OrdersFetch();
        }

    }
}
