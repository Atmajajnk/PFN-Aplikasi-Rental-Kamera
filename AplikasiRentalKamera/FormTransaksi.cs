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
    public partial class FormTransaksi : Form
    {
        //Membuat Koneksi
        private string conStr = "Data Source=LAPTOP-95J0PA55; " +
           "Initial Catalog=sewa_kamera1; Integrated Security=True";
        private SqlConnection conn;
        public FormTransaksi()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
        }
        private void tampildatatransaksi()
        {
            conn.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = conn;
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM transaksi";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(SqlCmd);
            sda.Fill(ds, "transaksi");
            dgvtransaksi.DataSource = ds;
            dgvtransaksi.DataMember = "transaksi";
            conn.Close();
        }
        private void ClearData()
        {
            txtidsewa.Clear();
            txtidpelanggan.Clear();
            txtidkamera.Clear();
            
            txthargasewa.Clear();
            txtlamasewa.Clear();
            txttotalbayar.Clear();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            tampildatatransaksi();

        }
        
        private void btntambah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO transaksi(id_sewa, id_pelanggan, id_kamera, status, harga_sewa, tanggal_sewa, lama_sewa, total_bayar)" +
                 "VALUES ('" + txtidsewa.Text + "' , '" + txtidpelanggan.Text + "' , '" + txtidkamera.Text + "' , '" + txtidstatus.Text + "' , '" + txthargasewa.Text + "' , '" + dtptanggalsewa.Value.ToString("dd-MM-yyyy") + "' , '" + txtlamasewa.Text + "' , '" + txttotalbayar.Text +"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            tampildatatransaksi();
            MessageBox.Show("Transaksi Telah DiTambah!");
            ClearData();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM transaksi " +
                "WHERE id_sewa = '" + txtidsewa.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Transaksi Berhasil DiHapus!");
            tampildatatransaksi();
            ClearData();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE transaksi SET " +
                "id_pelanggan = '" + txtidpelanggan.Text + "'" +
                "WHERE id_sewa = '" + txtidsewa.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Transaksi Berhasil DiUbah!");
            tampildatatransaksi();
            ClearData();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            FormUtama tampil = new FormUtama();
            tampil.Show();
            this.Hide();
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

        private void btn_inputkamera_Click(object sender, EventArgs e)
        {
            FormKamera tampil = new FormKamera();
            tampil.Show();
            this.Hide();
        }

        private void btn_inputdatapelanggan_Click(object sender, EventArgs e)
        {
            FormPelanggan tampil = new FormPelanggan();
            tampil.Show();
            this.Hide();
        }

        private void btn_inputdatapetugas_Click(object sender, EventArgs e)
        {
            FormPetugas tampil = new FormPetugas();
            tampil.Show();
            this.Hide();
        }

        private void btn_inputdatatransaksi_Click(object sender, EventArgs e)
        {
            FormTransaksi tampil = new FormTransaksi();
            tampil.Show();
            this.Hide();
        }

        private void btn_inputdatakembalian_Click(object sender, EventArgs e)
        {
            FormPengembalian tampil = new FormPengembalian();
            tampil.Show();
            this.Hide();
        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            if (txthargasewa.Text == "" || txtlamasewa.Text == " ")
            {
                txthargasewa.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txthargasewa.Text);
                int b = Convert.ToInt32(txtlamasewa.Text);
                int total = 0;
                total = a * b;

                txttotalbayar.Text = Convert.ToString(total);
            }
        }
    }
}
