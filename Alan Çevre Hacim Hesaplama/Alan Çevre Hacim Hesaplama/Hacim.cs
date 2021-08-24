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
    public partial class Hacim : Form
    {
        public Hacim()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Giriş g = new Giriş();
            g.Show();
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            KüpHacim kh = new KüpHacim();
            kh.Show();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            KüreHacim kh = new KüreHacim();
            kh.Show();
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DikdörtgenlerPrizmasıHacim dph = new DikdörtgenlerPrizmasıHacim();
            dph.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DikPiramitHacim dph = new DikPiramitHacim();
            dph.Show();
            this.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DikKoniHacim dkh = new DikKoniHacim();
            dkh.Show();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SilindirHacim sh = new SilindirHacim();
            sh.Show();
            this.Close();
        }
    }
}
