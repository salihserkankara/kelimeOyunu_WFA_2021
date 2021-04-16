using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace kelimeoyunu
{
    public partial class yarisma : Form
    {
        Random r = new Random();
        string[] cekilenSorular = new string[14];
        string cevap;
        public string isim, soyisim, tarih;
        int altmisSaniye = 60, dort_Dakika = 3, otuz_Saniye = 30, besSaniye = 5;
        int soruPuan, kasa = 0, soruX = 0;
        public yarisma()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = kelimeoyunu; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        public void cevapAyristirma()
        {
            char[] cevapDizi = cevap.ToCharArray();
            if (cevap.Length == 4)
            {
                harfBirLbl.Text = Convert.ToString(cevapDizi[0]);
                harfIkiLbl.Text = Convert.ToString(cevapDizi[1]);
                harfUcLbl.Text = Convert.ToString(cevapDizi[2]);
                harfDortLbl.Text = Convert.ToString(cevapDizi[3]);
            }
            else if (cevap.Length == 5)
            {
                harfBirLbl.Text = Convert.ToString(cevapDizi[0]);
                harfIkiLbl.Text = Convert.ToString(cevapDizi[1]);
                harfUcLbl.Text = Convert.ToString(cevapDizi[2]);
                harfDortLbl.Text = Convert.ToString(cevapDizi[3]);
                harfBesLbl.Text = Convert.ToString(cevapDizi[4]);
            }
            else if (cevap.Length == 6)
            {
                harfBirLbl.Text = Convert.ToString(cevapDizi[0]);
                harfIkiLbl.Text = Convert.ToString(cevapDizi[1]);
                harfUcLbl.Text = Convert.ToString(cevapDizi[2]);
                harfDortLbl.Text = Convert.ToString(cevapDizi[3]);
                harfBesLbl.Text = Convert.ToString(cevapDizi[4]);
                harfAltiLbl.Text = Convert.ToString(cevapDizi[5]);
            }
            else if (cevap.Length == 7)
            {
                harfBirLbl.Text = Convert.ToString(cevapDizi[0]);
                harfIkiLbl.Text = Convert.ToString(cevapDizi[1]);
                harfUcLbl.Text = Convert.ToString(cevapDizi[2]);
                harfDortLbl.Text = Convert.ToString(cevapDizi[3]);
                harfBesLbl.Text = Convert.ToString(cevapDizi[4]);
                harfAltiLbl.Text = Convert.ToString(cevapDizi[5]);
                harfYediLbl.Text = Convert.ToString(cevapDizi[6]);
            }
            else if (cevap.Length == 8)
            {
                harfBirLbl.Text = Convert.ToString(cevapDizi[0]);
                harfIkiLbl.Text = Convert.ToString(cevapDizi[1]);
                harfUcLbl.Text = Convert.ToString(cevapDizi[2]);
                harfDortLbl.Text = Convert.ToString(cevapDizi[3]);
                harfBesLbl.Text = Convert.ToString(cevapDizi[4]);
                harfAltiLbl.Text = Convert.ToString(cevapDizi[5]);
                harfYediLbl.Text = Convert.ToString(cevapDizi[6]);
                harfSekizLbl.Text = Convert.ToString(cevapDizi[7]);
            }
            else if (cevap.Length == 9)
            {
                harfBirLbl.Text = Convert.ToString(cevapDizi[0]);
                harfIkiLbl.Text = Convert.ToString(cevapDizi[1]);
                harfUcLbl.Text = Convert.ToString(cevapDizi[2]);
                harfDortLbl.Text = Convert.ToString(cevapDizi[3]);
                harfBesLbl.Text = Convert.ToString(cevapDizi[4]);
                harfAltiLbl.Text = Convert.ToString(cevapDizi[5]);
                harfYediLbl.Text = Convert.ToString(cevapDizi[6]);
                harfSekizLbl.Text = Convert.ToString(cevapDizi[7]);
                harfDokuzLbl.Text = Convert.ToString(cevapDizi[8]);
            }
            else if (cevap.Length == 10)
            {
                harfBirLbl.Text = Convert.ToString(cevapDizi[0]);
                harfIkiLbl.Text = Convert.ToString(cevapDizi[1]);
                harfUcLbl.Text = Convert.ToString(cevapDizi[2]);
                harfDortLbl.Text = Convert.ToString(cevapDizi[3]);
                harfBesLbl.Text = Convert.ToString(cevapDizi[4]);
                harfAltiLbl.Text = Convert.ToString(cevapDizi[5]);
                harfYediLbl.Text = Convert.ToString(cevapDizi[6]);
                harfSekizLbl.Text = Convert.ToString(cevapDizi[7]);
                harfDokuzLbl.Text = Convert.ToString(cevapDizi[8]);
                harfOnLbl.Text = Convert.ToString(cevapDizi[9]);
            }
        }
        private void cevapBtn_Click(object sender, EventArgs e)
        {
            if (cevaplaTxt.Text.ToLower() == cevap.ToLower())
            {
                kasa += soruPuan;
                kasaLbl.Text = Convert.ToString(kasa);
                harfAlSayac = 0;
                oncekiHarfler = "";
                cevapAyristirma();
                dogruLbl.Visible = true;
                yanlisLbl.Visible = false;
                cevapBtn.Visible = false;
                cevaplaTxt.Visible = false;
                cevaplaTxt.Text = "";
                cevapBtn.Visible = false;
                cevaplaSaniyeLbl.Visible = false;
                otuzSaniyeTmr.Stop();
                otuz_Saniye = 30;
                besSaniyeTmr.Start();
                besSaniye = 5;
            }
            else
            {
                dogruLbl.Visible = false;
                yanlisLbl.Visible = true;
            }
            cevaplaTxt.Text = "";
        }
        string oncekiHarfler = "";
        int harfAlSayac = 0;
        private void harfAlBtn_Click(object sender, EventArgs e)
        {
            soruPuan -= 100;
            puanLbl.Text = Convert.ToString(soruPuan);
            if (harfAlSayac < cevap.Length)
            {
                char[] harfAlDizi = cevap.ToCharArray();
                int kacinciHarf = r.Next(1, cevap.Length);
                while (oncekiHarfler.Contains(Convert.ToString(kacinciHarf)))
                {
                    kacinciHarf = r.Next(1, cevap.Length + 1);
                }
                if (oncekiHarfler.Contains(Convert.ToString(kacinciHarf)) == false)
                {
                    switch (kacinciHarf)
                    {
                        case 1:
                            harfBirLbl.Text = Convert.ToString(harfAlDizi[0]);
                            break;
                        case 2:
                            harfIkiLbl.Text = Convert.ToString(harfAlDizi[1]);
                            break;
                        case 3:
                            harfUcLbl.Text = Convert.ToString(harfAlDizi[2]);
                            break;
                        case 4:
                            harfDortLbl.Text = Convert.ToString(harfAlDizi[3]);
                            break;
                        case 5:
                            harfBesLbl.Text = Convert.ToString(harfAlDizi[4]);
                            break;
                        case 6:
                            harfAltiLbl.Text = Convert.ToString(harfAlDizi[5]);
                            break;
                        case 7:
                            harfYediLbl.Text = Convert.ToString(harfAlDizi[6]);
                            break;
                        case 8:
                            harfSekizLbl.Text = Convert.ToString(harfAlDizi[7]);
                            break;
                        case 9:
                            harfDokuzLbl.Text = Convert.ToString(harfAlDizi[8]);
                            break;
                        case 10:
                            harfOnLbl.Text = Convert.ToString(harfAlDizi[9]);
                            break;
                        default:
                            break;
                    }
                    harfAlSayac++;
                }
                oncekiHarfler += Convert.ToString(kacinciHarf);
            }
            if (harfAlSayac == cevap.Length)
            {
                harfAlSayac = 0;
                oncekiHarfler = "";
                dortDakikaTmr.Stop();
                MessageBox.Show("tüm harfleri aldın yeni soruya geçilecek...");
                besSaniyeTmr.Start();
                besSaniye = 5;
            }
        }

        private void besSaniyeTmr_Tick(object sender, EventArgs e)
        {
            besSaniyeTmr.Interval = 1000;
            besSaniye -= 1;
            if (besSaniye == 0)
            {
                dogruLbl.Visible = false;
                yanlisLbl.Visible = false;
                harfAlBtn.Enabled = true;
                dortDakikaTmr.Start();
                besSaniyeTmr.Stop();
                soruCek();
            }
        }

        private void otuzSaniyeTmr_Tick(object sender, EventArgs e)
        {
            otuzSaniyeTmr.Interval = 1000;
            otuz_Saniye -= 1;
            cevaplaSaniyeLbl.Text = Convert.ToString(otuz_Saniye);
            if (otuz_Saniye == 0)
            {
                kasa -= soruPuan;
                kasaLbl.Text = Convert.ToString(kasa);
                otuzSaniyeTmr.Stop();
                cevaplaSaniyeLbl.Text = "0";
                cevaplaSaniyeLbl.Visible = false;
                cevaplaTxt.Visible = false;
                cevapBtn.Visible = false;
                cevapAyristirma();
                harfAlBtn.Enabled = true;
                MessageBox.Show("Belirli süre içerisinde doğru cevabı giremediniz. Yeni soruya geçiliyor...");
                besSaniyeTmr.Start();
                besSaniye = 5;
            }
        }

        private void cevaplaBtn_Click(object sender, EventArgs e)
        {
            cevaplaTxt.Visible = true;
            cevapBtn.Visible = true;
            cevaplaSaniyeLbl.Visible = true;
            dortDakikaTmr.Stop();
            otuzSaniyeTmr.Start();
            otuz_Saniye = 30;
            harfAlBtn.Enabled = false;
        }
        private void dortDakikaTmr_Tick(object sender, EventArgs e)
        {
            dortDakikaTmr.Interval = 1000;
            altmisSaniye -= 1;
            saniyeLbl.Text = Convert.ToString(altmisSaniye);
            dakikaLbl.Text = Convert.ToString(dort_Dakika);
            if (saniyeLbl.Text == "0")
            {
                altmisSaniye = 60;
                dakikaLbl.Text = Convert.ToString(dort_Dakika);
                dort_Dakika -= 1;
            }
            if (dakikaLbl.Text == "-1")
            {
                dortDakikaTmr.Stop();
                dakikaLbl.Text = "0";
                saniyeLbl.Text = "0";
                Enabled = false;
                soruX = 15;
                MessageBox.Show("Süreniz Bitti");
                soruCek();
                Enabled = true;
            }
        }
        private void yarisma_Load(object sender, EventArgs e)
        {
            sonucTarihLbl.Text = tarih;
            isimSoyisimLbl.Text = isim + " " + soyisim;
            dortDakikaTmr.Start();
            soruCek();
        }
        public void soruCek()
        {
            soruX++;
            SqlDataReader okuSoru, okuCevap;
            if (soruX == 1)
            {
                harfBirLbl.Visible = true;
                harfIkiLbl.Visible = true;
                harfUcLbl.Visible = true;
                harfDortLbl.Visible = true;
                harfBesLbl.Visible = false;
                harfAltiLbl.Visible = false;
                harfYediLbl.Visible = false;
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 400;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 4 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                cekilenSorular[0] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 2)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = false;
                harfAltiLbl.Visible = false;
                harfYediLbl.Visible = false;
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 400;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 4 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                if (soruLbl.Text == cekilenSorular[0])
                {
                    okuSoru.Read();
                    soruLbl.Text = okuSoru["soru"].ToString();
                }
                cekilenSorular[1] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 3)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true;
                harfAltiLbl.Visible = false;
                harfYediLbl.Visible = false;
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 500;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 5 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                cekilenSorular[2] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 4)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = false;
                harfYediLbl.Visible = false;
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 500;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 5 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                if (soruLbl.Text == cekilenSorular[2])
                {
                    okuSoru.Read();
                    soruLbl.Text = okuSoru["soru"].ToString();
                }
                cekilenSorular[3] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 5)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true;
                harfYediLbl.Visible = false;
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 600;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 6 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                cekilenSorular[4] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 6)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = false;
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 600;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 6 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                if (soruLbl.Text == cekilenSorular[4])
                {
                    okuSoru.Read();
                    soruLbl.Text = okuSoru["soru"].ToString();
                }
                cekilenSorular[5] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 7)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true;
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 700;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 7 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                cekilenSorular[6] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 8)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true; harfYediLbl.Text = " ";
                harfSekizLbl.Visible = false;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 700;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 7 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                if (soruLbl.Text == cekilenSorular[6])
                {
                    okuSoru.Read();
                    soruLbl.Text = okuSoru["soru"].ToString();
                }
                cekilenSorular[7] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 9)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true; harfYediLbl.Text = " ";
                harfSekizLbl.Visible = true;
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 800;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 8 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                cekilenSorular[8] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 10)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true; harfYediLbl.Text = " ";
                harfSekizLbl.Visible = true; harfSekizLbl.Text = " ";
                harfDokuzLbl.Visible = false;
                harfOnLbl.Visible = false;
                soruPuan = 800;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 8 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                if (soruLbl.Text == cekilenSorular[8])
                {
                    okuSoru.Read();
                    soruLbl.Text = okuSoru["soru"].ToString();
                }
                cekilenSorular[9] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 11)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true; harfYediLbl.Text = " ";
                harfSekizLbl.Visible = true; harfSekizLbl.Text = " ";
                harfDokuzLbl.Visible = true;
                harfOnLbl.Visible = false;
                soruPuan = 900;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 9 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                cekilenSorular[10] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 12)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true; harfYediLbl.Text = " ";
                harfSekizLbl.Visible = true; harfSekizLbl.Text = " ";
                harfDokuzLbl.Visible = true; harfDokuzLbl.Text = " ";
                harfOnLbl.Visible = false;
                soruPuan = 900;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 9 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                if (soruLbl.Text == cekilenSorular[10])
                {
                    okuSoru.Read();
                    soruLbl.Text = okuSoru["soru"].ToString();
                }
                cekilenSorular[11] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 13)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true; harfYediLbl.Text = " ";
                harfSekizLbl.Visible = true; harfSekizLbl.Text = " ";
                harfDokuzLbl.Visible = true; harfDokuzLbl.Text = " ";
                harfOnLbl.Visible = true;
                soruPuan = 1000;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 10 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                cekilenSorular[12] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else if (soruX == 14)
            {
                harfBirLbl.Visible = true; harfBirLbl.Text = " ";
                harfIkiLbl.Visible = true; harfIkiLbl.Text = " ";
                harfUcLbl.Visible = true; harfUcLbl.Text = " ";
                harfDortLbl.Visible = true; harfDortLbl.Text = " ";
                harfBesLbl.Visible = true; harfBesLbl.Text = " ";
                harfAltiLbl.Visible = true; harfAltiLbl.Text = " ";
                harfYediLbl.Visible = true; harfYediLbl.Text = " ";
                harfSekizLbl.Visible = true; harfSekizLbl.Text = " ";
                harfDokuzLbl.Visible = true; harfDokuzLbl.Text = " ";
                harfOnLbl.Visible = true; harfOnLbl.Text = " ";
                soruPuan = 1000;
                puanLbl.Text = Convert.ToString(soruPuan);
                SqlCommand aktarSoru = new SqlCommand("select soru from sorular where harfsayisi = 10 order by newid()", con);
                con.Open();
                okuSoru = aktarSoru.ExecuteReader();
                okuSoru.Read();
                soruLbl.Text = okuSoru["soru"].ToString();
                if (soruLbl.Text == cekilenSorular[12])
                {
                    okuSoru.Read();
                    soruLbl.Text = okuSoru["soru"].ToString();
                }
                cekilenSorular[13] = soruLbl.Text;
                okuSoru.Close();
                SqlCommand aktarCevap = new SqlCommand("select cevap from sorular where soru = '" + soruLbl.Text + "'", con);
                okuCevap = aktarCevap.ExecuteReader();
                okuCevap.Read();
                cevap = okuCevap["cevap"].ToString();
                okuCevap.Close();
                con.Close();
            }
            else
            {
                dortDakikaTmr.Stop();
                Enabled = false;
                cmd.CommandText = "update kisiler set puan = '" + kasa + "', zaman = '" + dakikaLbl.Text + "''" + ikiNoktaLbl.Text + "''" + saniyeLbl.Text + "' where tarih = '" + tarih + "'";
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                FileStream fs = new FileStream(@"oncekiSkorlar.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("**********************************************************************************************************");
                sw.WriteLine("İsim Soyisim: " + isim + " " + soyisim);
                sw.WriteLine("Puan: " + kasa);
                sw.WriteLine("Kalan Süre: " + dakikaLbl.Text.ToString() + ikiNoktaLbl.Text.ToString() + saniyeLbl.Text.ToString());
                sw.WriteLine("Giriş Zamanı: " + tarih);
                sw.Flush();
                sw.Close();
                fs.Close();
                MessageBox.Show("SONUÇLAR\nİsim Soyisim: " + isimSoyisimLbl.Text + "\nPuan: " + kasa + "\nGiriş Zamanı: " + tarih + "\nKalan Süre: " + dakikaLbl.Text + ikiNoktaLbl.Text + saniyeLbl.Text);
                this.Close();
            }
        }
    }
}
