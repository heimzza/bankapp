namespace BankaOtomasyonu
{
    partial class formKullaniciEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAd = new System.Windows.Forms.Label();
            this.labelSoyad = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.comboBoxTur = new System.Windows.Forms.ComboBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.textSoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(44, 9);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(20, 13);
            this.labelAd.TabIndex = 0;
            this.labelAd.Text = "Ad";
            // 
            // labelSoyad
            // 
            this.labelSoyad.AutoSize = true;
            this.labelSoyad.Location = new System.Drawing.Point(44, 47);
            this.labelSoyad.Name = "labelSoyad";
            this.labelSoyad.Size = new System.Drawing.Size(37, 13);
            this.labelSoyad.TabIndex = 0;
            this.labelSoyad.Text = "Soyad";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(141, 12);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 20);
            this.textAd.TabIndex = 1;
            // 
            // comboBoxTur
            // 
            this.comboBoxTur.FormattingEnabled = true;
            this.comboBoxTur.Items.AddRange(new object[] {
            "Bireysel Müşteri",
            "Ticari Müşteri"});
            this.comboBoxTur.Location = new System.Drawing.Point(141, 88);
            this.comboBoxTur.Name = "comboBoxTur";
            this.comboBoxTur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTur.TabIndex = 2;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(141, 133);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriEkle.TabIndex = 3;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // textSoyad
            // 
            this.textSoyad.Location = new System.Drawing.Point(141, 44);
            this.textSoyad.Name = "textSoyad";
            this.textSoyad.Size = new System.Drawing.Size(100, 20);
            this.textSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Türü";
            // 
            // formKullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 261);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.comboBoxTur);
            this.Controls.Add(this.textSoyad);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSoyad);
            this.Controls.Add(this.labelAd);
            this.Name = "formKullaniciEkle";
            this.Text = "formKullaniciEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelSoyad;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.ComboBox comboBoxTur;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox textSoyad;
        private System.Windows.Forms.Label label1;
    }
}