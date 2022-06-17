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
using System.Drawing.Imaging;
using System.IO;

namespace StokDepo.Sayfalar
{
    public partial class DepoEkle : Form
    {
        // SQL Balantısı
        SqlConnection baglan = new SqlConnection(@"Data Source=(local);Database=StokDepo;User id=sa;Password=1234;");
        //
        public DepoEkle()
        {
            InitializeComponent();
        }

        private void DepoEkle_Load(object sender, EventArgs e)
        {
            //
        }

        private void depo_tamam_Click(object sender, EventArgs e)
        {
            // Baglantı
            baglan.Open();
            // Sorgula
            SqlCommand sorgu = new SqlCommand("INSERT INTO StokDepo.dbo.Depo(depo_kodu, depo_adi, depo_durum, depo_gorevlisi, telefon, adres, depo_tarih) VALUES (@depo_kodu, @depo_adi, @depo_durum, @depo_gorevlisi, @telefon, @adres, @depo_tarih)", baglan);
            SqlParameterCollection param = sorgu.Parameters;
            //
            // SQL veri gönder
            param.AddWithValue("depo_kodu", depo_kodu.Text);
            param.AddWithValue("depo_adi", depo_adi.Text);
            param.AddWithValue("depo_durum", depo_durum.Text);
            param.AddWithValue("depo_gorevlisi", depo_gorevlisi.Text);
            param.AddWithValue("telefon", telefon.Text);
            param.AddWithValue("adres", adres.Text);
            param.AddWithValue("depo_tarih", depo_tarih.Text);
            sorgu.ExecuteNonQuery();
            // Baglantı kapat
            baglan.Close();
            try
            {
                // İşlem başarılı
                MessageBox.Show("Depo Eklendi.");
                //durum.Text = ("Eklendi");
            }
            catch (Exception)
            {
                // İşlem başarısız
                MessageBox.Show("İşlem sırasında hata oluştu.");
            }
        }
        
        private void depo_iptal_Click(object sender, EventArgs e)
        {
            // Kapat
            this.Close();
        }
    }
}
