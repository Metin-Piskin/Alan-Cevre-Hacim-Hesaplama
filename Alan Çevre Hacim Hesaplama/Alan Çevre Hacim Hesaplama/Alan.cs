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
    public partial class Alan : Form
    {
        public Alan()
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
            KareAlan ka = new KareAlan();
            ka.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÇemberAlan ça = new ÇemberAlan();
            ça.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DikdörtgenAlan da = new DikdörtgenAlan();
            da.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParalelkenarAlan pa = new ParalelkenarAlan();
            pa.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ÜçgenAlan üa = new ÜçgenAlan();
            üa.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            YamukAlan ya = new YamukAlan();
            ya.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            EşkenarDörtgenAlan eda = new EşkenarDörtgenAlan();
            eda.Show();
            this.Close();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            ElipsAlan ea = new ElipsAlan();
            ea.Show();
            this.Close();
        }



        private void button11_Click(object sender, EventArgs e)
        {
            EşkenarÜçgenAlan eüa = new EşkenarÜçgenAlan();
            eüa.Show();
            this.Close();
        }
    }
}
