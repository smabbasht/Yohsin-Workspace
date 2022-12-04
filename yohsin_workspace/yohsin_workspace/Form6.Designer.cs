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
            this.btnSearchExperts = new System.Windows.Forms.Button();
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
            this.pictureBox2.Location = new System.Drawing.Point(153, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(716, 508);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.btnSearchExperts);
            this.panel1.Controls.Add(this.horizontalDivider);
            this.panel1.Controls.Add(this.lblDashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 514);
            this.panel1.TabIndex = 4;
            // 
            // btnSearchExperts
            // 
            this.btnSearchExperts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(82)))), ((int)(((byte)(148)))));
            this.btnSearchExperts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearchExperts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchExperts.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchExperts.ForeColor = System.Drawing.Color.White;
            this.btnSearchExperts.Location = new System.Drawing.Point(13, 205);
            this.btnSearchExperts.Name = "btnSearchExperts";
            this.btnSearchExperts.Size = new System.Drawing.Size(129, 60);
            this.btnSearchExperts.TabIndex = 0;
            this.btnSearchExperts.Text = "Search Experts";
            this.btnSearchExperts.UseVisualStyleBackColor = false;
            // 
            // horizontalDivider
            // 
            this.horizontalDivider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.horizontalDivider.Location = new System.Drawing.Point(46, 173);
            this.horizontalDivider.Name = "horizontalDivider";
            this.horizontalDivider.Size = new System.Drawing.Size(50, 3);
            this.horizontalDivider.TabIndex = 18;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblDashboard.Location = new System.Drawing.Point(20, 136);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(118, 27);
            this.lblDashboard.TabIndex = 5;
            this.lblDashboard.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::yohsin_workspace.Properties.Resources.yohsin_logo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(17, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 114);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // admin_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button btnSearchExperts;
        private System.Windows.Forms.Label horizontalDivider;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}