namespace WInHe1._2
{
    partial class AddProduct
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
            this.lbl_pName = new System.Windows.Forms.Label();
            this.txt_pName = new System.Windows.Forms.TextBox();
            this.txt_pDescription = new System.Windows.Forms.TextBox();
            this.lbl_pDescription = new System.Windows.Forms.Label();
            this.txt_purchasePrice = new System.Windows.Forms.TextBox();
            this.lbl_purchasePrice = new System.Windows.Forms.Label();
            this.txt_sellingPrice = new System.Windows.Forms.TextBox();
            this.lbl_sellingPrice = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_pName
            // 
            this.lbl_pName.AutoSize = true;
            this.lbl_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pName.Location = new System.Drawing.Point(28, 37);
            this.lbl_pName.Name = "lbl_pName";
            this.lbl_pName.Size = new System.Drawing.Size(116, 20);
            this.lbl_pName.TabIndex = 0;
            this.lbl_pName.Text = "Product Name";
            // 
            // txt_pName
            // 
            this.txt_pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pName.Location = new System.Drawing.Point(181, 30);
            this.txt_pName.Name = "txt_pName";
            this.txt_pName.Size = new System.Drawing.Size(268, 27);
            this.txt_pName.TabIndex = 1;
            // 
            // txt_pDescription
            // 
            this.txt_pDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pDescription.Location = new System.Drawing.Point(181, 89);
            this.txt_pDescription.Multiline = true;
            this.txt_pDescription.Name = "txt_pDescription";
            this.txt_pDescription.Size = new System.Drawing.Size(268, 78);
            this.txt_pDescription.TabIndex = 3;
            // 
            // lbl_pDescription
            // 
            this.lbl_pDescription.AutoSize = true;
            this.lbl_pDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pDescription.Location = new System.Drawing.Point(28, 96);
            this.lbl_pDescription.Name = "lbl_pDescription";
            this.lbl_pDescription.Size = new System.Drawing.Size(95, 20);
            this.lbl_pDescription.TabIndex = 2;
            this.lbl_pDescription.Text = "Description";
            // 
            // txt_purchasePrice
            // 
            this.txt_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_purchasePrice.Location = new System.Drawing.Point(181, 196);
            this.txt_purchasePrice.Name = "txt_purchasePrice";
            this.txt_purchasePrice.Size = new System.Drawing.Size(100, 27);
            this.txt_purchasePrice.TabIndex = 5;
            // 
            // lbl_purchasePrice
            // 
            this.lbl_purchasePrice.AutoSize = true;
            this.lbl_purchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_purchasePrice.Location = new System.Drawing.Point(28, 203);
            this.lbl_purchasePrice.Name = "lbl_purchasePrice";
            this.lbl_purchasePrice.Size = new System.Drawing.Size(124, 20);
            this.lbl_purchasePrice.TabIndex = 4;
            this.lbl_purchasePrice.Text = "Purchase Price";
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sellingPrice.Location = new System.Drawing.Point(181, 262);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(100, 27);
            this.txt_sellingPrice.TabIndex = 7;
            // 
            // lbl_sellingPrice
            // 
            this.lbl_sellingPrice.AutoSize = true;
            this.lbl_sellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sellingPrice.Location = new System.Drawing.Point(28, 269);
            this.lbl_sellingPrice.Name = "lbl_sellingPrice";
            this.lbl_sellingPrice.Size = new System.Drawing.Size(103, 20);
            this.lbl_sellingPrice.TabIndex = 6;
            this.lbl_sellingPrice.Text = "Selling Price";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(181, 327);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 27);
            this.txt_quantity.TabIndex = 9;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.Validated += new System.EventHandler(this.txt_quantity_Validated);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quantity.Location = new System.Drawing.Point(28, 334);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(71, 20);
            this.lbl_quantity.TabIndex = 8;
            this.lbl_quantity.Text = "Quantity";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(402, 434);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 36);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(492, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 513);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.txt_sellingPrice);
            this.Controls.Add(this.lbl_sellingPrice);
            this.Controls.Add(this.txt_purchasePrice);
            this.Controls.Add(this.lbl_purchasePrice);
            this.Controls.Add(this.txt_pDescription);
            this.Controls.Add(this.lbl_pDescription);
            this.Controls.Add(this.txt_pName);
            this.Controls.Add(this.lbl_pName);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pName;
        private System.Windows.Forms.TextBox txt_pName;
        private System.Windows.Forms.TextBox txt_pDescription;
        private System.Windows.Forms.Label lbl_pDescription;
        private System.Windows.Forms.TextBox txt_purchasePrice;
        private System.Windows.Forms.Label lbl_purchasePrice;
        private System.Windows.Forms.TextBox txt_sellingPrice;
        private System.Windows.Forms.Label lbl_sellingPrice;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_back;
    }
}