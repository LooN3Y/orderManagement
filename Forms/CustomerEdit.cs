using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderManagement.Forms
{
    public partial class CustomerEdit : Form
    {
        public CustomerEdit()
        {
            InitializeComponent();
        }
        public CustomerEdit(int id, string name, long phone, string address) : this()
        {
            this.cIdTB.Text = id.ToString();
            this.cNameTB.Text = name;
            this.cPhoneTB.Text = phone.ToString();
            this.cAddressTB.Text = address;
        }

        private void custEditCancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void custEditOKBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            MessageBox.Show("This will update the info of the selected customer!\n\r Are you sure you want to do this??",
                                "Attention!!",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            // Call customer edit func ===================================================

            this.Close();
        }
    }
}
