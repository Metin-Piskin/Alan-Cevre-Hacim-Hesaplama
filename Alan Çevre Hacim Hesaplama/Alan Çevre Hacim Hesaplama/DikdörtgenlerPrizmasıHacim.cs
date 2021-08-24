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
    public partial class DikdörtgenlerPrizmasıHacim : Form
    {
        public DikdörtgenlerPrizmasıHacim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, sonuc;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);
            sonuc = a * b * c;
            label3.Text = sonuc.ToString();
            label3.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Hacim h = new Hacim();
            h.Show();
            this.Close();
        }
    }
}
