using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BusinessLogic;

namespace WInHe1._2
{
    public partial class Customers : Form
    {
        CustomerBusinessLogic cb = new CustomerBusinessLogic();
        public Customers()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form_home home = new Form_home();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.Show();
            this.Hide();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            SetData();
            dgv_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void SetData()
        {
            List<CostomerModel> relist = cb.getCustomer();
            dgv_customers.DataSource = relist;
        }
    }
}
