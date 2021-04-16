
namespace kelimeoyunu
{
    partial class yarisma
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
            this.soruLbl = new System.Windows.Forms.Label();
            this.dakikaLbl = new System.Windows.Forms.Label();
            this.ikiNoktaLbl = new System.Windows.Forms.Label();
            this.saniyeLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.harfBirLbl = new System.Windows.Forms.Label();
            this.harfIkiLbl = new System.Windows.Forms.Label();
            this.harfUcLbl = new System.Windows.Forms.Label();
            this.harfDortLbl = new System.Windows.Forms.Label();
            this.harfBesLbl = new System.Windows.Forms.Label();
            this.harfAltiLbl = new System.Windows.Forms.Label();
            this.harfYediLbl = new System.Windows.Forms.Label();
            this.harfSekizLbl = new System.Windows.Forms.Label();
            this.harfDokuzLbl = new System.Windows.Forms.Label();
            this.harfOnLbl = new System.Windows.Forms.Label();
            this.puanLbl = new System.Windows.Forms.Label();
            this.kasaLbl = new System.Windows.Forms.Label();
            this.cevaplaSaniyeLbl = new System.Windows.Forms.Label();
            this.cevaplaBtn = new System.Windows.Forms.Button();
            this.cevaplaTxt = new System.Windows.Forms.TextBox();
            this.harfAlBtn = new System.Windows.Forms.Button();
            this.isimSoyisimLbl = new System.Windows.Forms.Label();
            this.dortDakikaTmr = new System.Windows.Forms.Timer(this.components);
            this.otuzSaniyeTmr = new System.Windows.Forms.Timer(this.components);
            this.sonucTarihLbl = new System.Windows.Forms.Label();
            this.cevapBtn = new System.Windows.Forms.Button();
            this.besSaniyeTmr = new System.Windows.Forms.Timer(this.components);
            this.dogruLbl = new System.Windows.Forms.Label();
            this.yanlisLbl = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // soruLbl
            // 
            this.soruLbl.AutoSize = true;
            this.soruLbl.BackColor = System.Drawing.Color.Maroon;
            this.soruLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.soruLbl.Location = new System.Drawing.Point(3, 0);
            this.soruLbl.Name = "soruLbl";
            this.soruLbl.Size = new System.Drawing.Size(82, 29);
            this.soruLbl.TabIndex = 0;
            this.soruLbl.Text = "SORU";
            // 
            // dakikaLbl
            // 
            this.dakikaLbl.AutoSize = true;
            this.dakikaLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dakikaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dakikaLbl.ForeColor = System.Drawing.Color.Maroon;
            this.dakikaLbl.Location = new System.Drawing.Point(12, 509);
            this.dakikaLbl.Name = "dakikaLbl";
            this.dakikaLbl.Size = new System.Drawing.Size(51, 55);
            this.dakikaLbl.TabIndex = 1;
            this.dakikaLbl.Text = "4";
            // 
            // ikiNoktaLbl
            // 
            this.ikiNoktaLbl.AutoSize = true;
            this.ikiNoktaLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ikiNoktaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ikiNoktaLbl.ForeColor = System.Drawing.Color.Maroon;
            this.ikiNoktaLbl.Location = new System.Drawing.Point(69, 509);
            this.ikiNoktaLbl.Name = "ikiNoktaLbl";
            this.ikiNoktaLbl.Size = new System.Drawing.Size(37, 55);
            this.ikiNoktaLbl.TabIndex = 1;
            this.ikiNoktaLbl.Text = ":";
            // 
            // saniyeLbl
            // 
            this.saniyeLbl.AutoSize = true;
            this.saniyeLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saniyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saniyeLbl.ForeColor = System.Drawing.Color.Maroon;
            this.saniyeLbl.Location = new System.Drawing.Point(112, 509);
            this.saniyeLbl.Name = "saniyeLbl";
            this.saniyeLbl.Size = new System.Drawing.Size(78, 55);
            this.saniyeLbl.TabIndex = 1;
            this.saniyeLbl.Text = "00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Maroon;
            this.flowLayoutPanel1.Controls.Add(this.soruLbl);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 569);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1240, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // harfBirLbl
            // 
            this.harfBirLbl.AutoSize = true;
            this.harfBirLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfBirLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfBirLbl.Location = new System.Drawing.Point(12, 371);
            this.harfBirLbl.Name = "harfBirLbl";
            this.harfBirLbl.Size = new System.Drawing.Size(71, 108);
            this.harfBirLbl.TabIndex = 3;
            this.harfBirLbl.Text = " ";
            this.harfBirLbl.Visible = false;
            // 
            // harfIkiLbl
            // 
            this.harfIkiLbl.AutoSize = true;
            this.harfIkiLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfIkiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfIkiLbl.Location = new System.Drawing.Point(133, 371);
            this.harfIkiLbl.Name = "harfIkiLbl";
            this.harfIkiLbl.Size = new System.Drawing.Size(71, 108);
            this.harfIkiLbl.TabIndex = 3;
            this.harfIkiLbl.Text = " ";
            this.harfIkiLbl.Visible = false;
            // 
            // harfUcLbl
            // 
            this.harfUcLbl.AutoSize = true;
            this.harfUcLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfUcLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfUcLbl.Location = new System.Drawing.Point(258, 371);
            this.harfUcLbl.Name = "harfUcLbl";
            this.harfUcLbl.Size = new System.Drawing.Size(71, 108);
            this.harfUcLbl.TabIndex = 3;
            this.harfUcLbl.Text = " ";
            this.harfUcLbl.Visible = false;
            // 
            // harfDortLbl
            // 
            this.harfDortLbl.AutoSize = true;
            this.harfDortLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfDortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfDortLbl.Location = new System.Drawing.Point(389, 371);
            this.harfDortLbl.Name = "harfDortLbl";
            this.harfDortLbl.Size = new System.Drawing.Size(71, 108);
            this.harfDortLbl.TabIndex = 3;
            this.harfDortLbl.Text = " ";
            this.harfDortLbl.Visible = false;
            // 
            // harfBesLbl
            // 
            this.harfBesLbl.AutoSize = true;
            this.harfBesLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfBesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfBesLbl.Location = new System.Drawing.Point(522, 371);
            this.harfBesLbl.Name = "harfBesLbl";
            this.harfBesLbl.Size = new System.Drawing.Size(71, 108);
            this.harfBesLbl.TabIndex = 3;
            this.harfBesLbl.Text = " ";
            this.harfBesLbl.Visible = false;
            // 
            // harfAltiLbl
            // 
            this.harfAltiLbl.AutoSize = true;
            this.harfAltiLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfAltiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfAltiLbl.Location = new System.Drawing.Point(657, 371);
            this.harfAltiLbl.Name = "harfAltiLbl";
            this.harfAltiLbl.Size = new System.Drawing.Size(71, 108);
            this.harfAltiLbl.TabIndex = 3;
            this.harfAltiLbl.Text = " ";
            this.harfAltiLbl.Visible = false;
            // 
            // harfYediLbl
            // 
            this.harfYediLbl.AutoSize = true;
            this.harfYediLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfYediLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfYediLbl.Location = new System.Drawing.Point(786, 371);
            this.harfYediLbl.Name = "harfYediLbl";
            this.harfYediLbl.Size = new System.Drawing.Size(71, 108);
            this.harfYediLbl.TabIndex = 3;
            this.harfYediLbl.Text = " ";
            this.harfYediLbl.Visible = false;
            // 
            // harfSekizLbl
            // 
            this.harfSekizLbl.AutoSize = true;
            this.harfSekizLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfSekizLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfSekizLbl.Location = new System.Drawing.Point(914, 371);
            this.harfSekizLbl.Name = "harfSekizLbl";
            this.harfSekizLbl.Size = new System.Drawing.Size(71, 108);
            this.harfSekizLbl.TabIndex = 3;
            this.harfSekizLbl.Text = " ";
            this.harfSekizLbl.Visible = false;
            // 
            // harfDokuzLbl
            // 
            this.harfDokuzLbl.AutoSize = true;
            this.harfDokuzLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfDokuzLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfDokuzLbl.Location = new System.Drawing.Point(1043, 371);
            this.harfDokuzLbl.Name = "harfDokuzLbl";
            this.harfDokuzLbl.Size = new System.Drawing.Size(71, 108);
            this.harfDokuzLbl.TabIndex = 3;
            this.harfDokuzLbl.Text = " ";
            this.harfDokuzLbl.Visible = false;
            // 
            // harfOnLbl
            // 
            this.harfOnLbl.AutoSize = true;
            this.harfOnLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.harfOnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfOnLbl.Location = new System.Drawing.Point(1181, 371);
            this.harfOnLbl.Name = "harfOnLbl";
            this.harfOnLbl.Size = new System.Drawing.Size(71, 108);
            this.harfOnLbl.TabIndex = 3;
            this.harfOnLbl.Text = " ";
            this.harfOnLbl.Visible = false;
            // 
            // puanLbl
            // 
            this.puanLbl.AutoSize = true;
            this.puanLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.puanLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLbl.ForeColor = System.Drawing.Color.Maroon;
            this.puanLbl.Location = new System.Drawing.Point(69, 288);
            this.puanLbl.Name = "puanLbl";
            this.puanLbl.Size = new System.Drawing.Size(132, 55);
            this.puanLbl.TabIndex = 4;
            this.puanLbl.Text = "0000";
            // 
            // kasaLbl
            // 
            this.kasaLbl.AutoSize = true;
            this.kasaLbl.BackColor = System.Drawing.Color.BurlyWood;
            this.kasaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kasaLbl.Location = new System.Drawing.Point(69, 233);
            this.kasaLbl.Name = "kasaLbl";
            this.kasaLbl.Size = new System.Drawing.Size(51, 55);
            this.kasaLbl.TabIndex = 5;
            this.kasaLbl.Text = "0";
            // 
            // cevaplaSaniyeLbl
            // 
            this.cevaplaSaniyeLbl.AutoSize = true;
            this.cevaplaSaniyeLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cevaplaSaniyeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevaplaSaniyeLbl.ForeColor = System.Drawing.Color.Maroon;
            this.cevaplaSaniyeLbl.Location = new System.Drawing.Point(933, 511);
            this.cevaplaSaniyeLbl.Name = "cevaplaSaniyeLbl";
            this.cevaplaSaniyeLbl.Size = new System.Drawing.Size(78, 55);
            this.cevaplaSaniyeLbl.TabIndex = 6;
            this.cevaplaSaniyeLbl.Text = "30";
            this.cevaplaSaniyeLbl.Visible = false;
            // 
            // cevaplaBtn
            // 
            this.cevaplaBtn.BackColor = System.Drawing.Color.Maroon;
            this.cevaplaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevaplaBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cevaplaBtn.Location = new System.Drawing.Point(196, 509);
            this.cevaplaBtn.Name = "cevaplaBtn";
            this.cevaplaBtn.Size = new System.Drawing.Size(254, 55);
            this.cevaplaBtn.TabIndex = 7;
            this.cevaplaBtn.Text = "CEVAPLA";
            this.cevaplaBtn.UseVisualStyleBackColor = false;
            this.cevaplaBtn.Click += new System.EventHandler(this.cevaplaBtn_Click);
            // 
            // cevaplaTxt
            // 
            this.cevaplaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.5F);
            this.cevaplaTxt.Location = new System.Drawing.Point(457, 509);
            this.cevaplaTxt.Name = "cevaplaTxt";
            this.cevaplaTxt.Size = new System.Drawing.Size(426, 55);
            this.cevaplaTxt.TabIndex = 8;
            this.cevaplaTxt.Visible = false;
            // 
            // harfAlBtn
            // 
            this.harfAlBtn.BackColor = System.Drawing.Color.Maroon;
            this.harfAlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.harfAlBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.harfAlBtn.Location = new System.Drawing.Point(1017, 509);
            this.harfAlBtn.Name = "harfAlBtn";
            this.harfAlBtn.Size = new System.Drawing.Size(235, 55);
            this.harfAlBtn.TabIndex = 9;
            this.harfAlBtn.Text = "HARF AL";
            this.harfAlBtn.UseVisualStyleBackColor = false;
            this.harfAlBtn.Click += new System.EventHandler(this.harfAlBtn_Click);
            // 
            // isimSoyisimLbl
            // 
            this.isimSoyisimLbl.AutoSize = true;
            this.isimSoyisimLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.isimSoyisimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isimSoyisimLbl.ForeColor = System.Drawing.Color.Maroon;
            this.isimSoyisimLbl.Location = new System.Drawing.Point(13, 13);
            this.isimSoyisimLbl.Name = "isimSoyisimLbl";
            this.isimSoyisimLbl.Size = new System.Drawing.Size(334, 55);
            this.isimSoyisimLbl.TabIndex = 11;
            this.isimSoyisimLbl.Text = "İSİM SOYİSİM";
            // 
            // dortDakikaTmr
            // 
            this.dortDakikaTmr.Interval = 1000;
            this.dortDakikaTmr.Tick += new System.EventHandler(this.dortDakikaTmr_Tick);
            // 
            // otuzSaniyeTmr
            // 
            this.otuzSaniyeTmr.Interval = 1000;
            this.otuzSaniyeTmr.Tick += new System.EventHandler(this.otuzSaniyeTmr_Tick);
            // 
            // sonucTarihLbl
            // 
            this.sonucTarihLbl.AutoSize = true;
            this.sonucTarihLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sonucTarihLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucTarihLbl.ForeColor = System.Drawing.Color.Maroon;
            this.sonucTarihLbl.Location = new System.Drawing.Point(785, 9);
            this.sonucTarihLbl.Name = "sonucTarihLbl";
            this.sonucTarihLbl.Size = new System.Drawing.Size(467, 55);
            this.sonucTarihLbl.TabIndex = 12;
            this.sonucTarihLbl.Text = "10.04.2021 17:21:00";
            // 
            // cevapBtn
            // 
            this.cevapBtn.BackColor = System.Drawing.Color.Maroon;
            this.cevapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cevapBtn.Location = new System.Drawing.Point(889, 509);
            this.cevapBtn.Name = "cevapBtn";
            this.cevapBtn.Size = new System.Drawing.Size(38, 54);
            this.cevapBtn.TabIndex = 13;
            this.cevapBtn.Text = ">";
            this.cevapBtn.UseVisualStyleBackColor = false;
            this.cevapBtn.Visible = false;
            this.cevapBtn.Click += new System.EventHandler(this.cevapBtn_Click);
            // 
            // besSaniyeTmr
            // 
            this.besSaniyeTmr.Interval = 1000;
            this.besSaniyeTmr.Tick += new System.EventHandler(this.besSaniyeTmr_Tick);
            // 
            // dogruLbl
            // 
            this.dogruLbl.AutoSize = true;
            this.dogruLbl.BackColor = System.Drawing.Color.Lime;
            this.dogruLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogruLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dogruLbl.Location = new System.Drawing.Point(525, 233);
            this.dogruLbl.Name = "dogruLbl";
            this.dogruLbl.Size = new System.Drawing.Size(203, 55);
            this.dogruLbl.TabIndex = 14;
            this.dogruLbl.Text = "DOĞRU";
            this.dogruLbl.Visible = false;
            // 
            // yanlisLbl
            // 
            this.yanlisLbl.AutoSize = true;
            this.yanlisLbl.BackColor = System.Drawing.Color.Red;
            this.yanlisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yanlisLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yanlisLbl.Location = new System.Drawing.Point(530, 288);
            this.yanlisLbl.Name = "yanlisLbl";
            this.yanlisLbl.Size = new System.Drawing.Size(195, 55);
            this.yanlisLbl.TabIndex = 15;
            this.yanlisLbl.Text = "YANLIŞ";
            this.yanlisLbl.Visible = false;
            // 
            // yarisma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.yanlisLbl);
            this.Controls.Add(this.dogruLbl);
            this.Controls.Add(this.cevapBtn);
            this.Controls.Add(this.sonucTarihLbl);
            this.Controls.Add(this.isimSoyisimLbl);
            this.Controls.Add(this.harfAlBtn);
            this.Controls.Add(this.cevaplaTxt);
            this.Controls.Add(this.cevaplaBtn);
            this.Controls.Add(this.cevaplaSaniyeLbl);
            this.Controls.Add(this.kasaLbl);
            this.Controls.Add(this.puanLbl);
            this.Controls.Add(this.harfOnLbl);
            this.Controls.Add(this.harfDokuzLbl);
            this.Controls.Add(this.harfSekizLbl);
            this.Controls.Add(this.harfYediLbl);
            this.Controls.Add(this.harfAltiLbl);
            this.Controls.Add(this.harfBesLbl);
            this.Controls.Add(this.harfDortLbl);
            this.Controls.Add(this.harfUcLbl);
            this.Controls.Add(this.harfIkiLbl);
            this.Controls.Add(this.harfBirLbl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.saniyeLbl);
            this.Controls.Add(this.ikiNoktaLbl);
            this.Controls.Add(this.dakikaLbl);
            this.Name = "yarisma";
            this.Text = "KELİME OYUNU";
            this.Load += new System.EventHandler(this.yarisma_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soruLbl;
        private System.Windows.Forms.Label dakikaLbl;
        private System.Windows.Forms.Label ikiNoktaLbl;
        private System.Windows.Forms.Label saniyeLbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label harfBirLbl;
        private System.Windows.Forms.Label harfIkiLbl;
        private System.Windows.Forms.Label harfUcLbl;
        private System.Windows.Forms.Label harfDortLbl;
        private System.Windows.Forms.Label harfBesLbl;
        private System.Windows.Forms.Label harfAltiLbl;
        private System.Windows.Forms.Label harfYediLbl;
        private System.Windows.Forms.Label harfSekizLbl;
        private System.Windows.Forms.Label harfDokuzLbl;
        private System.Windows.Forms.Label harfOnLbl;
        private System.Windows.Forms.Label puanLbl;
        private System.Windows.Forms.Label kasaLbl;
        private System.Windows.Forms.Label cevaplaSaniyeLbl;
        private System.Windows.Forms.Button cevaplaBtn;
        private System.Windows.Forms.TextBox cevaplaTxt;
        private System.Windows.Forms.Button harfAlBtn;
        private System.Windows.Forms.Label isimSoyisimLbl;
        private System.Windows.Forms.Timer dortDakika;
        private System.Windows.Forms.Timer otuzSaniye;
        private System.Windows.Forms.Timer dortDakikaTmr;
        private System.Windows.Forms.Timer otuzSaniyeTmr;
        private System.Windows.Forms.Label sonucTarihLbl;
        private System.Windows.Forms.Button cevapBtn;
        private System.Windows.Forms.Timer besSaniyeTmr;
        private System.Windows.Forms.Label dogruLbl;
        private System.Windows.Forms.Label yanlisLbl;
    }
}

