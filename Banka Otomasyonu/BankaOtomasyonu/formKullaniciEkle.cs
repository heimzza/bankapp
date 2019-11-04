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
    public partial class formKullaniciEkle : Form
    {
        public formKullaniciEkle()
        {
            InitializeComponent();
        }
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if(textAd.Text=="" || textSoyad.Text =="")
            {
                MessageBox.Show("Kullanıcı Adı Ve Soyadı Boş Bırakılamaz");
            }
            else if (comboBoxTur.Text.ToString() == "Bireysel Müşteri") { 
            BireyselMusteri brysl = new BireyselMusteri();
            brysl.Ad = textAd.Text.ToString();
            brysl.Soyad = textSoyad.Text.ToString();
            brysl.HesapTur = "Bireysel";
            Banka.Musteriler.Add(brysl);
            brysl.MusteriNo = Banka.Musteriler.Count + 100;
            MessageBox.Show("Müşteri başarıyla eklendi. " +
                "Müşteri Numaranız: "+brysl.MusteriNo.ToString());
            }
            else if (comboBoxTur.Text.ToString() == "Ticari Müşteri")
            {
                TicariMusteri ticariMusteri = new TicariMusteri();
                ticariMusteri.Ad = textAd.Text.ToString();
                ticariMusteri.Soyad = textSoyad.Text.ToString();
                ticariMusteri.HesapTur = "Ticari";
                Banka.Musteriler.Add(ticariMusteri);
                ticariMusteri.MusteriNo = Banka.Musteriler.Count + 100;
                MessageBox.Show("Müşteri başarıyla eklendi." +
                "Müşteri Numaranız: " + ticariMusteri.MusteriNo.ToString());
            }
            else MessageBox.Show("Hesap Türü Boş Bıraklılamaz");
        }
    }
}
