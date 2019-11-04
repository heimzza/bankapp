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
    public partial class formHesapOzeti : Form
    {
        public formHesapOzeti()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime ilkTarih, SonTarih;
            ilkTarih = Convert.ToDateTime(dateTimePicker1.Text);
            SonTarih = Convert.ToDateTime(dateTimePicker2.Text);
            DataTable tablo = new DataTable();
            tablo.Columns.Add("Hesap No", typeof(int));
            tablo.Columns.Add("Bakiye Değişikliği", typeof(int));
            tablo.Columns.Add("Tür", typeof(string));
            tablo.Columns.Add("Havaleyse Kimden veya Kime", typeof(int));

            foreach (Islem i in Banka.islemler)
            {
                if (i.HesapNo.ToString() == textBoxHesapNo.Text)
                {
                    if (i.time <= SonTarih && i.time >= ilkTarih)
                    {
                        tablo.Rows.Add(i.HesapNo, i.Para, i.IslemTuru, i.HavaleHesapNo);
                        dataGridView1.DataSource = tablo;
                    }
                }
            }
        }
    }
}
