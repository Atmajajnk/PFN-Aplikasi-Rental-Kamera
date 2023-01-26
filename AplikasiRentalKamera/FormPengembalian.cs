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
    public partial class FormPengembalian : Form
    {
        //Membuat Koneksi
        private string conStr = "Data Source=LAPTOP-95J0PA55; " +
           "Initial Catalog=sewa_kamera1; Integrated Security=True";
        private SqlConnection conn;
        public FormPengembalian()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
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

        private void FormPengembalian_Load(object sender, EventArgs e)
        {
            tampildatapengembalian();
            
        }
        private void tampildatapengembalian()
        {
            conn.Open();
            SqlCommand SqlCmd = new SqlCommand();
            SqlCmd.Connection = conn;
            SqlCmd.CommandType = CommandType.Text;
            SqlCmd.CommandText = "SELECT * FROM pengembalian";
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter(SqlCmd);
            sda.Fill(ds, "pengembalian");
            dgvpengembalian.DataSource = ds;
            dgvpengembalian.DataMember = "Pengembalian";
            conn.Close();
        }
        private void btntambah_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT into pengembalian (id_pengembalian, id_sewa, id_pelanggan, id_kamera, status, harga_sewa, tanggal_sewa, lama_sewa ,keterlambatan, tanggal_kembali, denda, biaya_sewa, total_sewa)"+
                "VALUES ('" + txtidpengembalian.Text + "' , '"+ txtidsewa.Text + "' , '" + txtidpelanggan.Text + "' , '" + txtidkamera.Text+"' , '"+ txtidstatus.Text + "' , '" + txthargasewa.Text + "' , '" + dtptanggalsewa.Value.ToString("dd-MM-yyyy") +"' , '"+ txtlamasewa.Text +"' , '"+ txtketerlambatan.Text + "' , '" + dtptanggalkembali.Value.ToString("dd-MM-yyyy") + "' , '" + txtdenda.Text + "' , '"+ txtbiayasewa.Text + "' , '" + txttotalbayar.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Berhasil DiTambah!");
            tampildatapengembalian();
            ClearData();

        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM pengembalian " +
                "WHERE id_pengembalian = '" + txtidpengembalian.Text + "'";
            
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Berhasil DiDelete!");
            tampildatapengembalian();
            ClearData();
        }

        private void ClearData()
        {
            txtdenda.Clear();
            txttotalbayar.Clear(); 
            txtidpengembalian.Clear();
            txtidpelanggan.Clear();
            
            txtidkamera.Clear();
            txthargasewa.Clear();
            txtlamasewa.Clear();
            txtbiayasewa.Clear();
            txtketerlambatan.Clear();
            txtidsewa.Clear();
        }

        private void btnubah_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " UPDATE pengembalian SET " +
                "id_pengembalian = '" + txtidpengembalian.Text + "'" + 
                //","+ "id_pelanggan = '"+ txtidpelanggan.Text + "'"+
                //"id_kamera = '"+ txtidkamera.Text + "'"+ ","+"id_status = '" + txtidstatus.Text + "'"+ "," + "harga_sewa = '" + txthargasewa.Text + "'"+ ","+
                //"tanggal_sewa = '" + dtptanggalsewa.Value.ToString("dd-MM-yyyy") + "'" + "," + "lama_sewa = '"+ txtlamasewa.Text + "'" + "," + "keterlambatan = '" + 
                //txtketerlambatan.Text + "'" + "," + "tanggal_kembali = '" + dtptanggalkembali.Value.ToString("dd-MM-yyyy") + "'" + ", " + "denda = '" + txtdenda.Text + "'"+ ","+
                //"biaya_sewa = '" + txtbiayasewa.Text + "'"+"," + "total_sewa = '"+ txttotalbayar.Text + "'"+
                "WHERE id_sewa = '" + txtidsewa.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Data Berhasil DiUbah!");
            tampildatapengembalian();
            ClearData();
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dtptanggalkembali_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtptanggalsewa_ValueChanged(object sender, EventArgs e)
        {

        }

        private void PENGEMBALIAN_Enter(object sender, EventArgs e)
        {

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

                txtbiayasewa.Text = Convert.ToString(total);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtketerlambatan.Text == "" || txtdenda.Text == " ")
            {
                txtketerlambatan.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txtketerlambatan.Text);
                int b = Convert.ToInt32(txtdenda.Text);
                int c = Convert.ToInt32(txtbiayasewa.Text);
                int jumlah = 0;
                int totalsemua = 0;

                jumlah = a * b;
                totalsemua = c + jumlah;

                txttotalbayar.Text = Convert.ToString(totalsemua);
            }
        }
    }
}
