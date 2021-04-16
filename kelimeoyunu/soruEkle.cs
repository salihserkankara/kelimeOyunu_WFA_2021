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
    public partial class soruEkle : Form
    {
        public soruEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source =.; Initial Catalog = kelimeoyunu; Integrated Security = True");
        SqlCommand cmd = new SqlCommand();
        private void soruEkleBtn_Click(object sender, EventArgs e)
        {
            if ((cevapEkleTxt.Text.Length >= 4 || cevapEkleTxt.Text.Length <= 10) && String.IsNullOrEmpty(soruEkleTxt.Text) == false)
            {
                int harfsayisi = cevapEkleTxt.Text.Length;
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into sorular(soru, cevap, harfsayisi) values('" + soruEkleTxt.Text + "','" + cevapEkleTxt.Text + "','" + harfsayisi + "')";
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("EKLENDİ");
            }
            else
            {
                MessageBox.Show("Cevap 4 ila 10 harf arası olmalıdır.");
            }
        }
    }
}
