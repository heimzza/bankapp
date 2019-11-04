using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            
        }
        


        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKullaniciEkle form = new formKullaniciEkle();
            form.MdiParent = this;
            form.Show();
        }

        private void hesapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHesapAc form = new formHesapAc();
            form.MdiParent = this;
            form.Show();
        }

        private void hesapBilgileriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHesapOzeti form = new formHesapOzeti();
            form.MdiParent = this;
            form.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
        
        }

        private void gelirGiderRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGelirGider form = new formGelirGider();
            form.MdiParent = this;
            form.Show();
        }

        private void paraYatırmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formParaYatir form = new formParaYatir();
            form.MdiParent = this;
            form.Show();
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formParaCek form = new formParaCek();
            form.MdiParent = this;
            form.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHavale form = new formHavale();
            form.MdiParent = this;
            form.Show();
        }

        private void hesapKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formHesapKapa form = new formHesapKapa();
            form.MdiParent = this;
            form.Show();
        }
    }
}
