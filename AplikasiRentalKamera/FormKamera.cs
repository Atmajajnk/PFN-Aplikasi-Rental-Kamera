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
    public partial class FormKamera : Form
    {
        //Membuat Koneksi
        private string conStr = "Data Source=LAPTOP-95J0PA55; " +
           "Initial Catalog=sewa_kamera1; Integrated Security=True";
        private SqlConnection conn;
        public FormKamera()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
        }
        private void tampildatakamera()
        {
            conn.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = conn;
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM kamera";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(SqlCmd);
            sda.Fill(ds, "kamera");
            dgvkamera.DataSource = ds;
            dgvkamera.DataMember = "kamera";
            conn.Close();
        }
        private void FormKamera_Load(object sender, EventArgs e)
        {
            tampildatakamera();
        }

        private void btntambah_Click(object sender, EventArgs e)    
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO kamera(id_kamera, nama_kamera, harga_sewa, stok)"+
                "VALUES ('" + txtidcamera.Text + "' , '" + txtnamacamera.Text + "' , '" + txthargasewa.Text
                + "','" + txtstock.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kamera Berhasil DiTambahkan!");
            tampildatakamera();
            ClearData();
        }
         private void ClearData()
        {
            txtidcamera.Clear();
            txtnamacamera.Clear();
            txthargasewa.Clear();
            txtstock.Clear();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE kamera SET " +
                "nama_kamera = '" + txtnamacamera.Text + "'" + "," +"harga_sewa = '" + txthargasewa.Text + "'" + "," + "stok = '" + txtstock.Text + "'"+
                "WHERE id_kamera = '" + txtidcamera.Text +"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kamera Berhasil Diubah!");
            tampildatakamera();
            ClearData();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM kamera " +
                "WHERE id_kamera = '" + txtidcamera.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kamera Berhasil DiHapus!");
            tampildatakamera();
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
            conn.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            FormLogout tampil = new FormLogout();
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
    }
}
