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
    public partial class FormLogin : Form
    {
        //Membuat Koneksi
        private string conStr = "Data Source=LAPTOP-95J0PA55; " +
           "Initial Catalog=sewa_kamera1; Integrated Security=True";
        private SqlConnection conn;

       
        public FormLogin()
        {
            InitializeComponent();
            conn = new SqlConnection(conStr);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        { 
            
            
        }

        private void btnbatallogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {            
            if(txtusername.Text == "" | txtpassword.Text == "")
            {
                MessageBox.Show("Value Tidak Boleh Kosong!", "Peringatan");
                
            }

            conn.Close();
            SqlCommand cmd = new SqlCommand("SELECT * FROM admin where username = '" +
                txtusername.Text + "'and password= '" + txtpassword.Text + "'", conn);
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                rd.Read();
                FormUtama tampil = new FormUtama();
                tampil.Show();
                MessageBox.Show("Anda Berhasil Login!","SELAMAT!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password tidak valid", "EROR");
                txtusername.Text = "";
                txtpassword.Text = "";
                txtusername.Focus();
                rd.Close();
            }

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
