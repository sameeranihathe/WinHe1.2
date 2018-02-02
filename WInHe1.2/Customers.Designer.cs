namespace WInHe1._2
{
    partial class Customers
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
            this.dgv_customers = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_customers
            // 
            this.dgv_customers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customers.Location = new System.Drawing.Point(42, 89);
            this.dgv_customers.Name = "dgv_customers";
            this.dgv_customers.RowTemplate.Height = 24;
            this.dgv_customers.Size = new System.Drawing.Size(719, 357);
            this.dgv_customers.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(42, 34);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(421, 27);
            this.txt_search.TabIndex = 1;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(519, 34);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 29);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.Location = new System.Drawing.Point(673, 34);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(88, 29);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(630, 474);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(131, 29);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add Customer";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.button3_Click);
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 528);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_customers);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_customers;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_add;
    }
}