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
    public partial class Products : Form
    {
        ProductsBusinessLogic pbl = new ProductsBusinessLogic();
        ProductsModel pm = new ProductsModel();
        public Products()
        {
            InitializeComponent();
        }
        //get datDatalogic
        private void SetData()
        {
            List<ProductsModel> relist = pbl.GetProduct();
            dgv_products.DataSource = relist;
        }

        private void Products_Load(object sender, EventArgs e)
        {
            SetData();
            dgv_products.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddProduct addpro = new AddProduct();
            addpro.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

            SelectData();
          
           
        }
        public void SelectData()
        {
            int rowIndex = dgv_products.CurrentCell.RowIndex;

            String old_productId = dgv_products.Rows[rowIndex].Cells["product_Id"].Value.ToString();
            String old_productName = dgv_products.Rows[rowIndex].Cells["product_Name"].Value.ToString();
            String old_productDescription = dgv_products.Rows[rowIndex].Cells["product_description"].Value.ToString();
            String old_purchasePrice = dgv_products.Rows[rowIndex].Cells["purchase_price"].Value.ToString();
            String old_sellingPrice = dgv_products.Rows[rowIndex].Cells["selling_price"].Value.ToString();
            String old_quantity = dgv_products.Rows[rowIndex].Cells["quantity"].Value.ToString();

            pm.product_id = Convert.ToInt32(old_productId);
            pm.product_name = Convert.ToString(old_productName);
            pm.product_description = Convert.ToString(old_productDescription);
            pm.purchase_price = Convert.ToDecimal(old_purchasePrice);
            pm.selling_price = Convert.ToDecimal(old_sellingPrice);
            pm.quantity = Convert.ToInt32(old_quantity);

            EditProduct ep = new EditProduct();
            this.Hide();

            ep.Show();
            ep.Edit(pm);
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgv_products.CurrentCell.RowIndex;
            String productId = dgv_products.Rows[rowIndex].Cells["product_Id"].Value.ToString();
            int pid = Convert.ToInt32(productId);
            pbl.DeleteProduct(pid);

            SetData();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
          //  String search_text = txt_search.Text;

          //  List<ProductsModel> list = this.pbl.SearchProduct(search_text);

          //  dgv_products.DataSource = list;
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Form_home home = new Form_home();
            home.Show();
            this.Hide();
        }
    }
}
