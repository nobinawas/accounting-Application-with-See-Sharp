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
    public partial class Bill_Payment : Form
    {
        public Bill_Payment()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOrderID.Clear();
            txtCompanyName.Clear();
            txtCashPayment.Clear();
        }
    }
}
