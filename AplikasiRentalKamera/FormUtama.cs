using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplikasiRentalKamera
{
    public partial class FormUtama : Form
    {
        //Membuat Koneksi
        private string conStr = "Data Source=LAPTOP-95J0PA55; " +
           "Initial Catalog=sewa_kamera1; Integrated Security=True";
        private SqlConnection conn;
        public FormUtama()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
        }

        private void btn_inputkamera_Click(object sender, EventArgs e)
        {
            FormKamera tampil = new FormKamera();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogout tampil = new FormLogout();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormUtama tampil = new FormUtama();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            FormReport tampil = new FormReport();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_inputkamera_Click_1(object sender, EventArgs e)
        {
            FormKamera tampil = new FormKamera();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_inputdatapelanggan_Click(object sender, EventArgs e)
        {
            FormPelanggan tampil = new FormPelanggan();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_inputdatapetugas_Click(object sender, EventArgs e)
        {
            FormPetugas tampil = new FormPetugas();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_inputdatatransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi tampil = new FormTransaksi();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void btn_inputdatakembalian_Click(object sender, EventArgs e)
        {
            FormPengembalian tampil = new FormPengembalian();
            tampil.Show();
            this.Hide();
            conn.Close();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
