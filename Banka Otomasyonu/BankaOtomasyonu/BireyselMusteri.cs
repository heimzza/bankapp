using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    class BireyselMusteri : Musteri
    {
        public override void Havale(int verenHNo, int alanHNo, int para)
        {
            int p = 0;
            base.Havale(verenHNo, alanHNo, para);
            foreach (Musteri m in Banka.Musteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (verenHNo == h.HesapNo)
                    {
                        p = para / 50;
                        if (h.Bakiye < p + para) break;
                        MessageBox.Show("Bu Hesap Bireysel Bir Hesap Olduğu" +
                            " İçin Bankamız Sizden İşlem Ücreti Alacaktır");
                        h.ParaCek(p);
                    }
                }
            }
        }
    }
}
