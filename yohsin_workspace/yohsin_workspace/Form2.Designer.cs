namespace yohsin_workspace
{
    partial class login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_screen));
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboxAccountType = new System.Windows.Forms.ComboBox();
            this.lblLoginScreenTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.Wheat;
            this.lblUsername.Location = new System.Drawing.Point(97, 313);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(80, 18);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 362);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 3;
            // 
            // cboxAccountType
            // 
            this.cboxAccountType.FormattingEnabled = true;
            this.cboxAccountType.Location = new System.Drawing.Point(184, 411);
            this.cboxAccountType.Name = "cboxAccountType";
            this.cboxAccountType.Size = new System.Drawing.Size(130, 21);
            this.cboxAccountType.TabIndex = 5;
            // 
            // lblLoginScreenTitle
            // 
            this.lblLoginScreenTitle.BackColor = System.Drawing.Color.Wheat;
            this.lblLoginScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginScreenTitle.Location = new System.Drawing.Point(120, 229);
            this.lblLoginScreenTitle.Name = "lblLoginScreenTitle";
            this.lblLoginScreenTitle.Size = new System.Drawing.Size(155, 28);
            this.lblLoginScreenTitle.TabIndex = 7;
            this.lblLoginScreenTitle.Text = "Login Screen";
            this.lblLoginScreenTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 166);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(160, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 3);
            this.label1.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.Color.Wheat;
            this.lblPassword.Location = new System.Drawing.Point(97, 365);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 18);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // lblAccountType
            // 
            this.lblAccountType.BackColor = System.Drawing.Color.Wheat;
            this.lblAccountType.Location = new System.Drawing.Point(97, 414);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(80, 18);
            this.lblAccountType.TabIndex = 10;
            this.lblAccountType.Text = "Account Type:";
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yohsin_workspace.Properties.Resources.startup_bg_greenery;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(777, 518);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginScreenTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboxAccountType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblUsername);
            this.MaximizeBox = false;
            this.Name = "login_screen";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.login_screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboxAccountType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLoginScreenTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccountType;
    }
}