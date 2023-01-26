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
using DevExpress.XtraReports.UI;

namespace AplikasiRentalKamera
{
    public partial class FormPelanggan : Form
    {
        //Membuat Koneksi
        private string conStr = "Data Source=LAPTOP-95J0PA55; " +
           "Initial Catalog=sewa_kamera1; Integrated Security=True";
        private SqlConnection conn;
        public FormPelanggan()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
        }
        private void tampildatapelanggan()
        {
            conn.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = conn;
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM pelanggan";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(SqlCmd);
            sda.Fill(ds, "pelanggan");
            dgvpengembalian.DataSource = ds;
            dgvpengembalian.DataMember = "pelanggan";
            conn.Close();
        }
        private void ClearData()
        {
            txtidpelanggan.Clear();
            txtnamapelanggan.Clear();
            txtnik.Clear();
            txtidpelanggan.Clear();
            txtno.Clear();
            txtalamat.Clear();
        }
        private void FormPelanggan_Load(object sender, EventArgs e)
        {
            tampildatapelanggan();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btntambah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO pelanggan(id_pelanggan, nik, nama_pelanggan, telepon, alamat)" +
                "VALUES ('" + txtidpelanggan.Text + "' , '" + txtnik.Text + "' , '" + txtnamapelanggan.Text + "' , '" + txtno.Text + 
                "' , '" + txtalamat.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Pelanggan Berhasil DiTambahkan!");
            tampildatapelanggan();
            ClearData();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE pelanggan SET " +
                "nama_pelanggan = '" + txtnamapelanggan.Text + "'" + "," + "nik = '"+ txtnik.Text + "'" + "," + "telepon = '" + txtno.Text + "'" + "," + "alamat = '" + txtalamat.Text + "'"+
                "WHERE id_pelanggan = '" + txtidpelanggan.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Pelanggan Berhasil DiUbah!");
            tampildatapelanggan();
            ClearData();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM pelanggan " +
                "WHERE id_pelanggan = '" + txtidpelanggan.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Pelanggan Berhasil DiHapus");
            tampildatapelanggan();
            ClearData();
        }

        private void btn_inputkamera_Click(object sender, EventArgs e)
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
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogout tampil = new FormLogout();
            tampil.Show();
            this.Hide();
        }

        private void btn_inputdatakembalian_Click(object sender, EventArgs e)
        {
            FormPengembalian tampil = new FormPengembalian();
            tampil.Show();
            this.Hide();
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            ReportNota tampil = new ReportNota();
            tampil.ShowPreview();
            this.Hide();
        }
    }
}
