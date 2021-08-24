using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alan_Çevre_Hacim_Hesaplama
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void BtnÇevre_Click(object sender, EventArgs e)
        {
            Çevre ç = new Çevre();
            ç.Show();
            this.Hide();
        }

        private void BtnAlan_Click(object sender, EventArgs e)
        {
            Alan a = new Alan();
            a.Show();
            this.Hide();
        }

        private void Hacim_Click(object sender, EventArgs e)
        {
            Hacim h = new Hacim();
            h.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
