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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        ProductsModel pm = new ProductsModel();
        ProductsBusinessLogic bl = new ProductsBusinessLogic();


        private void btn_add_Click(object sender, EventArgs e)
        {

            pm.product_name = txt_pName.Text;
            pm.product_description = txt_pDescription.Text;
            pm.purchase_price = Convert.ToDecimal(txt_purchasePrice.Text);
            pm.selling_price = Convert.ToDecimal(txt_sellingPrice.Text);
            pm.quantity = Convert.ToInt16(txt_quantity.Text);

            bl.InsertToBusinessLogic(pm);

            
            Products product = new Products();
            this.Hide();
            product.Show();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantity_Validated(object sender, EventArgs e)
        {
            
        }

       
    }
}
