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
    public partial class formGelirGider : Form
    {
        public formGelirGider()
        {
            InitializeComponent();
        }

        private void formGelirGider_Load(object sender, EventArgs e)
        {
            lablBankBakiye.Text = Banka.Bakiye.ToString();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("Hesap No", typeof(int));
            tablo.Columns.Add("Bakiye Değişikliği", typeof(int));
            tablo.Columns.Add("Tür", typeof(string));
            tablo.Columns.Add("Havaleyse Kimden veya Kime", typeof(int));
            

            foreach (Islem i in Banka.islemler)
            {
                        tablo.Rows.Add(i.HesapNo, i.Para, i.IslemTuru, i.HavaleHesapNo);
                        dataGridView1.DataSource = tablo;
            }
            
        }
    }
}
