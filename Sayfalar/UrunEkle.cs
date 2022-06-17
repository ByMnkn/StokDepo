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
    public partial class UrunEkle : Form
    {
        // SQL Balantısı
        SqlConnection baglan = new SqlConnection(@"Data Source=(local);Database=StokDepo;User id=sa;Password=1234;");
        //
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            //
        }

        private static string ResimAdi;
        private static string ResimYol;
        private void resim_ekle_Click(object sender, EventArgs e)
        {
            // Resim seç
            openFileDialog1.Title = "Resim Seç";
            // Resim formatı
            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası(*.png)|*.png"; //Filtreleme yapıyoruz.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Resim göster
                pictureBox2.Image = Image.FromFile(openFileDialog1.FileName); // Seçili resimi picturebox nesnesi ile görüntülüyoruz.
                // Resm yolunu al
                ResimYol = openFileDialog1.FileName.ToString(); 
                // Resim ad olustur 
                ResimAdi = "D" + Guid.NewGuid().ToString().Remove(10) + ".jpg";
                // Resmi kaydet
                pictureBox2.Image.Save(Application.StartupPath + "\\upload\\" + ResimAdi, ImageFormat.Jpeg);
            }
        }
        private void resim_sil_Click(object sender, EventArgs e)
        {
            // Resim sil
        }

        private void urun_tamam_Click(object sender, EventArgs e)
        {
            // Baglantı
            baglan.Open();
            // Sorgula
            SqlCommand sorgu = new SqlCommand("INSERT INTO StokDepo.dbo.Urunler(urun_ad, urun_model, urun_serino, urun_aded, urun_fiyat, urun_tarih, urun_resim, durum) VALUES (@urun_ad, @urun_model, @urun_serino, @urun_aded, @urun_fiyat, @urun_tarih,@resim, @durum)", baglan);
            SqlParameterCollection param = sorgu.Parameters;
            //
            // SQL veri gönder
            param.AddWithValue("urun_ad", urun_ad.Text);
            param.AddWithValue("urun_model", urun_model.Text);
            param.AddWithValue("urun_serino", urun_serino.Text);
            param.AddWithValue("urun_aded", urun_aded.Text);
            param.AddWithValue("urun_fiyat", urun_fiyat.Text);
            param.AddWithValue("urun_tarih", urun_tarih.Text);
            param.AddWithValue("resim", ResimAdi);
            param.AddWithValue("durum", durum.Text);
            sorgu.ExecuteNonQuery();
            // Baglantı kapat
            baglan.Close();
            try
            {
                // İşlem başarılı
                MessageBox.Show("Ürün Eklendi.");
                //durum.Text = ("Eklendi");
            }
            catch (Exception)
            {
                // İşlem başarısız
                MessageBox.Show("İşlem sırasında hata oluştu.");
            }
        }
        
        private void urun_iptal_Click(object sender, EventArgs e)
        {
            // Kapat
            this.Close();
        }
    }
}
