using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCustomerName.Clear();
            txtCustomerEmail.Clear();
            txtCustomerPhoneNumber.Clear();
            txtCustomerCity.Clear();
            txtCompanyZipCode.Clear();
            txtCompanyCityName.Clear();
            txtCompanyAddress.Clear();
               
        }
    }
}
