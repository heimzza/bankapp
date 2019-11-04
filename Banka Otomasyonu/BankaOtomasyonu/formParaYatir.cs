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
    public partial class formParaYatir : Form
    {
        public formParaYatir()
        {
            InitializeComponent();
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            int k=0;
            foreach (Musteri m in Banka.Musteriler) {
                foreach (Hesap h in m.hesaplar) {
                    if (textBoxHesapNo.Text.ToString() == h.HesapNo.ToString())
                    {
                        Islem islem = new Islem();
                        islem.ParaYat(h.HesapNo, Convert.ToInt32(nmrTutar.Text));Banka.islemler.Add(islem);
                        h.ParaYatir( Convert.ToInt32(nmrTutar.Text));
                        k += 1;

                    }
                }
            }
            if (k == 0) { MessageBox.Show("Hesap Bulunamadı"); }
          
         }
        
    }
}
