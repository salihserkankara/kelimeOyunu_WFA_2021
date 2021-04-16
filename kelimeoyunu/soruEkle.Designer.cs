
namespace kelimeoyunu
{
    partial class soruEkle
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
            this.soruEkleBaslikLbl = new System.Windows.Forms.Label();
            this.soruEkleLbl = new System.Windows.Forms.Label();
            this.cevapEkleLbl = new System.Windows.Forms.Label();
            this.soruEkleTxt = new System.Windows.Forms.TextBox();
            this.cevapEkleTxt = new System.Windows.Forms.TextBox();
            this.soruEkleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // soruEkleBaslikLbl
            // 
            this.soruEkleBaslikLbl.AutoSize = true;
            this.soruEkleBaslikLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.soruEkleBaslikLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruEkleBaslikLbl.ForeColor = System.Drawing.Color.Maroon;
            this.soruEkleBaslikLbl.Location = new System.Drawing.Point(13, 13);
            this.soruEkleBaslikLbl.Name = "soruEkleBaslikLbl";
            this.soruEkleBaslikLbl.Size = new System.Drawing.Size(582, 42);
            this.soruEkleBaslikLbl.TabIndex = 0;
            this.soruEkleBaslikLbl.Text = "KELİME OYUNU\'NA SORU EKLE";
            // 
            // soruEkleLbl
            // 
            this.soruEkleLbl.AutoSize = true;
            this.soruEkleLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.soruEkleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruEkleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.soruEkleLbl.Location = new System.Drawing.Point(13, 59);
            this.soruEkleLbl.Name = "soruEkleLbl";
            this.soruEkleLbl.Size = new System.Drawing.Size(88, 29);
            this.soruEkleLbl.TabIndex = 1;
            this.soruEkleLbl.Text = "SORU:";
            // 
            // cevapEkleLbl
            // 
            this.cevapEkleLbl.AutoSize = true;
            this.cevapEkleLbl.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cevapEkleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapEkleLbl.ForeColor = System.Drawing.Color.Maroon;
            this.cevapEkleLbl.Location = new System.Drawing.Point(12, 94);
            this.cevapEkleLbl.Name = "cevapEkleLbl";
            this.cevapEkleLbl.Size = new System.Drawing.Size(104, 29);
            this.cevapEkleLbl.TabIndex = 1;
            this.cevapEkleLbl.Text = "CEVABI:";
            // 
            // soruEkleTxt
            // 
            this.soruEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruEkleTxt.Location = new System.Drawing.Point(131, 59);
            this.soruEkleTxt.Name = "soruEkleTxt";
            this.soruEkleTxt.Size = new System.Drawing.Size(464, 29);
            this.soruEkleTxt.TabIndex = 1;
            // 
            // cevapEkleTxt
            // 
            this.cevapEkleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cevapEkleTxt.Location = new System.Drawing.Point(131, 94);
            this.cevapEkleTxt.Name = "cevapEkleTxt";
            this.cevapEkleTxt.Size = new System.Drawing.Size(464, 29);
            this.cevapEkleTxt.TabIndex = 2;
            // 
            // soruEkleBtn
            // 
            this.soruEkleBtn.BackColor = System.Drawing.Color.Maroon;
            this.soruEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soruEkleBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.soruEkleBtn.Location = new System.Drawing.Point(131, 130);
            this.soruEkleBtn.Name = "soruEkleBtn";
            this.soruEkleBtn.Size = new System.Drawing.Size(463, 38);
            this.soruEkleBtn.TabIndex = 3;
            this.soruEkleBtn.Text = "EKLE";
            this.soruEkleBtn.UseVisualStyleBackColor = false;
            this.soruEkleBtn.Click += new System.EventHandler(this.soruEkleBtn_Click);
            // 
            // soruEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.soruEkleBtn);
            this.Controls.Add(this.cevapEkleTxt);
            this.Controls.Add(this.soruEkleTxt);
            this.Controls.Add(this.cevapEkleLbl);
            this.Controls.Add(this.soruEkleLbl);
            this.Controls.Add(this.soruEkleBaslikLbl);
            this.Name = "soruEkle";
            this.Text = "SORU EKLE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label soruEkleBaslikLbl;
        private System.Windows.Forms.Label soruEkleLbl;
        private System.Windows.Forms.Label cevapEkleLbl;
        private System.Windows.Forms.TextBox soruEkleTxt;
        private System.Windows.Forms.TextBox cevapEkleTxt;
        private System.Windows.Forms.Button soruEkleBtn;
    }
}