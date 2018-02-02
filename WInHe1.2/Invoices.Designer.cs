namespace WInHe1._2
{
    partial class Invoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_generatedInvoices = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_invoice = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_AddtoInvoice = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_searchCustomer = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Invoice";
            // 
            // btn_generatedInvoices
            // 
            this.btn_generatedInvoices.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_generatedInvoices.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generatedInvoices.Location = new System.Drawing.Point(617, 18);
            this.btn_generatedInvoices.Name = "btn_generatedInvoices";
            this.btn_generatedInvoices.Size = new System.Drawing.Size(278, 37);
            this.btn_generatedInvoices.TabIndex = 1;
            this.btn_generatedInvoices.Text = "View Generated Invoices";
            this.btn_generatedInvoices.UseVisualStyleBackColor = false;
            this.btn_generatedInvoices.Click += new System.EventHandler(this.btn_generatedInvoices_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_home.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(910, 18);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(103, 37);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_generatedInvoices);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(35, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 71);
            this.panel1.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(35, 101);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(364, 26);
            this.txt_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(444, 99);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 37);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // dgv_products
            // 
            this.dgv_products.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(35, 142);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.Size = new System.Drawing.Size(1040, 157);
            this.dgv_products.TabIndex = 6;
            this.dgv_products.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_products_CellContentClick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(32, 318);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(117, 27);
            this.label.TabIndex = 7;
            this.label.Text = "Product ID:";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productID.Location = new System.Drawing.Point(142, 318);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(66, 27);
            this.lbl_productID.TabIndex = 8;
            this.lbl_productID.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(393, 318);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(66, 27);
            this.lbl_productName.TabIndex = 10;
            this.lbl_productName.Text = "label3";
            this.lbl_productName.Click += new System.EventHandler(this.lbl_productName_Click);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(671, 314);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(92, 27);
            this.lbl_quantity.TabIndex = 12;
            this.lbl_quantity.Text = "Quantity";
            this.lbl_quantity.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(783, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 13;
            // 
            // dgv_invoice
            // 
            this.dgv_invoice.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice.Location = new System.Drawing.Point(36, 359);
            this.dgv_invoice.Name = "dgv_invoice";
            this.dgv_invoice.RowTemplate.Height = 24;
            this.dgv_invoice.Size = new System.Drawing.Size(1039, 169);
            this.dgv_invoice.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(439, 551);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(562, 555);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "Discount";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(653, 550);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(858, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 27);
            this.label6.TabIndex = 20;
            this.label6.Text = "Total Price";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(972, 552);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 19;
            // 
            // btn_AddtoInvoice
            // 
            this.btn_AddtoInvoice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddtoInvoice.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddtoInvoice.Location = new System.Drawing.Point(909, 306);
            this.btn_AddtoInvoice.Name = "btn_AddtoInvoice";
            this.btn_AddtoInvoice.Size = new System.Drawing.Size(162, 39);
            this.btn_AddtoInvoice.TabIndex = 21;
            this.btn_AddtoInvoice.Text = "Add to Invoice";
            this.btn_AddtoInvoice.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 27);
            this.label7.TabIndex = 22;
            this.label7.Text = "Customer:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(133, 610);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 27);
            this.label8.TabIndex = 23;
            this.label8.Text = "label8";
            // 
            // btn_searchCustomer
            // 
            this.btn_searchCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_searchCustomer.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchCustomer.Location = new System.Drawing.Point(375, 604);
            this.btn_searchCustomer.Name = "btn_searchCustomer";
            this.btn_searchCustomer.Size = new System.Drawing.Size(164, 33);
            this.btn_searchCustomer.TabIndex = 24;
            this.btn_searchCustomer.Text = "Search Customer";
            this.btn_searchCustomer.UseVisualStyleBackColor = false;
            // 
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_print.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Location = new System.Drawing.Point(972, 601);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(99, 36);
            this.btn_print.TabIndex = 25;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 659);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_searchCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_AddtoInvoice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgv_invoice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.Load += new System.EventHandler(this.Invoices_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generatedInvoices;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_productID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_invoice;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_AddtoInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_searchCustomer;
        private System.Windows.Forms.Button btn_print;
    }
}