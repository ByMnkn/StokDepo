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

namespace StokDepo.Sayfalar
{
    public partial class StokDepo : Form
    {
        // SQL Balantısı
        SqlConnection baglan = new SqlConnection(@"Data Source=(local);Database=StokDepo;User id=sa;Password=1234;");
        // Tablo kontrol
        SqlDataAdapter bilgi;
        // Belirtilen tabloyu al
        DataTable tablo = new DataTable();
        string sorgu;
        //
        public StokDepo()
        {
            InitializeComponent();
        }

        private void StokDepo_Load(object sender, EventArgs e)
        {
            // Ürüler
                // Bağlantı aç
                baglan.Open();
                // Sorgula
                sorgu = ("SELECT TOP 100 * FROM StokDepo.dbo.Urunler order by id desc");
                bilgi = new SqlDataAdapter(sorgu, baglan);
                // Tablo databese veri çek
                bilgi.Fill(tablo);
                // Tablo veri kaynagını bul
                dataGridView1.DataSource = tablo;
                // Bağlantı kapat
                baglan.Close();
            // Depo
                // Bağlantı aç
                baglan.Open();
                // Sorgula
                sorgu = ("SELECT TOP 100 * FROM StokDepo.dbo.Depo order by id desc");
                bilgi = new SqlDataAdapter(sorgu, baglan);
                // Tablo databese veri çek
                bilgi.Fill(tablo);
                // Tablo veri kaynagını bul
                dataGridView2.DataSource = tablo;
                // Bağlantı kapat
                baglan.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            Sayfalar.UrunEkle UrunEkle = new Sayfalar.UrunEkle();
            UrunEkle.ShowDialog();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            // Tabloyu temizle
            tablo.Clear();
            // Tabloyu yenile
            dataGridView1.Refresh();
            // Form yeniden yükle
            StokDepo_Load(null, null);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // SQL ID çek = ID > 0
            Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // UrunDuzenle Text olarak ID gönder
            Sayfalar.UrunGoster UrunGoster = new Sayfalar.UrunGoster(Text);
            // UrunDuzenle aç
            UrunGoster.ShowDialog();
        }

        private void urun_ara_TextChanged(object sender, EventArgs e)
        {
            // Baglantı
            baglan.Open();
            // Sorgula
            sorgu = ("SELECT * FROM StokDepo.dbo.Urunler WHERE urun_ad LIKE '%" + urun_ara.Text + "%'");
            // SQL veri gönder
            bilgi = new SqlDataAdapter(sorgu, baglan);
            DataSet tablo = new DataSet();
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo.Tables[0];
            //Baglantı kapat
            baglan.Close();
            //
        }

        private void yeniStokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sayfalar.DepoEkle UrunEkle = new Sayfalar.DepoEkle();
            UrunEkle.ShowDialog();
        }

        private void stokKopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // SQL ID çek = ID > 0
            Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            // UrunDuzenle Text olarak ID gönder
            Sayfalar.UrunDuzenle UrunDuzenle = new Sayfalar.UrunDuzenle(Text);
            // UrunDuzenle aç
            UrunDuzenle.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan.Open();
            // Sql sorgu
            SqlCommand sorgu = new SqlCommand("DELETE FROM StokDepo.dbo.Urunler WHERE id=@id", baglan);
            // Fare ile seçili satırın değeri @id'ye aktarılır:
            sorgu.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
            // Sorgu çalıştırılır:
            sorgu.ExecuteNonQuery();
            // Bağlantı kapatılır:
            baglan.Close();
            // Tablonun son hali getirilir:
            // Tabloyu temizle
            tablo.Clear();
            // Tabloyu yenile
            dataGridView1.Refresh();
            // Form yeniden yükle
            StokDepo_Load(null, null);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void depo_ekle_Click(object sender, EventArgs e)
        {
            Sayfalar.DepoEkle DepoEkle = new Sayfalar.DepoEkle();
            DepoEkle.ShowDialog();
        }

        private void depo_yenile_Click(object sender, EventArgs e)
        {
            // Tabloyu temizle
            tablo.Clear();
            // Tabloyu yenile
            dataGridView2.Refresh();
            // Form yeniden yükle
            StokDepo_Load(null, null);
        }

        private void depo_ara_TextChanged(object sender, EventArgs e)
        {
            // Baglantı
            baglan.Open();
            // Sorgula
            sorgu = ("SELECT * FROM StokDepo.dbo.Depo WHERE depo_adi LIKE '%" + depo_ara.Text + "%'");
            // SQL veri gönder
            bilgi = new SqlDataAdapter(sorgu, baglan);
            DataSet tablo = new DataSet();
            bilgi.Fill(tablo);
            dataGridView2.DataSource = tablo.Tables[0];
            //Baglantı kapat
            baglan.Close();
            //
        }
    }
}
