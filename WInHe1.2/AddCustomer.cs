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
    public partial class AddCustomer : Form
    {
        CostomerModel cm = new CostomerModel();
        CustomerBusinessLogic cb = new CustomerBusinessLogic();

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cm.cus_name = txt_cusName.Text;
            cm.cus_address = txt_cusAddress.Text;
            cm.cus_contact = Convert.ToInt32(txt_cusContact.Text);
            cm.cus_email = txt_cusEmail.Text;
            cm.cus_gender = cmb_cusGender.Text;
            cm.cus_dob = Convert.ToDateTime(dtp_cusDob.Text);

            cb.InsertToBusinessLogic(cm);

            Customers cc = new Customers();
            cc.Show();
            this.Hide();

        }

        private void cmb_cusGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
