
namespace AplikasiRentalKamera
{
    partial class FormPelanggan
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
            this.components = new System.ComponentModel.Container();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtnik = new System.Windows.Forms.TextBox();
            this.txtidpelanggan = new System.Windows.Forms.TextBox();
            this.txtnamapelanggan = new System.Windows.Forms.TextBox();
            this.btnbatal = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.dgvpengembalian = new System.Windows.Forms.DataGridView();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.btn_inputdatakembalian = new System.Windows.Forms.Button();
            this.btn_inputdatatransaksi = new System.Windows.Forms.Button();
            this.btn_inputdatapetugas = new System.Windows.Forms.Button();
            this.btn_inputdatapelanggan = new System.Windows.Forms.Button();
            this.btn_inputkamera = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btncetak = new System.Windows.Forms.Button();
            this.xpServerCollectionSource1 = new DevExpress.Xpo.XPServerCollectionSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpengembalian)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(35, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "Telepon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(35, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Nama Pelanggan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(35, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "NIK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(35, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "ID Pelanggan";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(129, 91);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(181, 20);
            this.txtno.TabIndex = 64;
            // 
            // txtnik
            // 
            this.txtnik.Location = new System.Drawing.Point(129, 39);
            this.txtnik.Name = "txtnik";
            this.txtnik.Size = new System.Drawing.Size(181, 20);
            this.txtnik.TabIndex = 63;
            // 
            // txtidpelanggan
            // 
            this.txtidpelanggan.Location = new System.Drawing.Point(129, 13);
            this.txtidpelanggan.Name = "txtidpelanggan";
            this.txtidpelanggan.Size = new System.Drawing.Size(181, 20);
            this.txtidpelanggan.TabIndex = 62;
            // 
            // txtnamapelanggan
            // 
            this.txtnamapelanggan.Location = new System.Drawing.Point(129, 65);
            this.txtnamapelanggan.Name = "txtnamapelanggan";
            this.txtnamapelanggan.Size = new System.Drawing.Size(181, 20);
            this.txtnamapelanggan.TabIndex = 61;
            // 
            // btnbatal
            // 
            this.btnbatal.BackColor = System.Drawing.Color.Crimson;
            this.btnbatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatal.Location = new System.Drawing.Point(499, 302);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(90, 23);
            this.btnbatal.TabIndex = 60;
            this.btnbatal.Text = "BATAL";
            this.btnbatal.UseVisualStyleBackColor = false;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Yellow;
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.Location = new System.Drawing.Point(359, 299);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(102, 23);
            this.btnhapus.TabIndex = 59;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.GreenYellow;
            this.btnubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubah.Location = new System.Drawing.Point(192, 299);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(92, 23);
            this.btnubah.TabIndex = 58;
            this.btnubah.Text = "UBAH";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.Lime;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.Location = new System.Drawing.Point(44, 299);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(95, 23);
            this.btntambah.TabIndex = 57;
            this.btntambah.Text = "TAMBAH";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // dgvpengembalian
            // 
            this.dgvpengembalian.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvpengembalian.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvpengembalian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpengembalian.Location = new System.Drawing.Point(22, 331);
            this.dgvpengembalian.Name = "dgvpengembalian";
            this.dgvpengembalian.Size = new System.Drawing.Size(593, 107);
            this.dgvpengembalian.TabIndex = 55;
            // 
            // btn_logout
            // 
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_logout.Location = new System.Drawing.Point(158, 10);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(66, 23);
            this.btn_logout.TabIndex = 54;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_report
            // 
            this.btn_report.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_report.Location = new System.Drawing.Point(85, 10);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(67, 23);
            this.btn_report.TabIndex = 53;
            this.btn_report.Text = "REPORT";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_home
            // 
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_home.Location = new System.Drawing.Point(11, 10);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(68, 23);
            this.btn_home.TabIndex = 52;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(304, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 50;
            this.label5.Text = "Input Data\r\nPengembalian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(241, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 49;
            this.label4.Text = "Input Data\r\nTransaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(167, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Input Data\r\nPetugas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(94, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 45;
            this.label2.Text = "Input Data\r\nPelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "Input Data\r\nKamera";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(35, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "Alamat";
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(129, 117);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(181, 20);
            this.txtalamat.TabIndex = 69;
            // 
            // btn_inputdatakembalian
            // 
            this.btn_inputdatakembalian.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_inputdatakembalian.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._4154432;
            this.btn_inputdatakembalian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatakembalian.Location = new System.Drawing.Point(304, 39);
            this.btn_inputdatakembalian.Name = "btn_inputdatakembalian";
            this.btn_inputdatakembalian.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatakembalian.TabIndex = 51;
            this.btn_inputdatakembalian.UseVisualStyleBackColor = false;
            this.btn_inputdatakembalian.Click += new System.EventHandler(this.btn_inputdatakembalian_Click);
            // 
            // btn_inputdatatransaksi
            // 
            this.btn_inputdatatransaksi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_inputdatatransaksi.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._3186949;
            this.btn_inputdatatransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatatransaksi.Location = new System.Drawing.Point(231, 39);
            this.btn_inputdatatransaksi.Name = "btn_inputdatatransaksi";
            this.btn_inputdatatransaksi.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatatransaksi.TabIndex = 48;
            this.btn_inputdatatransaksi.UseVisualStyleBackColor = false;
            this.btn_inputdatatransaksi.Click += new System.EventHandler(this.btn_inputdatatransaksi_Click);
            // 
            // btn_inputdatapetugas
            // 
            this.btn_inputdatapetugas.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_inputdatapetugas.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._8861688;
            this.btn_inputdatapetugas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatapetugas.Location = new System.Drawing.Point(158, 39);
            this.btn_inputdatapetugas.Name = "btn_inputdatapetugas";
            this.btn_inputdatapetugas.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatapetugas.TabIndex = 46;
            this.btn_inputdatapetugas.UseVisualStyleBackColor = false;
            this.btn_inputdatapetugas.Click += new System.EventHandler(this.btn_inputdatapetugas_Click);
            // 
            // btn_inputdatapelanggan
            // 
            this.btn_inputdatapelanggan.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._5323563;
            this.btn_inputdatapelanggan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatapelanggan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_inputdatapelanggan.Location = new System.Drawing.Point(85, 39);
            this.btn_inputdatapelanggan.Name = "btn_inputdatapelanggan";
            this.btn_inputdatapelanggan.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatapelanggan.TabIndex = 43;
            this.btn_inputdatapelanggan.UseVisualStyleBackColor = true;
            this.btn_inputdatapelanggan.Click += new System.EventHandler(this.btn_inputdatapelanggan_Click);
            // 
            // btn_inputkamera
            // 
            this.btn_inputkamera.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_inputkamera.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._1042390;
            this.btn_inputkamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputkamera.Location = new System.Drawing.Point(12, 39);
            this.btn_inputkamera.Name = "btn_inputkamera";
            this.btn_inputkamera.Size = new System.Drawing.Size(67, 69);
            this.btn_inputkamera.TabIndex = 42;
            this.btn_inputkamera.UseVisualStyleBackColor = false;
            this.btn_inputkamera.Click += new System.EventHandler(this.btn_inputkamera_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtnamapelanggan);
            this.groupBox1.Controls.Add(this.txtalamat);
            this.groupBox1.Controls.Add(this.txtidpelanggan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtnik);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(97, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 144);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PELANGGAN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(495, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 72);
            this.label6.TabIndex = 72;
            this.label6.Text = "APLIKASI\r\nRENTAL\r\nKAMERA\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncetak
            // 
            this.btncetak.BackColor = System.Drawing.Color.Turquoise;
            this.btncetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncetak.Location = new System.Drawing.Point(514, 196);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(75, 54);
            this.btncetak.TabIndex = 73;
            this.btncetak.Text = "CETAK";
            this.btncetak.UseVisualStyleBackColor = false;
            this.btncetak.Click += new System.EventHandler(this.btncetak_Click);
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources.IMG_3791;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.btncetak);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dgvpengembalian);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_inputdatakembalian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_inputdatatransaksi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_inputdatapetugas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_inputdatapelanggan);
            this.Controls.Add(this.btn_inputkamera);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormPelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPelanggan";
            this.Load += new System.EventHandler(this.FormPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpengembalian)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpServerCollectionSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtnik;
        private System.Windows.Forms.TextBox txtidpelanggan;
        private System.Windows.Forms.TextBox txtnamapelanggan;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.DataGridView dgvpengembalian;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_inputdatakembalian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_inputdatatransaksi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_inputdatapetugas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inputdatapelanggan;
        private System.Windows.Forms.Button btn_inputkamera;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btncetak;
        private DevExpress.Xpo.XPServerCollectionSource xpServerCollectionSource1;
    }
}