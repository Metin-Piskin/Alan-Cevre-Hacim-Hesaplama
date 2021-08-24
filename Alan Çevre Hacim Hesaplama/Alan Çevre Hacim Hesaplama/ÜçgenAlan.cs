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
    public partial class ÜçgenAlan : Form
    {
        public ÜçgenAlan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b, h, sonuc;
            b = Convert.ToDouble(textBox1.Text);
            h = Convert.ToDouble(textBox2.Text);
            sonuc = 1 / 2 * (b * h);
            label3.Text = sonuc.ToString();
            label3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Alan a = new Alan();
            a.Show();
            this.Close();
        }
    }
}
