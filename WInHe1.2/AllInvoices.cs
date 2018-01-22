using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WInHe1._2
{
    public partial class AllInvoices : Form
    {
        public AllInvoices()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form_home fm = new Form_home();
            fm.Show();
            this.Hide();
        }

        private void btn_invoice_Click(object sender, EventArgs e)
        {
            Invoices inv =new Invoices();
            inv.Show();
            this.Hide();

        }
    }
}
