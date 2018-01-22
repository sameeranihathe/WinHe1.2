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
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_invoice = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate Invoice";
            // 
            // btn_generatedInvoices
            // 
            this.btn_generatedInvoices.Location = new System.Drawing.Point(783, 30);
            this.btn_generatedInvoices.Name = "btn_generatedInvoices";
            this.btn_generatedInvoices.Size = new System.Drawing.Size(179, 30);
            this.btn_generatedInvoices.TabIndex = 1;
            this.btn_generatedInvoices.Text = "View Generated Invoices";
            this.btn_generatedInvoices.UseVisualStyleBackColor = true;
            this.btn_generatedInvoices.Click += new System.EventHandler(this.btn_generatedInvoices_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(1000, 34);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 71);
            this.panel1.TabIndex = 3;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(35, 101);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(364, 22);
            this.txt_search.TabIndex = 4;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(444, 99);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // dgv_products
            // 
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(35, 142);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.RowTemplate.Height = 24;
            this.dgv_products.Size = new System.Drawing.Size(1040, 157);
            this.dgv_products.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(32, 318);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 20);
            this.label.TabIndex = 7;
            this.label.Text = "Product ID:";
            this.label.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productID.Location = new System.Drawing.Point(142, 318);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(53, 20);
            this.lbl_productID.TabIndex = 8;
            this.lbl_productID.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(393, 318);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(53, 20);
            this.lbl_productName.TabIndex = 10;
            this.lbl_productName.Text = "label3";
            this.lbl_productName.Click += new System.EventHandler(this.lbl_productName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(848, 325);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(71, 20);
            this.lbl_quantity.TabIndex = 12;
            this.lbl_quantity.Text = "Quantity";
            this.lbl_quantity.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(975, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 13;
            // 
            // dgv_invoice
            // 
            this.dgv_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_invoice.Location = new System.Drawing.Point(36, 359);
            this.dgv_invoice.Name = "dgv_invoice";
            this.dgv_invoice.RowTemplate.Height = 24;
            this.dgv_invoice.Size = new System.Drawing.Size(1039, 150);
            this.dgv_invoice.TabIndex = 14;
            // 
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 609);
            this.Controls.Add(this.dgv_invoice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dgv_products);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_generatedInvoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Invoices";
            this.Text = "Invoices";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_invoice;
    }
}