using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Islem
    {
        public int HesapNo;
        public string IslemTuru;
        public int Para=0;
        public int HavaleHesapNo;
        public DateTime time;

        public void ParaYat(int h,int p)
        {
            this.HesapNo = h;
            this.Para = p;
            this.IslemTuru = "Para Yatırma";
            this.time = DateTime.Now;
        }
        public void ParaCek(int h,int p)
        {
            this.HesapNo = h;
            this.Para = -p;
            this.IslemTuru = "Para Çekme";
            this.time = DateTime.Now;
        }
        public void ParaHavaleAl(int VerenHesap,int AlanHesap,int p)
        {
            this.HesapNo = VerenHesap;
            this.Para += p;
            this.HavaleHesapNo = AlanHesap;
            this.IslemTuru = "Havale";
            this.time = DateTime.Now;
        }
        public void ParaHavaleVer(int VerenHesap, int AlanHesap, int p)
        {
            this.HesapNo = AlanHesap;
            this.Para -= p;
            this.HavaleHesapNo = VerenHesap;
            this.IslemTuru = "Havale";
            this.time = DateTime.Now;

        }

        public Islem()
        {
            DateTime time = new DateTime();
            this.time = time;

        }
    }
}
