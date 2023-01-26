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


    public partial class FormPetugas : Form
    {
        //Membuat Koneksi
        private string conStr = "Data Source=LAPTOP-95J0PA55; " +
           "Initial Catalog=sewa_kamera1; Integrated Security=True";
        private SqlConnection conn;
        public FormPetugas()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
        }
        private void tampildataadmin()
        {
            conn.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = conn;
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM admin";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(SqlCmd);
            sda.Fill(ds, "admin");
            dgvkamera.DataSource = ds;
            dgvkamera.DataMember = "admin";
            conn.Close();
        }
        private void ClearData()
        {
            txtidpetugas.Clear();
            txtnamapetugas.Clear();
            txtusername.Clear();
            txtpassword.Clear();
        }
        private void FormPetugas_Load(object sender, EventArgs e)
        {
            tampildataadmin();
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
            cmd.CommandText = "INSERT INTO admin(id_petugas, nama_petugas, username, password)" +
                "VALUES ('" + txtidpetugas.Text + "' , '" + txtnamapetugas.Text + "' , '" + txtusername.Text + "' , '" + txtpassword.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Petugas Berhasil DiTambah!");
            tampildataadmin();
            ClearData();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE admin SET " +
                "nama_petugas = '" + txtnamapetugas.Text + "'" + "," + "username = '" + txtusername.Text + "'" + "," + "password = '" + txtpassword.Text + "'"+ 
                "WHERE id_petugas = '" + txtidpetugas.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Petugas Berhasil DiUbah!");
            tampildataadmin();
            ClearData();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM admin " +
                "WHERE id_petugas = '" + txtidpetugas.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Petugas Berhasil DiHapus!");
            tampildataadmin();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
