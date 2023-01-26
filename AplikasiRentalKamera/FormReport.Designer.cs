
namespace AplikasiRentalKamera
{
    partial class FormReport
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
            this.btn_inputkamera = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogout.Location = new System.Drawing.Point(159, 15);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(66, 23);
            this.btnlogout.TabIndex = 27;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.Transparent;
            this.btnreport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnreport.Location = new System.Drawing.Point(86, 15);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(67, 23);
            this.btnreport.TabIndex = 26;
            this.btnreport.Text = "REPORT";
            this.btnreport.UseVisualStyleBackColor = false;
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.Transparent;
            this.btnhome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnhome.Location = new System.Drawing.Point(12, 15);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(68, 23);
            this.btnhome.TabIndex = 25;
            this.btnhome.Text = "HOME";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(23, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Report \r\nTransaksi";
            // 
            // btn_inputkamera
            // 
            this.btn_inputkamera.BackColor = System.Drawing.Color.Transparent;
            this.btn_inputkamera.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._3534063;
            this.btn_inputkamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputkamera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_inputkamera.Location = new System.Drawing.Point(13, 48);
            this.btn_inputkamera.Name = "btn_inputkamera";
            this.btn_inputkamera.Size = new System.Drawing.Size(67, 69);
            this.btn_inputkamera.TabIndex = 15;
            this.btn_inputkamera.UseVisualStyleBackColor = false;
            this.btn_inputkamera.Click += new System.EventHandler(this.btn_inputkamera_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(480, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 72);
            this.label6.TabIndex = 29;
            this.label6.Text = "APLIKASI\r\nRENTAL\r\nKAMERA\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources.IMG_3791;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 454);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_inputkamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReport";
            this.Load += new System.EventHandler(this.FormReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inputkamera;
        private System.Windows.Forms.Label label6;
    }
}