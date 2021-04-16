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

namespace kelimeoyunu
{
    public partial class giris : Form
    {
        yarisma y = new yarisma();
        public giris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=kelimeoyunu;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        private void giris_Load(object sender, EventArgs e)
        {
            girisZamaniLbl.Text = DateTime.Now.ToString();
        }

        private void baslaBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Convert.ToString(isimTxt.Text)) && String.IsNullOrEmpty(Convert.ToString(soyisimTxt.Text)))
            {
                MessageBox.Show("İsminizi ve Soyisminizi Giriniz.");
            }
            else
            {
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into kisiler(tarih, isim, soyisim, puan, zaman) values('" + girisZamaniLbl.Text + "','" + isimTxt.Text + "','" + soyisimTxt.Text + "','" + 0000 + "', 'boş')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();

                y.isim = isimTxt.Text;
                y.soyisim = soyisimTxt.Text;
                y.tarih = girisZamaniLbl.Text;
                y.ShowDialog();
            }

        }

        private void soruEkleAcBtn_Click(object sender, EventArgs e)
        {
            soruEkle se = new soruEkle();
            se.ShowDialog();
        }

        private void oncekiSkorlarBtn_Click(object sender, EventArgs e)
        {
            string yol = Application.StartupPath.ToString() + @"\oncekiSkorlar.txt";
            System.Diagnostics.Process.Start(yol);
        }
    }
}
