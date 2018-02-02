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
    public partial class Invoices : Form
    {
        ProductsBusinessLogic pb = new ProductsBusinessLogic();

        public Invoices()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form_home home = new Form_home();
            home.Show();
            this.Hide();
        }

        private void btn_generatedInvoices_Click(object sender, EventArgs e)
        {
            AllInvoices allInvoices = new AllInvoices();
            allInvoices.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_productName_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Invoices_Load(object sender, EventArgs e)
        {

            setData();
            dgv_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_products.Columns[3].Visible = false;


        }
        private void setData()
        {
            List<ProductsModel> relist = pb.GetProduct();
            dgv_products.DataSource = relist;
            
        }

        private void dgv_products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
