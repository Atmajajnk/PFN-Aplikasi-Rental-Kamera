
namespace AplikasiRentalKamera
{
    partial class FormTransaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidpelanggan = new System.Windows.Forms.TextBox();
            this.txtidsewa = new System.Windows.Forms.TextBox();
            this.txtidkamera = new System.Windows.Forms.TextBox();
            this.btnbatal = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnubah = new System.Windows.Forms.Button();
            this.btntambah = new System.Windows.Forms.Button();
            this.dgvtransaksi = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txttotalbayar = new System.Windows.Forms.TextBox();
            this.txthargasewa = new System.Windows.Forms.TextBox();
            this.txtlamasewa = new System.Windows.Forms.TextBox();
            this.btn_inputdatakembalian = new System.Windows.Forms.Button();
            this.btn_inputdatatransaksi = new System.Windows.Forms.Button();
            this.btn_inputdatapetugas = new System.Windows.Forms.Button();
            this.btn_inputdatapelanggan = new System.Windows.Forms.Button();
            this.btn_inputkamera = new System.Windows.Forms.Button();
            this.dtptanggalsewa = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidstatus = new System.Windows.Forms.ComboBox();
            this.btnhitung = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_logout
            // 
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_logout.Location = new System.Drawing.Point(159, 9);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(66, 23);
            this.btn_logout.TabIndex = 124;
            this.btn_logout.Text = "LOGOUT";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_report
            // 
            this.btn_report.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_report.Location = new System.Drawing.Point(86, 9);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(67, 23);
            this.btn_report.TabIndex = 123;
            this.btn_report.Text = "REPORT";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_home
            // 
            this.btn_home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_home.Location = new System.Drawing.Point(12, 9);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(68, 23);
            this.btn_home.TabIndex = 122;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(11, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 121;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(11, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "ID_Kamera";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(11, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 119;
            this.label8.Text = "ID_Pelanggan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(11, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 118;
            this.label7.Text = "ID Sewa";
            // 
            // txtidpelanggan
            // 
            this.txtidpelanggan.Location = new System.Drawing.Point(105, 39);
            this.txtidpelanggan.Name = "txtidpelanggan";
            this.txtidpelanggan.Size = new System.Drawing.Size(181, 20);
            this.txtidpelanggan.TabIndex = 116;
            // 
            // txtidsewa
            // 
            this.txtidsewa.Location = new System.Drawing.Point(105, 13);
            this.txtidsewa.Name = "txtidsewa";
            this.txtidsewa.Size = new System.Drawing.Size(181, 20);
            this.txtidsewa.TabIndex = 115;
            // 
            // txtidkamera
            // 
            this.txtidkamera.Location = new System.Drawing.Point(105, 65);
            this.txtidkamera.Name = "txtidkamera";
            this.txtidkamera.Size = new System.Drawing.Size(181, 20);
            this.txtidkamera.TabIndex = 114;
            // 
            // btnbatal
            // 
            this.btnbatal.BackColor = System.Drawing.Color.Crimson;
            this.btnbatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbatal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbatal.Location = new System.Drawing.Point(474, 423);
            this.btnbatal.Name = "btnbatal";
            this.btnbatal.Size = new System.Drawing.Size(113, 23);
            this.btnbatal.TabIndex = 113;
            this.btnbatal.Text = "BATAL";
            this.btnbatal.UseVisualStyleBackColor = false;
            this.btnbatal.Click += new System.EventHandler(this.btnbatal_Click);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.Yellow;
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnhapus.Location = new System.Drawing.Point(330, 423);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(111, 23);
            this.btnhapus.TabIndex = 112;
            this.btnhapus.Text = "HAPUS";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnubah
            // 
            this.btnubah.BackColor = System.Drawing.Color.GreenYellow;
            this.btnubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnubah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnubah.Location = new System.Drawing.Point(201, 423);
            this.btnubah.Name = "btnubah";
            this.btnubah.Size = new System.Drawing.Size(98, 23);
            this.btnubah.TabIndex = 111;
            this.btnubah.Text = "UBAH";
            this.btnubah.UseVisualStyleBackColor = false;
            this.btnubah.Click += new System.EventHandler(this.btnubah_Click);
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.Lime;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntambah.Location = new System.Drawing.Point(66, 423);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(95, 23);
            this.btntambah.TabIndex = 110;
            this.btntambah.Text = "TAMBAH";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // dgvtransaksi
            // 
            this.dgvtransaksi.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtransaksi.Location = new System.Drawing.Point(12, 155);
            this.dgvtransaksi.Name = "dgvtransaksi";
            this.dgvtransaksi.Size = new System.Drawing.Size(603, 107);
            this.dgvtransaksi.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(304, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 26);
            this.label5.TabIndex = 106;
            this.label5.Text = "Input Data\r\nPengembalian";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(241, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 105;
            this.label4.Text = "Input Data\r\nTransaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(167, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 103;
            this.label3.Text = "Input Data\r\nPetugas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(94, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 101;
            this.label2.Text = "Input Data\r\nPelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(22, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 26);
            this.label1.TabIndex = 100;
            this.label1.Text = "Input Data\r\nKamera";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(312, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 132;
            this.label11.Text = "Total Bayar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(312, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 131;
            this.label12.Text = "Lama Sewa";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(312, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "Tanggal Sewa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(11, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 129;
            this.label14.Text = "Harga Sewa";
            // 
            // txttotalbayar
            // 
            this.txttotalbayar.Enabled = false;
            this.txttotalbayar.Location = new System.Drawing.Point(406, 109);
            this.txttotalbayar.Name = "txttotalbayar";
            this.txttotalbayar.Size = new System.Drawing.Size(181, 20);
            this.txttotalbayar.TabIndex = 128;
            this.txttotalbayar.Text = "0";
            // 
            // txthargasewa
            // 
            this.txthargasewa.Location = new System.Drawing.Point(105, 116);
            this.txthargasewa.Name = "txthargasewa";
            this.txthargasewa.Size = new System.Drawing.Size(181, 20);
            this.txthargasewa.TabIndex = 126;
            // 
            // txtlamasewa
            // 
            this.txtlamasewa.Location = new System.Drawing.Point(406, 46);
            this.txtlamasewa.Name = "txtlamasewa";
            this.txtlamasewa.Size = new System.Drawing.Size(181, 20);
            this.txtlamasewa.TabIndex = 125;
            // 
            // btn_inputdatakembalian
            // 
            this.btn_inputdatakembalian.BackColor = System.Drawing.Color.Transparent;
            this.btn_inputdatakembalian.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._4154432;
            this.btn_inputdatakembalian.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatakembalian.Location = new System.Drawing.Point(304, 42);
            this.btn_inputdatakembalian.Name = "btn_inputdatakembalian";
            this.btn_inputdatakembalian.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatakembalian.TabIndex = 107;
            this.btn_inputdatakembalian.UseVisualStyleBackColor = false;
            this.btn_inputdatakembalian.Click += new System.EventHandler(this.btn_inputdatakembalian_Click);
            // 
            // btn_inputdatatransaksi
            // 
            this.btn_inputdatatransaksi.BackColor = System.Drawing.Color.Transparent;
            this.btn_inputdatatransaksi.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._3186949;
            this.btn_inputdatatransaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatatransaksi.Location = new System.Drawing.Point(231, 42);
            this.btn_inputdatatransaksi.Name = "btn_inputdatatransaksi";
            this.btn_inputdatatransaksi.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatatransaksi.TabIndex = 104;
            this.btn_inputdatatransaksi.UseVisualStyleBackColor = false;
            this.btn_inputdatatransaksi.Click += new System.EventHandler(this.btn_inputdatatransaksi_Click);
            // 
            // btn_inputdatapetugas
            // 
            this.btn_inputdatapetugas.BackColor = System.Drawing.Color.Transparent;
            this.btn_inputdatapetugas.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._8861688;
            this.btn_inputdatapetugas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatapetugas.Location = new System.Drawing.Point(158, 42);
            this.btn_inputdatapetugas.Name = "btn_inputdatapetugas";
            this.btn_inputdatapetugas.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatapetugas.TabIndex = 102;
            this.btn_inputdatapetugas.UseVisualStyleBackColor = false;
            this.btn_inputdatapetugas.Click += new System.EventHandler(this.btn_inputdatapetugas_Click);
            // 
            // btn_inputdatapelanggan
            // 
            this.btn_inputdatapelanggan.BackColor = System.Drawing.Color.Transparent;
            this.btn_inputdatapelanggan.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._5323563;
            this.btn_inputdatapelanggan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputdatapelanggan.Location = new System.Drawing.Point(85, 42);
            this.btn_inputdatapelanggan.Name = "btn_inputdatapelanggan";
            this.btn_inputdatapelanggan.Size = new System.Drawing.Size(67, 69);
            this.btn_inputdatapelanggan.TabIndex = 99;
            this.btn_inputdatapelanggan.UseVisualStyleBackColor = false;
            this.btn_inputdatapelanggan.Click += new System.EventHandler(this.btn_inputdatapelanggan_Click);
            // 
            // btn_inputkamera
            // 
            this.btn_inputkamera.BackColor = System.Drawing.Color.Transparent;
            this.btn_inputkamera.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources._1042390;
            this.btn_inputkamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inputkamera.Location = new System.Drawing.Point(12, 42);
            this.btn_inputkamera.Name = "btn_inputkamera";
            this.btn_inputkamera.Size = new System.Drawing.Size(67, 69);
            this.btn_inputkamera.TabIndex = 98;
            this.btn_inputkamera.UseVisualStyleBackColor = false;
            this.btn_inputkamera.Click += new System.EventHandler(this.btn_inputkamera_Click);
            // 
            // dtptanggalsewa
            // 
            this.dtptanggalsewa.Location = new System.Drawing.Point(406, 20);
            this.dtptanggalsewa.Name = "dtptanggalsewa";
            this.dtptanggalsewa.Size = new System.Drawing.Size(183, 20);
            this.dtptanggalsewa.TabIndex = 184;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidstatus);
            this.groupBox1.Controls.Add(this.btnhitung);
            this.groupBox1.Controls.Add(this.txtidpelanggan);
            this.groupBox1.Controls.Add(this.dtptanggalsewa);
            this.groupBox1.Controls.Add(this.txtidkamera);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtidsewa);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttotalbayar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txthargasewa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtlamasewa);
            this.groupBox1.Location = new System.Drawing.Point(12, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 149);
            this.groupBox1.TabIndex = 185;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TRANSAKSI";
            // 
            // txtidstatus
            // 
            this.txtidstatus.FormattingEnabled = true;
            this.txtidstatus.Items.AddRange(new object[] {
            "Hilang",
            "Lengkap",
            "Rusak"});
            this.txtidstatus.Location = new System.Drawing.Point(105, 89);
            this.txtidstatus.Name = "txtidstatus";
            this.txtidstatus.Size = new System.Drawing.Size(181, 21);
            this.txtidstatus.TabIndex = 188;
            // 
            // btnhitung
            // 
            this.btnhitung.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnhitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhitung.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnhitung.Location = new System.Drawing.Point(348, 80);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(117, 23);
            this.btnhitung.TabIndex = 187;
            this.btnhitung.Text = "HITUNG";
            this.btnhitung.UseVisualStyleBackColor = false;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(481, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 72);
            this.label6.TabIndex = 186;
            this.label6.Text = "APLIKASI\r\nRENTAL\r\nKAMERA\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AplikasiRentalKamera.Properties.Resources.IMG_3791;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btnbatal);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnubah);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.dgvtransaksi);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormTransaksi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTransaksi";
            this.Load += new System.EventHandler(this.FormTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtransaksi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidpelanggan;
        private System.Windows.Forms.TextBox txtidsewa;
        private System.Windows.Forms.TextBox txtidkamera;
        private System.Windows.Forms.Button btnbatal;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnubah;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.DataGridView dgvtransaksi;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotalbayar;
        private System.Windows.Forms.TextBox txthargasewa;
        private System.Windows.Forms.TextBox txtlamasewa;
        private System.Windows.Forms.DateTimePicker dtptanggalsewa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.ComboBox txtidstatus;
    }
}