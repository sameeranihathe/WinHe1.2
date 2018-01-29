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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_product
            // 
            this.btn_product.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_product.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.Location = new System.Drawing.Point(74, 282);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(115, 36);
            this.btn_product.TabIndex = 0;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = false;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_customers.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.Location = new System.Drawing.Point(208, 282);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(116, 36);
            this.btn_customers.TabIndex = 1;
            this.btn_customers.Text = "Customers";
            this.btn_customers.UseVisualStyleBackColor = false;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(340, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Invoices";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "WinHe IT Technologies";
            // 
            // Form_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_product);
            this.Name = "Form_home";
            this.Text = "WinHe IT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

