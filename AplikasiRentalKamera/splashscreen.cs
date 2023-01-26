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
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void splashscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 10;
            if (panel1.Width >= 454)
            {
                timer1.Stop();
                FormLogin tampil = new FormLogin();
                this.Hide();
                tampil.Show();
            }
        }
    }
}
