using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiRentalKamera
{
    public partial class FormLogout : Form
    {
        public FormLogout()
        {
            InitializeComponent();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            FormLogin tampil = new FormLogin();
            tampil.Show();
            MessageBox.Show("Anda Telah Berhasil Logout!");
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            FormUtama tampil = new FormUtama();
            tampil.Show();
            this.Hide();
            
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            FormReport tampil = new FormReport();
            tampil.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            FormLogout tampil = new FormLogout();
            tampil.Show();
            this.Hide();
        }

        private void FormLogout_Load(object sender, EventArgs e)
        {

        }
    }
}
