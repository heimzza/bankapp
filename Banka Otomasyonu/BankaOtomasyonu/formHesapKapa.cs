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
    public partial class formHesapKapa : Form
    {
        public formHesapKapa()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            int s = 0;
            foreach(Musteri m in Banka.Musteriler)
            {
                foreach(Hesap h in m.hesaplar)
                {
                    if (textBoxHesapNo.Text==h.HesapNo.ToString() && h.Bakiye != 0)
                    {
                        MessageBox.Show("Lütfen Önce Tüm Paranızı Çekiniz");
                        s = 1;
                        break;
                    }else if(textBoxHesapNo.Text == h.HesapNo.ToString() && h.Bakiye == 0)
                    {
                        m.hesaplar.Remove(h);
                        s = 1;
                        MessageBox.Show("Hesap Silindi");
                        break;
                    }
                }
            }
            if (s == 0)
            {
                MessageBox.Show("Hesap Mevcut Değil");
            }
        }
    }
}
