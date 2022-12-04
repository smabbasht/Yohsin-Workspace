namespace yohsin_workspace
{
    partial class admin_dashboard
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCutomerCare = new System.Windows.Forms.Button();
            this.horizontalDivider = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::yohsin_workspace.Properties.Resources.person_street_bg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(204, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(955, 625);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.btnCutomerCare);
            this.panel1.Controls.Add(this.horizontalDivider);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 633);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCutomerCare
            // 
            this.btnCutomerCare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(82)))), ((int)(((byte)(148)))));
            this.btnCutomerCare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCutomerCare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCutomerCare.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCutomerCare.ForeColor = System.Drawing.Color.White;
            this.btnCutomerCare.Location = new System.Drawing.Point(17, 252);
            this.btnCutomerCare.Margin = new System.Windows.Forms.Padding(4);
            this.btnCutomerCare.Name = "btnCutomerCare";
            this.btnCutomerCare.Size = new System.Drawing.Size(172, 74);
            this.btnCutomerCare.TabIndex = 0;
            this.btnCutomerCare.Text = "Customer Care";
            this.btnCutomerCare.UseVisualStyleBackColor = false;
            this.btnCutomerCare.Click += new System.EventHandler(this.btnCutomerCare_Click);
            // 
            // horizontalDivider
            // 
            this.horizontalDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horizontalDivider.Location = new System.Drawing.Point(61, 213);
            this.horizontalDivider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.horizontalDivider.Name = "horizontalDivider";
            this.horizontalDivider.Size = new System.Drawing.Size(67, 4);
            this.horizontalDivider.TabIndex = 18;
            this.horizontalDivider.Click += new System.EventHandler(this.horizontalDivider_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDashboard.Location = new System.Drawing.Point(27, 167);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(157, 33);
            this.lblDashboard.TabIndex = 5;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::yohsin_workspace.Properties.Resources.yohsin_logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 140);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 615);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "admin_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin\'s Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCutomerCare;
        private System.Windows.Forms.Label horizontalDivider;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}