namespace BankaOtomasyonu
{
    partial class formGelirGider
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lablBankBakiye = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // lablBankBakiye
            // 
            this.lablBankBakiye.AutoSize = true;
            this.lablBankBakiye.Location = new System.Drawing.Point(101, 219);
            this.lablBankBakiye.Name = "lablBankBakiye";
            this.lablBankBakiye.Size = new System.Drawing.Size(73, 13);
            this.lablBankBakiye.TabIndex = 1;
            this.lablBankBakiye.Text = "Banka Bakiye";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Banka Bakiyesi:";
            // 
            // formGelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lablBankBakiye);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formGelirGider";
            this.Text = "formGelirGider";
            this.Load += new System.EventHandler(this.formGelirGider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lablBankBakiye;
        private System.Windows.Forms.Label label1;
    }
}