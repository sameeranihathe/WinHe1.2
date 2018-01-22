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
            // Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 572);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_generatedInvoices);
            this.Controls.Add(this.label1);
            this.Name = "Invoices";
            this.Text = "Invoices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generatedInvoices;
        private System.Windows.Forms.Button btn_home;
    }
}