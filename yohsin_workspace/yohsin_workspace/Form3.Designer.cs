namespace yohsin_workspace
{
    partial class registration_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration_screen));
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.horizontalDivider = new System.Windows.Forms.Label();
            this.lblRegistrationTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboxAccountType = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblPersonalDetails = new System.Windows.Forms.Label();
            this.lblAccountDetails = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAccountIBAN = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountType
            // 
            this.lblAccountType.BackColor = System.Drawing.Color.Wheat;
            this.lblAccountType.Location = new System.Drawing.Point(48, 510);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(107, 22);
            this.lblAccountType.TabIndex = 19;
            this.lblAccountType.Text = "Account Type:";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Wheat;
            this.lblEmail.Location = new System.Drawing.Point(48, 434);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(107, 22);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            this.lblEmail.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // horizontalDivider
            // 
            this.horizontalDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.horizontalDivider.Location = new System.Drawing.Point(132, 322);
            this.horizontalDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horizontalDivider.Name = "horizontalDivider";
            this.horizontalDivider.Size = new System.Drawing.Size(107, 4);
            this.horizontalDivider.TabIndex = 17;
            // 
            // lblRegistrationTitle
            // 
            this.lblRegistrationTitle.BackColor = System.Drawing.Color.Wheat;
            this.lblRegistrationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrationTitle.Location = new System.Drawing.Point(92, 263);
            this.lblRegistrationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrationTitle.Name = "lblRegistrationTitle";
            this.lblRegistrationTitle.Size = new System.Drawing.Size(187, 34);
            this.lblRegistrationTitle.TabIndex = 16;
            this.lblRegistrationTitle.Text = "Registration";
            this.lblRegistrationTitle.Click += new System.EventHandler(this.lblRegistrationTitle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(85, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 203);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cboxAccountType
            // 
            this.cboxAccountType.FormattingEnabled = true;
            this.cboxAccountType.Location = new System.Drawing.Point(164, 506);
            this.cboxAccountType.Margin = new System.Windows.Forms.Padding(4);
            this.cboxAccountType.Name = "cboxAccountType";
            this.cboxAccountType.Size = new System.Drawing.Size(172, 24);
            this.cboxAccountType.TabIndex = 14;
            this.cboxAccountType.SelectedIndexChanged += new System.EventHandler(this.cboxAccountType_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 432);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(172, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 394);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 12;
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Wheat;
            this.lblFullName.Location = new System.Drawing.Point(48, 395);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(107, 22);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPersonalDetails
            // 
            this.lblPersonalDetails.BackColor = System.Drawing.Color.Wheat;
            this.lblPersonalDetails.Location = new System.Drawing.Point(128, 351);
            this.lblPersonalDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalDetails.Name = "lblPersonalDetails";
            this.lblPersonalDetails.Size = new System.Drawing.Size(117, 23);
            this.lblPersonalDetails.TabIndex = 20;
            this.lblPersonalDetails.Text = "Personal Details:";
            this.lblPersonalDetails.Click += new System.EventHandler(this.lblPersonalDetails_Click);
            // 
            // lblAccountDetails
            // 
            this.lblAccountDetails.BackColor = System.Drawing.Color.Wheat;
            this.lblAccountDetails.Location = new System.Drawing.Point(128, 559);
            this.lblAccountDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountDetails.Name = "lblAccountDetails";
            this.lblAccountDetails.Size = new System.Drawing.Size(117, 23);
            this.lblAccountDetails.TabIndex = 21;
            this.lblAccountDetails.Text = "Account Details:";
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Wheat;
            this.lblPassword.Location = new System.Drawing.Point(48, 473);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 22);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(164, 469);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(172, 22);
            this.textBox3.TabIndex = 23;
            // 
            // lblAccountIBAN
            // 
            this.lblAccountIBAN.BackColor = System.Drawing.Color.Wheat;
            this.lblAccountIBAN.Location = new System.Drawing.Point(49, 633);
            this.lblAccountIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountIBAN.Name = "lblAccountIBAN";
            this.lblAccountIBAN.Size = new System.Drawing.Size(107, 22);
            this.lblAccountIBAN.TabIndex = 24;
            this.lblAccountIBAN.Text = "Account IBAN";
            // 
            // lblBankName
            // 
            this.lblBankName.BackColor = System.Drawing.Color.Wheat;
            this.lblBankName.Location = new System.Drawing.Point(48, 599);
            this.lblBankName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(107, 22);
            this.lblBankName.TabIndex = 25;
            this.lblBankName.Text = "Bank Name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(164, 632);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(172, 22);
            this.textBox4.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 597);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 22);
            this.textBox5.TabIndex = 27;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Wheat;
            this.btnSubmit.Location = new System.Drawing.Point(132, 665);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 28;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // registration_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yohsin_workspace.Properties.Resources.startup_bg_greenery;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1117, 715);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblBankName);
            this.Controls.Add(this.lblAccountIBAN);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccountDetails);
            this.Controls.Add(this.lblPersonalDetails);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.horizontalDivider);
            this.Controls.Add(this.lblRegistrationTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxAccountType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFullName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "registration_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Screen";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label horizontalDivider;
        private System.Windows.Forms.Label lblRegistrationTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboxAccountType;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPersonalDetails;
        private System.Windows.Forms.Label lblAccountDetails;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAccountIBAN;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnSubmit;
    }
}