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
    public partial class Form_home : Form
    {
        public Form_home()
        {
            InitializeComponent();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            Products pr = new Products();
            pr.Show();
            this.Hide();
        }

        private void btn_customers_Click(object sender, EventArgs e)
        {
            Customers cs = new Customers();
            cs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Invoices iv = new Invoices();
            iv.Show();
            this.Hide();
        }
    }
}
