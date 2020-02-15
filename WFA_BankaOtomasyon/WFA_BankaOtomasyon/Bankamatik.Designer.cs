namespace WFA_BankaOtomasyon
{
    partial class Bankamatik
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
            this.grpHesapBilgileri = new System.Windows.Forms.GroupBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParaGonder = new System.Windows.Forms.Button();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nmrTutar = new System.Windows.Forms.NumericUpDown();
            this.grpHesapBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHesapBilgileri
            // 
            this.grpHesapBilgileri.Controls.Add(this.nmrTutar);
            this.grpHesapBilgileri.Controls.Add(this.label3);
            this.grpHesapBilgileri.Controls.Add(this.lblBakiye);
            this.grpHesapBilgileri.Controls.Add(this.label2);
            this.grpHesapBilgileri.Controls.Add(this.lblAdSoyad);
            this.grpHesapBilgileri.Controls.Add(this.label1);
            this.grpHesapBilgileri.Location = new System.Drawing.Point(20, 17);
            this.grpHesapBilgileri.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpHesapBilgileri.Name = "grpHesapBilgileri";
            this.grpHesapBilgileri.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpHesapBilgileri.Size = new System.Drawing.Size(773, 231);
            this.grpHesapBilgileri.TabIndex = 1;
            this.grpHesapBilgileri.TabStop = false;
            this.grpHesapBilgileri.Text = "Hesap Bilgileri";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(98, 87);
            this.lblBakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(84, 26);
            this.lblBakiye.TabIndex = 2;
            this.lblBakiye.Text = "0,00TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bakiye:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(150, 41);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(0, 26);
            this.lblAdSoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad - Soyad :";
            // 
            // btnParaGonder
            // 
            this.btnParaGonder.Location = new System.Drawing.Point(528, 273);
            this.btnParaGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaGonder.Name = "btnParaGonder";
            this.btnParaGonder.Size = new System.Drawing.Size(265, 75);
            this.btnParaGonder.TabIndex = 2;
            this.btnParaGonder.Text = "Para Gönder";
            this.btnParaGonder.UseVisualStyleBackColor = true;
            this.btnParaGonder.Click += new System.EventHandler(this.btnParaGonder_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(274, 273);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(227, 75);
            this.btnParaCek.TabIndex = 3;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Location = new System.Drawing.Point(20, 273);
            this.btnParaYatir.Margin = new System.Windows.Forms.Padding(4);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(227, 75);
            this.btnParaYatir.TabIndex = 4;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tutar:";
            // 
            // nmrTutar
            // 
            this.nmrTutar.Location = new System.Drawing.Point(85, 136);
            this.nmrTutar.Name = "nmrTutar";
            this.nmrTutar.Size = new System.Drawing.Size(186, 32);
            this.nmrTutar.TabIndex = 4;
            // 
            // Bankamatik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 371);
            this.Controls.Add(this.btnParaGonder);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.grpHesapBilgileri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bankamatik";
            this.Text = "Bankamatik";
            this.Load += new System.EventHandler(this.Bankamatik_Load);
            this.grpHesapBilgileri.ResumeLayout(false);
            this.grpHesapBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTutar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHesapBilgileri;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParaGonder;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.NumericUpDown nmrTutar;
        private System.Windows.Forms.Label label3;
    }
}