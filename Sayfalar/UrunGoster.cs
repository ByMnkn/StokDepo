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
    public partial class UrunGoster : Form
    {
        // SQL Balantısı
        SqlConnection baglan = new SqlConnection(@"Data Source=(local);Database=StokDepo;User id=sa;Password=1234;");
        //
        // Tablo kontrol
        SqlDataAdapter bilgi;
        // Belirtilen tabloyu al
        DataTable tablo = new DataTable();
        string sorgu1;
        //
        public UrunGoster(string text)
        {
            InitializeComponent();
            Text = text;
        }

        private void UrunGoster_Load(object sender, EventArgs e)
        {
            // Baglantı
            baglan.Open();
            // Sorgula
            SqlCommand sorgu = new SqlCommand("SELECT * FROM StokDepo.dbo.Urunler WHERE id='"+ Text + "'", baglan);
            SqlDataReader komut = sorgu.ExecuteReader();
            // SQL veri çek
            if (komut.Read())
            {
                g_urun_ad.Text = komut["urun_ad"].ToString();
                g_urun_model.Text = komut["urun_model"].ToString();
                g_urun_serino.Text = komut["urun_serino"].ToString();
                g_urun_aded.Text = komut["urun_aded"].ToString();
                g_urun_fiyat.Text = komut["urun_fiyat"].ToString();
                g_urun_tarih.Text = komut["urun_tarih"].ToString();
                // Resim göster // Resmi SQL resim adı ile karsılastır ve upload dosyasında resim adını bul
                pictureBox2.ImageLocation = Application.StartupPath + "\\upload\\"+ komut["urun_resim"].ToString();
                g_urun_tarih.Text = komut["urun_tarih"].ToString();
                g_urun_durum.Text = komut["durum"].ToString();
            }
            else {
                MessageBox.Show("Kayıt Bulunamadı!");
            }
            baglan.Close();
            // Bağlantı aç
            baglan.Open();
            // Sorgula
            sorgu1 = ("SELECT TOP 100 * FROM StokDepo.dbo.UrunLog WHERE urun_id='" + Text + "'");
            bilgi = new SqlDataAdapter(sorgu1, baglan);
            // Tablo databese veri çek
            bilgi.Fill(tablo);
            // Tablo veri kaynagını bul
            dataGridView3.DataSource = tablo;
            // Bağlantı kapat
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
            // SQL ID çek = ID > 0
            // UrunDuzenle Text olarak ID gönder
            Sayfalar.UrunDuzenle UrunDuzenle = new Sayfalar.UrunDuzenle(Text);
            // UrunDuzenle aç
            UrunDuzenle.ShowDialog();
        }
        
        private void urun_iptal_Click(object sender, EventArgs e)
        {
            // Kapat
            this.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
    }
}
