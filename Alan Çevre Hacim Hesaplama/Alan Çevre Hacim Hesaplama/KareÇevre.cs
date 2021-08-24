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
    public partial class KareÇevre : Form
    {
        public KareÇevre()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Çevre ç = new Çevre();
            ç.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kenar,sonuc;
            kenar = Convert.ToDouble(textBox1.Text);
            sonuc = kenar * 4;
            label3.Text = sonuc.ToString();
            label3.Visible = true;
        }
    }
}
