using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public abstract class Musteri
    {

        public string Ad;
        public string Soyad;
        public string HesapTur;
        public int MusteriNo;
        public List<Hesap> hesaplar;

        public Musteri()
        {
            List<Hesap> hesaplar = new List<Hesap>();
            this.hesaplar = hesaplar;
        }
        public virtual void Havale(int verenHNo, int alanHNo, int para)
        {
            int a = 1;
            foreach (Musteri m in Banka.Musteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (verenHNo == h.HesapNo)
                    {
                        h.ParaCek(para);
                        a = h.sy;
                        if (h.sy == 0) break;
                        foreach (Musteri mm in Banka.Musteriler)
                        {
                            foreach (Hesap hh in mm.hesaplar)
                            {
                                if (alanHNo == hh.HesapNo)
                                {
                                    if (a == 0) break;
                                    Islem islem = new Islem();
                                    islem.ParaHavaleVer(hh.HesapNo, h.HesapNo, para); Banka.islemler.Add(islem);
                                    Islem islem2 = new Islem();
                                    islem2.ParaHavaleAl(hh.HesapNo, h.HesapNo, para); Banka.islemler.Add(islem2);
                                    hh.ParaYatir(para);a = 0; break;
                                }
                            }
                            if (a == 0) break;
                        }
                    }
                    if (a == 0) break;


                } if (a == 0) break;
            }
        }
    }
}
