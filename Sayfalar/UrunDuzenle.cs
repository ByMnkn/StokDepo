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

namespace StokDepo.Sayfalar
{
    public partial class UrunDuzenle : Form
    {
        // SQL Balantısı
        SqlConnection baglan = new SqlConnection(@"Data Source=(local);Database=StokDepo;User id=sa;Password=1234;");
        //
        public UrunDuzenle(string text)
        {
            InitializeComponent();
            Text = text;
        }

        private void UrunDuzenle_Load(object sender, EventArgs e)
        {
            // Baglantı
            baglan.Open();
            // Sorgula
            SqlCommand sorgu = new SqlCommand("SELECT * FROM StokDepo.dbo.Urunler WHERE id='"+ Text + "'", baglan);
            SqlDataReader komut = sorgu.ExecuteReader();
            // SQL veri çek
            if (komut.Read())
            {
                urun_ad.Text = komut["urun_ad"].ToString();
                urun_model.Text = komut["urun_model"].ToString();
                urun_serino.Text = komut["urun_serino"].ToString();
                urun_aded.Text = komut["urun_aded"].ToString();
                urun_fiyat.Text = komut["urun_fiyat"].ToString();
                urun_tarih.Text = komut["urun_tarih"].ToString();
                // Resim göster // Resmi SQL resim adı ile karsılastır ve upload dosyasında resim adını bul
                pictureBox2.ImageLocation = Application.StartupPath + "\\upload\\"+ komut["urun_resim"].ToString();
                urun_tarih.Text = komut["urun_tarih"].ToString();
                durum.Text = komut["durum"].ToString();
            }
            else 
            {
                MessageBox.Show("Kayıt Bulunamadı!");
            }
            // Baglantı kapat
            baglan.Close();
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
            // Ek işlemler
                // No olustur
                Random rastgele = new Random();
                // Üretilecek hatf ve sayılar
                string olustur = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                // Üretme degiskenleri
                string uret = "";
                // Her deger 6 karakter ve sayi üretsin
                for (int i = 0; i < 10; i++)
                {
                    // 1. kısım
                    uret += olustur[rastgele.Next(olustur.Length)];
                }
                //Tarih 
                DateTime date = DateTime.Now; // Or whatever
                string tarih = date.ToString("MM/dd/yyyy");
                // Ek işlemler bitti
            // Baglantı
            baglan.Open();
            // Sorgula
            SqlCommand sorgu = new SqlCommand("UPDATE StokDepo.dbo.Urunler SET urun_ad=@urun_ad, urun_model=@urun_model, urun_serino=@urun_serino, urun_aded=@urun_aded, urun_fiyat=@urun_fiyat, urun_tarih=@urun_tarih, urun_resim=@resim, durum=@durum WHERE id='"+ Text +"'", baglan);
            SqlParameterCollection param = sorgu.Parameters;
            //
            // SQL veri gönder
            param.AddWithValue("urun_ad", urun_ad.Text);
            param.AddWithValue("urun_model", urun_model.Text);
            param.AddWithValue("urun_serino", urun_serino.Text);
            param.AddWithValue("urun_aded", urun_aded.Text);
            param.AddWithValue("urun_fiyat", urun_fiyat.Text);
            param.AddWithValue("urun_tarih", urun_tarih.Text);
            param.AddWithValue("resim", pictureBox2.ImageLocation = ResimAdi);
            param.AddWithValue("durum", durum.Text);
            sorgu.ExecuteNonQuery();
            // Urun Log
            // Sorgula
            SqlCommand sorgu1 = new SqlCommand("INSERT INTO StokDepo.dbo.UrunLog(urun_id, islem_tipi, islem_no, islem_tarihi, personel, adet, tutar) VALUES (@urun_id, @islem_tipi, @islem_no, @islem_tarihi, @personel, @adet, @tutar)", baglan);
            SqlParameterCollection param1 = sorgu1.Parameters;
            //
            // SQL veri gönder
            param1.AddWithValue("urun_id", Text);
            param1.AddWithValue("islem_tipi", "Depo İşlemleri");
            param1.AddWithValue("islem_no", uret);
            param1.AddWithValue("islem_tarihi", tarih);
            param1.AddWithValue("personel", "Ana Kullanıcı");
            param1.AddWithValue("adet", urun_aded.Text);
            param1.AddWithValue("tutar", urun_fiyat.Text);
            sorgu1.ExecuteNonQuery();
            // Baglantı kapat
            baglan.Close();
            try
            {
                // İşlem başarılı
                MessageBox.Show("Ürün Düzenlendi.");
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

        private void urun_id1_TextChanged(object sender, EventArgs e)
        {
            // Gizli
        }
    }
}
