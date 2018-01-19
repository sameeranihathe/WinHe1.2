namespace WInHe1._2
{
    partial class Form_home
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
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(107, 171);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(75, 36);
            this.btn_product.TabIndex = 0;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(222, 171);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(84, 36);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(341, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Invoices";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 477);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_product);
            this.Name = "Form_home";
            this.Text = "WinHe IT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button button3;
    }
}

