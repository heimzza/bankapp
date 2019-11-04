namespace BankaOtomasyonu
{
    partial class formParaYatir
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnYatir = new System.Windows.Forms.Button();
            this.nmrTutar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No";
            // 
            // textBoxHesapNo
            // 
            this.textBoxHesapNo.Location = new System.Drawing.Point(152, 31);
            this.textBoxHesapNo.Name = "textBoxHesapNo";
            this.textBoxHesapNo.Size = new System.Drawing.Size(96, 20);
            this.textBoxHesapNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yatırılacak Tutar";
            // 
            // btnYatir
            // 
            this.btnYatir.Location = new System.Drawing.Point(152, 118);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(75, 23);
            this.btnYatir.TabIndex = 2;
            this.btnYatir.Text = "Para Yatır";
            this.btnYatir.UseVisualStyleBackColor = true;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // nmrTutar
            // 
            this.nmrTutar.Location = new System.Drawing.Point(128, 66);
            this.nmrTutar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmrTutar.Name = "nmrTutar";
            this.nmrTutar.Size = new System.Drawing.Size(120, 20);
            this.nmrTutar.TabIndex = 3;
            // 
            // formParaYatir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.nmrTutar);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxHesapNo);
            this.Controls.Add(this.label1);
            this.Name = "formParaYatir";
            this.Text = "formParaYatir";
            ((System.ComponentModel.ISupportInitialize)(this.nmrTutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.NumericUpDown nmrTutar;
    }
}