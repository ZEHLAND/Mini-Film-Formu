using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mAVİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void tURUNCUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void yESİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void kIRMIZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void sARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void hAKKIMIZDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Zehra AYDIN tarafından yapıldı.","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mADMAXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hEJnMQG9ev8&ab_channel=WarnerBros.Pictures");
            label1.Text = "MAD MAX";
        }

        private void psILoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068&ab_channel=Movieclips");
            label1.Text = "PS I LOVE YOU";
        }

        private void aynıYıldızınAltındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=aQnlngjZG48&ab_channel=FilmG%C3%BCnl%C3%BCkleri");
            label1.Text = "AYNI YILDIZIN ALTINDA";
        }

        private void korkuSeansıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=hunXjEN-09E&ab_channel=FragmanTV");
            label1.Text = "KORKU SEANSI";
        }

        private void hAKKIMIZDAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Zehra AYDIN tarafından yapıldı.", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çIKIŞToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eLVEDAŞARKISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=qInzYKlP2CY&ab_channel=KahramanDeniz");
            label1.Text = "ELVEDA PROJEM AJAJ";
        }
    }
}
