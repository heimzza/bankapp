namespace BankaOtomasyonu
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapBilgileriGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.hesapİşlemleriToolStripMenuItem,
            this.bankaBilgileriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.kullanıcıEkleToolStripMenuItem.Text = "Kullanıcı Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapEkleToolStripMenuItem,
            this.hesapBilgileriGörüntüleToolStripMenuItem,
            this.hesapKapatToolStripMenuItem,
            this.paraYatırmaToolStripMenuItem,
            this.paraÇekmeToolStripMenuItem,
            this.havaleToolStripMenuItem});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // hesapEkleToolStripMenuItem
            // 
            this.hesapEkleToolStripMenuItem.Name = "hesapEkleToolStripMenuItem";
            this.hesapEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hesapEkleToolStripMenuItem.Text = "Hesap Ekle";
            this.hesapEkleToolStripMenuItem.Click += new System.EventHandler(this.hesapEkleToolStripMenuItem_Click);
            // 
            // hesapBilgileriGörüntüleToolStripMenuItem
            // 
            this.hesapBilgileriGörüntüleToolStripMenuItem.Name = "hesapBilgileriGörüntüleToolStripMenuItem";
            this.hesapBilgileriGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hesapBilgileriGörüntüleToolStripMenuItem.Text = "Hesap Özeti";
            this.hesapBilgileriGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.hesapBilgileriGörüntüleToolStripMenuItem_Click);
            // 
            // hesapKapatToolStripMenuItem
            // 
            this.hesapKapatToolStripMenuItem.Name = "hesapKapatToolStripMenuItem";
            this.hesapKapatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hesapKapatToolStripMenuItem.Text = "Hesap Kapat";
            this.hesapKapatToolStripMenuItem.Click += new System.EventHandler(this.hesapKapatToolStripMenuItem_Click);
            // 
            // paraYatırmaToolStripMenuItem
            // 
            this.paraYatırmaToolStripMenuItem.Name = "paraYatırmaToolStripMenuItem";
            this.paraYatırmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paraYatırmaToolStripMenuItem.Text = "Para Yatırma";
            this.paraYatırmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatırmaToolStripMenuItem_Click);
            // 
            // paraÇekmeToolStripMenuItem
            // 
            this.paraÇekmeToolStripMenuItem.Name = "paraÇekmeToolStripMenuItem";
            this.paraÇekmeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.paraÇekmeToolStripMenuItem.Text = "Para Çekme";
            this.paraÇekmeToolStripMenuItem.Click += new System.EventHandler(this.paraÇekmeToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.havaleToolStripMenuItem.Text = "Havale";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // bankaBilgileriToolStripMenuItem
            // 
            this.bankaBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gelirGiderRaporuToolStripMenuItem});
            this.bankaBilgileriToolStripMenuItem.Name = "bankaBilgileriToolStripMenuItem";
            this.bankaBilgileriToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.bankaBilgileriToolStripMenuItem.Text = "Banka Bilgileri";
            // 
            // gelirGiderRaporuToolStripMenuItem
            // 
            this.gelirGiderRaporuToolStripMenuItem.Name = "gelirGiderRaporuToolStripMenuItem";
            this.gelirGiderRaporuToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.gelirGiderRaporuToolStripMenuItem.Text = "Gelir-Gider Raporu";
            this.gelirGiderRaporuToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderRaporuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(523, 315);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapBilgileriGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderRaporuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

