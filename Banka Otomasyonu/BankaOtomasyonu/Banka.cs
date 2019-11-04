using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
   public class Banka
    {
       public static List<Musteri> Musteriler = new List<Musteri>();
       public static int ToplamHesapSayisi;
       public static int Bakiye=0;
       public static List<Islem> islemler=new List<Islem>();
    }
}
