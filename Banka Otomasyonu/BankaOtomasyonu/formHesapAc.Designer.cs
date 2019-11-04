namespace BankaOtomasyonu
{
    partial class formHesapAc
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
            this.btnHesapAc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriNoIste = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrBaslangic = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBaslangic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesapAc
            // 
            this.btnHesapAc.Location = new System.Drawing.Point(113, 106);
            this.btnHesapAc.Name = "btnHesapAc";
            this.btnHesapAc.Size = new System.Drawing.Size(75, 23);
            this.btnHesapAc.TabIndex = 4;
            this.btnHesapAc.Text = "Hesap Aç";
            this.btnHesapAc.UseVisualStyleBackColor = true;
            this.btnHesapAc.Click += new System.EventHandler(this.btnHesapAc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Müşteri No Girin";
            // 
            // txtMusteriNoIste
            // 
            this.txtMusteriNoIste.Location = new System.Drawing.Point(113, 24);
            this.txtMusteriNoIste.Name = "txtMusteriNoIste";
            this.txtMusteriNoIste.Size = new System.Drawing.Size(146, 20);
            this.txtMusteriNoIste.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlangıç Bakiyesi";
            // 
            // nmrBaslangic
            // 
            this.nmrBaslangic.Location = new System.Drawing.Point(113, 56);
            this.nmrBaslangic.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmrBaslangic.Name = "nmrBaslangic";
            this.nmrBaslangic.Size = new System.Drawing.Size(120, 20);
            this.nmrBaslangic.TabIndex = 7;
            // 
            // formHesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 252);
            this.Controls.Add(this.nmrBaslangic);
            this.Controls.Add(this.txtMusteriNoIste);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapAc);
            this.Name = "formHesapAc";
            this.Text = "formHesapAc";
            ((System.ComponentModel.ISupportInitialize)(this.nmrBaslangic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHesapAc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriNoIste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmrBaslangic;
    }
}