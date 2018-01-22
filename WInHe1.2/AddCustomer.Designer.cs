namespace WInHe1._2
{
    partial class AddCustomer
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
            this.lbl_cusName = new System.Windows.Forms.Label();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_cusEmail = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_cusAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cusContact = new System.Windows.Forms.TextBox();
            this.dtp_cusDob = new System.Windows.Forms.DateTimePicker();
            this.lbl_cusDob = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.Label();
            this.cmb_cusGender = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_cusName
            // 
            this.lbl_cusName.AutoSize = true;
            this.lbl_cusName.Location = new System.Drawing.Point(43, 80);
            this.lbl_cusName.Name = "lbl_cusName";
            this.lbl_cusName.Size = new System.Drawing.Size(45, 17);
            this.lbl_cusName.TabIndex = 3;
            this.lbl_cusName.Text = "Name";
            // 
            // txt_cusName
            // 
            this.txt_cusName.Location = new System.Drawing.Point(165, 75);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(365, 22);
            this.txt_cusName.TabIndex = 2;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(43, 133);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(42, 17);
            this.lbl_email.TabIndex = 5;
            this.lbl_email.Text = "Email";
            // 
            // txt_cusEmail
            // 
            this.txt_cusEmail.Location = new System.Drawing.Point(165, 128);
            this.txt_cusEmail.Name = "txt_cusEmail";
            this.txt_cusEmail.Size = new System.Drawing.Size(365, 22);
            this.txt_cusEmail.TabIndex = 4;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(43, 184);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 17);
            this.lbl_address.TabIndex = 7;
            this.lbl_address.Text = "Address";
            // 
            // txt_cusAddress
            // 
            this.txt_cusAddress.Location = new System.Drawing.Point(165, 179);
            this.txt_cusAddress.Multiline = true;
            this.txt_cusAddress.Name = "txt_cusAddress";
            this.txt_cusAddress.Size = new System.Drawing.Size(365, 74);
            this.txt_cusAddress.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact Number";
            // 
            // txt_cusContact
            // 
            this.txt_cusContact.Location = new System.Drawing.Point(164, 287);
            this.txt_cusContact.Name = "txt_cusContact";
            this.txt_cusContact.Size = new System.Drawing.Size(249, 22);
            this.txt_cusContact.TabIndex = 8;
            // 
            // dtp_cusDob
            // 
            this.dtp_cusDob.Location = new System.Drawing.Point(165, 362);
            this.dtp_cusDob.Name = "dtp_cusDob";
            this.dtp_cusDob.Size = new System.Drawing.Size(200, 22);
            this.dtp_cusDob.TabIndex = 10;
            this.dtp_cusDob.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_cusDob
            // 
            this.lbl_cusDob.AutoSize = true;
            this.lbl_cusDob.Location = new System.Drawing.Point(43, 367);
            this.lbl_cusDob.Name = "lbl_cusDob";
            this.lbl_cusDob.Size = new System.Drawing.Size(87, 17);
            this.lbl_cusDob.TabIndex = 11;
            this.lbl_cusDob.Text = "Date of Birth";
            this.lbl_cusDob.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_gender
            // 
            this.txt_gender.AutoSize = true;
            this.txt_gender.Location = new System.Drawing.Point(54, 423);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(56, 17);
            this.txt_gender.TabIndex = 12;
            this.txt_gender.Text = "Gender";
            // 
            // cmb_cusGender
            // 
            this.cmb_cusGender.FormattingEnabled = true;
            this.cmb_cusGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_cusGender.Location = new System.Drawing.Point(164, 420);
            this.cmb_cusGender.Name = "cmb_cusGender";
            this.cmb_cusGender.Size = new System.Drawing.Size(201, 24);
            this.cmb_cusGender.TabIndex = 13;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(455, 481);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 14;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 534);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_cusGender);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.lbl_cusDob);
            this.Controls.Add(this.dtp_cusDob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cusContact);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_cusAddress);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_cusEmail);
            this.Controls.Add(this.lbl_cusName);
            this.Controls.Add(this.txt_cusName);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cusName;
        private System.Windows.Forms.TextBox txt_cusName;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_cusEmail;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_cusAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_cusContact;
        private System.Windows.Forms.DateTimePicker dtp_cusDob;
        private System.Windows.Forms.Label lbl_cusDob;
        private System.Windows.Forms.Label txt_gender;
        private System.Windows.Forms.ComboBox cmb_cusGender;
        private System.Windows.Forms.Button btn_add;
    }
}