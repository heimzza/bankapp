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
    public partial class formHavale : Form
    {
        public formHavale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0; int j = 0;
            foreach (Musteri m in Banka.Musteriler)
            {
                foreach (Hesap h in m.hesaplar)
                {
                    if (txtGdHesapNo.Text.ToString() == h.HesapNo.ToString())
                       
                    {
                       k = 1;
                        foreach (Musteri mm in Banka.Musteriler)
                        {
                            foreach (Hesap hh in mm.hesaplar)
                            {
                                if  (txtYtHesapNo.Text.ToString() == hh.HesapNo.ToString())
                                {
                                    j = 1;
                                    m.Havale(h.HesapNo, hh.HesapNo, Convert.ToInt32(nmrTutar.Text));
                                    break;

                                } 
                            }if (j == 1) break;
                           
                        } if (j == 1) break;
                       
                    } 
                }
                if (j == 1) break;
            }
           if (k==0) { MessageBox.Show("Gönderen Hesap Mevcut Değil"); }
           if(j==0){ MessageBox.Show("Yatırılacak Hesap Mevcut Değil"); }
        }
    }
}