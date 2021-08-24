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
    public partial class EşkenarÜçgenAlan : Form
    {
        public EşkenarÜçgenAlan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, sonuc;
            a = Convert.ToDouble(textBox1.Text);
            sonuc = ((2 / 3) * (a * a)) / 4;
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
