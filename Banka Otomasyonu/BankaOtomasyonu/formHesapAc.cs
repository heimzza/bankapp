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
    public partial class formHesapAc : Form
    {
          public formHesapAc()
        {
            InitializeComponent();
           
        }
        
        private void btnHesapAc_Click(object sender, EventArgs e)
        {
            int k = 0;
            
            foreach (Musteri m in Banka.Musteriler) {
                if (txtMusteriNoIste.Text == m.MusteriNo.ToString())
                {
                    k += 1;
                    Hesap hesap = new Hesap();
                    Banka.ToplamHesapSayisi += 1;
                    hesap.HesapNo += Banka.ToplamHesapSayisi + 1000;
                    m.hesaplar.Add(hesap);
                    MessageBox.Show("Hesap Açıldı. Bu Müşterinin Toplamda " 
                        + m.hesaplar.Count.ToString() + " Hesabı var.\n" +
                        "Yeni Hesabın Numarası: " + hesap.HesapNo);
                    if (Convert.ToInt32(nmrBaslangic.Text) != 0) {
                        hesap.ParaYatir(Convert.ToInt32(nmrBaslangic.Text));
                        Islem islem = new Islem();
                        islem.ParaYat(hesap.HesapNo, Convert.ToInt32(nmrBaslangic.Text)); Banka.islemler.Add(islem);
                    }
                }
             }
            if (k==0){ MessageBox.Show("Müşteri Bulunamadı"); }
       }
        
    }
}
