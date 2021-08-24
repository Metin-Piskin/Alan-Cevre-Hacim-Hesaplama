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
    public partial class YamukÇevre : Form
    {
        public YamukÇevre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double bir, iki, üç, dört, sonuc;
            bir = Convert.ToDouble(textBox1.Text);
            iki = Convert.ToDouble(textBox2.Text);
            üç = Convert.ToDouble(textBox3.Text);
            dört = Convert.ToDouble(textBox4.Text);
            sonuc = bir + iki + üç + dört;
            label3.Text = sonuc.ToString();
            label3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Çevre ç = new Çevre();
            ç.Show();
            this.Close();
        }
    }
}
