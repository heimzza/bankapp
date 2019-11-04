using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public class Hesap
    {
        public int HesapNo;
        public int Bakiye=0;
        public int s = 0;
        public int sy = 1;

        public void ParaYatir(int p)
        {
            Bakiye += p; Banka.Bakiye += p;
            MessageBox.Show(this.HesapNo.ToString() + " Numaralı Hesaba " 
                + p.ToString() + " TL Yatırıldı" + "\nYeni Bakiyeniz: " +
                       this.Bakiye.ToString() + " TL");
        }
        public void ParaCek(int p)
        {
            if (p > this.Bakiye)
            {
                sy = 0;
                MessageBox.Show("Yetersiz Bakiye");
            }
            else { 
            Bakiye -= p; Banka.Bakiye -= p;
                sy = 1;
            MessageBox.Show(this.HesapNo.ToString()+" Numaralı Hesaptan "+p.ToString()
                + " TL Çekildi" + "\nYeni Bakiyeniz: " +
                            this.Bakiye.ToString() + " TL");
            }
        }
    
    }
}
