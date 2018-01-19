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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

       

        public void Edit(ProductsModel pm)
        {
            txt_productId.Text = pm.product_id.ToString();
            txt_pName.Text = pm.product_name;
            txt_pDescription.Text = pm.product_description;
            txt_purchasePrice.Text = Convert.ToString(pm.purchase_price);
            txt_sellingPrice.Text = Convert.ToString(pm.selling_price);
            txt_quantity.Text = Convert.ToString(pm.quantity);
        }

        private void EditProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ProductsModel pm = new ProductsModel();

            pm.product_id = Convert.ToInt32(txt_productId.Text);
            pm.product_name = txt_pName.Text;
            pm.product_description = txt_pDescription.Text;
            pm.purchase_price = Convert.ToInt32(txt_purchasePrice.Text);
            pm.selling_price = Convert.ToInt32(txt_sellingPrice.Text);

            ProductsBusinessLogic pbl = new ProductsBusinessLogic();
            pbl.EditBusinessLogic(pm);

            Products p = new Products();
            p.Show();
            this.Hide();
        }
    }
}
