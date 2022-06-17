namespace StokDepo.Sayfalar
{
    partial class DepoEkle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.depo_gorevlisi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tamam = new System.Windows.Forms.Button();
            this.iptal = new System.Windows.Forms.Button();
            this.durum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depo_durum = new System.Windows.Forms.Label();
            this.depo_adi = new System.Windows.Forms.Label();
            this.urun_tarih = new System.Windows.Forms.DateTimePicker();
            this.depo_kodu = new System.Windows.Forms.TextBox();
            this.depo_tarih = new System.Windows.Forms.Label();
            this.urun_model = new System.Windows.Forms.TextBox();
            this.urun_aded = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.Label();
            this.telefon = new System.Windows.Forms.Label();
            this.urun_serino = new System.Windows.Forms.TextBox();
            this.depo_tamam = new System.Windows.Forms.Button();
            this.depo_iptal = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 28);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::StokDepo.Properties.Resources.bars_1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Depo Ekle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.depo_gorevlisi);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.durum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.depo_durum);
            this.groupBox1.Controls.Add(this.depo_adi);
            this.groupBox1.Controls.Add(this.urun_tarih);
            this.groupBox1.Controls.Add(this.depo_kodu);
            this.groupBox1.Controls.Add(this.depo_tarih);
            this.groupBox1.Controls.Add(this.urun_model);
            this.groupBox1.Controls.Add(this.urun_aded);
            this.groupBox1.Controls.Add(this.adres);
            this.groupBox1.Controls.Add(this.telefon);
            this.groupBox1.Controls.Add(this.urun_serino);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 221);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depo Bilgileri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ana Kullanıcı"});
            this.comboBox1.Location = new System.Drawing.Point(86, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.Tag = "";
            // 
            // depo_gorevlisi
            // 
            this.depo_gorevlisi.AutoSize = true;
            this.depo_gorevlisi.Location = new System.Drawing.Point(6, 131);
            this.depo_gorevlisi.Name = "depo_gorevlisi";
            this.depo_gorevlisi.Size = new System.Drawing.Size(76, 13);
            this.depo_gorevlisi.TabIndex = 27;
            this.depo_gorevlisi.Text = "Depo Görevlisi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.tamam);
            this.panel2.Controls.Add(this.iptal);
            this.panel2.Location = new System.Drawing.Point(273, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 59);
            this.panel2.TabIndex = 13;
            // 
            // tamam
            // 
            this.tamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(170)))), ((int)(((byte)(71)))));
            this.tamam.ForeColor = System.Drawing.Color.White;
            this.tamam.Location = new System.Drawing.Point(128, 11);
            this.tamam.Name = "tamam";
            this.tamam.Size = new System.Drawing.Size(76, 36);
            this.tamam.TabIndex = 5;
            this.tamam.Text = "Tamamla";
            this.tamam.UseVisualStyleBackColor = false;
            // 
            // iptal
            // 
            this.iptal.Location = new System.Drawing.Point(210, 11);
            this.iptal.Name = "iptal";
            this.iptal.Size = new System.Drawing.Size(76, 36);
            this.iptal.TabIndex = 4;
            this.iptal.Text = "İptal";
            this.iptal.UseVisualStyleBackColor = true;
            // 
            // durum
            // 
            this.durum.FormattingEnabled = true;
            this.durum.Items.AddRange(new object[] {
            "Açık",
            "Kapalı"});
            this.durum.Location = new System.Drawing.Point(86, 155);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(245, 21);
            this.durum.TabIndex = 26;
            this.durum.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Depo Kodu";
            // 
            // depo_durum
            // 
            this.depo_durum.AutoSize = true;
            this.depo_durum.Location = new System.Drawing.Point(6, 158);
            this.depo_durum.Name = "depo_durum";
            this.depo_durum.Size = new System.Drawing.Size(38, 13);
            this.depo_durum.TabIndex = 25;
            this.depo_durum.Text = "Durum";
            // 
            // depo_adi
            // 
            this.depo_adi.AutoSize = true;
            this.depo_adi.Location = new System.Drawing.Point(6, 53);
            this.depo_adi.Name = "depo_adi";
            this.depo_adi.Size = new System.Drawing.Size(51, 13);
            this.depo_adi.TabIndex = 15;
            this.depo_adi.Text = "Depo Adı";
            // 
            // urun_tarih
            // 
            this.urun_tarih.CustomFormat = "";
            this.urun_tarih.Location = new System.Drawing.Point(86, 182);
            this.urun_tarih.Name = "urun_tarih";
            this.urun_tarih.Size = new System.Drawing.Size(245, 20);
            this.urun_tarih.TabIndex = 24;
            // 
            // depo_kodu
            // 
            this.depo_kodu.Location = new System.Drawing.Point(86, 24);
            this.depo_kodu.Name = "depo_kodu";
            this.depo_kodu.Size = new System.Drawing.Size(245, 20);
            this.depo_kodu.TabIndex = 17;
            // 
            // depo_tarih
            // 
            this.depo_tarih.AutoSize = true;
            this.depo_tarih.Location = new System.Drawing.Point(6, 184);
            this.depo_tarih.Name = "depo_tarih";
            this.depo_tarih.Size = new System.Drawing.Size(31, 13);
            this.depo_tarih.TabIndex = 23;
            this.depo_tarih.Text = "Tarih";
            // 
            // urun_model
            // 
            this.urun_model.Location = new System.Drawing.Point(86, 50);
            this.urun_model.Name = "urun_model";
            this.urun_model.Size = new System.Drawing.Size(245, 20);
            this.urun_model.TabIndex = 18;
            // 
            // urun_aded
            // 
            this.urun_aded.Location = new System.Drawing.Point(86, 102);
            this.urun_aded.Name = "urun_aded";
            this.urun_aded.Size = new System.Drawing.Size(245, 20);
            this.urun_aded.TabIndex = 22;
            // 
            // adres
            // 
            this.adres.AutoSize = true;
            this.adres.Location = new System.Drawing.Point(6, 79);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(34, 13);
            this.adres.TabIndex = 19;
            this.adres.Text = "Adres";
            // 
            // telefon
            // 
            this.telefon.AutoSize = true;
            this.telefon.Location = new System.Drawing.Point(6, 105);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(43, 13);
            this.telefon.TabIndex = 21;
            this.telefon.Text = "Telefon";
            // 
            // urun_serino
            // 
            this.urun_serino.Location = new System.Drawing.Point(86, 76);
            this.urun_serino.Name = "urun_serino";
            this.urun_serino.Size = new System.Drawing.Size(245, 20);
            this.urun_serino.TabIndex = 20;
            // 
            // depo_tamam
            // 
            this.depo_tamam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(170)))), ((int)(((byte)(71)))));
            this.depo_tamam.ForeColor = System.Drawing.Color.White;
            this.depo_tamam.Location = new System.Drawing.Point(101, 11);
            this.depo_tamam.Name = "depo_tamam";
            this.depo_tamam.Size = new System.Drawing.Size(76, 36);
            this.depo_tamam.TabIndex = 5;
            this.depo_tamam.Text = "Tamamla";
            this.depo_tamam.UseVisualStyleBackColor = false;
            this.depo_tamam.Click += new System.EventHandler(this.depo_tamam_Click);
            // 
            // depo_iptal
            // 
            this.depo_iptal.Location = new System.Drawing.Point(183, 11);
            this.depo_iptal.Name = "depo_iptal";
            this.depo_iptal.Size = new System.Drawing.Size(76, 36);
            this.depo_iptal.TabIndex = 4;
            this.depo_iptal.Text = "İptal";
            this.depo_iptal.UseVisualStyleBackColor = true;
            this.depo_iptal.Click += new System.EventHandler(this.depo_iptal_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.depo_tamam);
            this.panel3.Controls.Add(this.depo_iptal);
            this.panel3.Location = new System.Drawing.Point(12, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 59);
            this.panel3.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DepoEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 342);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DepoEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.DepoEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label depo_gorevlisi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button tamam;
        private System.Windows.Forms.Button iptal;
        private System.Windows.Forms.ComboBox durum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label depo_durum;
        private System.Windows.Forms.Label depo_adi;
        private System.Windows.Forms.TextBox depo_kodu;
        private System.Windows.Forms.Label depo_tarih;
        private System.Windows.Forms.TextBox urun_model;
        private System.Windows.Forms.TextBox urun_aded;
        private System.Windows.Forms.Label adres;
        private System.Windows.Forms.Label telefon;
        private System.Windows.Forms.TextBox urun_serino;
        private System.Windows.Forms.Button depo_tamam;
        private System.Windows.Forms.Button depo_iptal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker urun_tarih;
    }
}