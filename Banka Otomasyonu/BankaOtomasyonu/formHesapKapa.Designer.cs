namespace BankaOtomasyonu
{
    partial class formHesapKapa
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.textBoxHesapNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(82, 111);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(86, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Hesabı Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // textBoxHesapNo
            // 
            this.textBoxHesapNo.Location = new System.Drawing.Point(82, 72);
            this.textBoxHesapNo.Name = "textBoxHesapNo";
            this.textBoxHesapNo.Size = new System.Drawing.Size(100, 20);
            this.textBoxHesapNo.TabIndex = 2;
            // 
            // formHesapKapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 225);
            this.Controls.Add(this.textBoxHesapNo);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.label1);
            this.Name = "formHesapKapa";
            this.Text = "formHesapKapa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.TextBox textBoxHesapNo;
    }
}