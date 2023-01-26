
namespace AplikasiRentalKamera
{
    partial class FormLogout
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogout.Location = new System.Drawing.Point(159, 12);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(66, 23);
            this.btnlogout.TabIndex = 27;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnreport
            // 
            this.btnreport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnreport.Location = new System.Drawing.Point(86, 12);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(67, 23);
            this.btnreport.TabIndex = 26;
            this.btnreport.Text = "REPORT";
            this.btnreport.UseVisualStyleBackColor = true;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnhome
            // 
            this.btnhome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnhome.Location = new System.Drawing.Point(12, 12);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(68, 23);
            this.btnhome.TabIndex = 25;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(529, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Keluar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AplikasiRentalKamera.Properties.Resources.cameraaaa;
            this.pictureBox1.Location = new System.Drawing.Point(162, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.Transparent;
            this.btn_keluar.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._1828490;
            this.btn_keluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_keluar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_keluar.Location = new System.Drawing.Point(517, 125);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(67, 69);
            this.btn_keluar.TabIndex = 15;
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(155, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "APLIKASI RENTAL KAMERA\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources.IMG_3791;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(627, 453);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_keluar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormLogout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogout";
            this.Load += new System.EventHandler(this.FormLogout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}