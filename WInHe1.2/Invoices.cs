﻿using System;
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
    public partial class Invoices : Form
    {
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
    }
}
