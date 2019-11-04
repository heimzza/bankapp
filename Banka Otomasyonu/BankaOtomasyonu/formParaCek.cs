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
    public partial class formParaCek : Form
    {
        public formParaCek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(nmrTutar.Text) > 750) { MessageBox.Show("Günlük Limit 750 TLdir.Bunun üzerinde para çekilemez."); }
            else {
                int k = 0; int p = 1;int a = 1;
                foreach (Musteri m in Banka.Musteriler)
                {
                    foreach (Hesap h in m.hesaplar)
                    {
                        if (textBoxHesapNo.Text.ToString() == h.HesapNo.ToString())
                        {
                            k = 1;
                            if (Convert.ToInt32(nmrTutar.Text) <= h.Bakiye) {
                               
                            h.ParaCek(Convert.ToInt32(nmrTutar.Text));Islem islem = new Islem();
                                islem.ParaCek(h.HesapNo, Convert.ToInt32(nmrTutar.Text)); Banka.islemler.Add(islem);
                            }
                            else { 
                                p = (Convert.ToInt32(nmrTutar.Text) - h.Bakiye);
                                Islem islem2 = new Islem();
                                islem2.ParaCek(h.HesapNo, h.Bakiye); Banka.islemler.Add(islem2);
                                h.ParaCek(h.Bakiye);
                                foreach (Hesap n in m.hesaplar)
                                    {
                                      if (p > n.Bakiye && n.Bakiye != 0)
                                        {
                                            p -= n.Bakiye;
                                            n.ParaCek(n.Bakiye);
                                        Islem islem = new Islem();
                                        islem.ParaCek(n.HesapNo, p); Banka.islemler.Add(islem); a = 0; 
                                        }
                                      else if(p!=0 && n.Bakiye != 0)
                                        {
                                        Islem islem = new Islem();
                                        islem.ParaCek(n.HesapNo, p);Banka.islemler.Add(islem);
                                             n.ParaCek(p);a = 1; break;
                                        }else if (n.Bakiye == 0) { a = 0; }
                                       
                                    } break;
                                
                            }
                        }
                    }
                }
                if (a == 0) { MessageBox.Show("Yeterli Seviyede Bakiyeniz" +
                    " Bulunmadığı İçin Kalan Tutar Çekilemiyor"); }
                if (k == 0) { MessageBox.Show("Hesap Bulunamadı"); }
            }
        }
    }
}
