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

namespace StokDepo
{
    public partial class StokDepo : Form
    {
        // SQL Baglantısı
        SqlConnection baglan = new SqlConnection(@"Data Source=(local);Database=StokDepo;User id=sa;Password=1234;");
        //
        public StokDepo()
        {
            InitializeComponent();
        }

        private void StokDepo_Load(object sender, EventArgs e)
        {
            try
            {
                // Bağlantı aç
                baglan.Open();
                // Bağlantı başarılı
                durum.Text = ("SQL Bağlandı. ");
                // Bağlantı kapat
                baglan.Close();
            }
            catch (Exception)
            {
                // Bağlantı başarısız
                durum.Text = ("SQL balantısı başarısız. ");
            }
            //
        }

        private void menu_anasayfa_Click(object sender, EventArgs e)
        {
            //
        }

        private void menu_stokdepo_Click(object sender, EventArgs e)
        {
            Sayfalar.StokDepo StokDepo = new Sayfalar.StokDepo();
            // Tek sayfa aç
            StokDepo.ShowDialog();
            // Çoklu sayfa aç
            //StokDepo.Show();
        }
    }
}
