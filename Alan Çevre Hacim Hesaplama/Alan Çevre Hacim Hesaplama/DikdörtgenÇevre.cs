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
    public partial class DikdörtgenÇevre : Form
    {
        public DikdörtgenÇevre()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Çevre c = new Çevre();
            c.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kısa, uzun, sonuc;
            kısa = Convert.ToDouble(textBox2.Text);
            uzun = Convert.ToDouble(textBox1.Text);
            sonuc = 2 * uzun + 2 * kısa;
            label3.Text = sonuc.ToString();
            label3.Visible = true;
        }
    }
}
