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
    public partial class Çevre : Form
    {
        public Çevre()
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

        private void button1_Click(object sender, EventArgs e)
        {
            KareÇevre kç = new KareÇevre();
            kç.Show();
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÇemberÇevre çç = new ÇemberÇevre();
            çç.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DikdörtgenÇevre dç = new DikdörtgenÇevre();
            dç.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParalelkenarÇevre pç = new ParalelkenarÇevre();
            pç.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ÜçgenÇevre üç = new ÜçgenÇevre();
            üç.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            YamukÇevre yç = new YamukÇevre();
            yç.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EşkenarDörtgenÇevre edç = new EşkenarDörtgenÇevre();
            edç.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DüzgünÇokgenÇevre dçç = new DüzgünÇokgenÇevre();
            dçç.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ElipsÇevre eç = new ElipsÇevre();
            eç.Show();
            this.Close();
        }
    }
}
