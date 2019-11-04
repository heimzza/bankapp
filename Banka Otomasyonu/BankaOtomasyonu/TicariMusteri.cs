using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    class TicariMusteri : Musteri
    {
        public override void Havale(int verenHNo, int alanHNo, int para)
        {
            base.Havale(verenHNo, alanHNo, para);
        }
    }
}
