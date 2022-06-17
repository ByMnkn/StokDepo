namespace StokDepo.Sayfalar
{
    partial class StokDepo
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.urun_ara = new System.Windows.Forms.TextBox();
            this.ekle = new System.Windows.Forms.Button();
            this.yenile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_serino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_aded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urun_resim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniStokEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokKopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.değiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.depo_ara = new System.Windows.Forms.TextBox();
            this.depo_ekle = new System.Windows.Forms.Button();
            this.depo_yenile = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.depo_kodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depo_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depo_durum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depo_gorevlisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(915, 28);
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
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stok/Depo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(915, 435);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(907, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Stok";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.urun_ara);
            this.panel2.Controls.Add(this.ekle);
            this.panel2.Controls.Add(this.yenile);
            this.panel2.Location = new System.Drawing.Point(8, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 57);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Arama";
            // 
            // urun_ara
            // 
            this.urun_ara.Location = new System.Drawing.Point(49, 19);
            this.urun_ara.Name = "urun_ara";
            this.urun_ara.Size = new System.Drawing.Size(270, 20);
            this.urun_ara.TabIndex = 6;
            this.urun_ara.TextChanged += new System.EventHandler(this.urun_ara_TextChanged);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(170)))), ((int)(((byte)(71)))));
            this.ekle.Image = global::StokDepo.Properties.Resources.black2;
            this.ekle.Location = new System.Drawing.Point(837, 3);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(51, 51);
            this.ekle.TabIndex = 5;
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // yenile
            // 
            this.yenile.Image = global::StokDepo.Properties.Resources.arrows3;
            this.yenile.Location = new System.Drawing.Point(780, 3);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(51, 51);
            this.yenile.TabIndex = 4;
            this.yenile.UseVisualStyleBackColor = true;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.urun_ad,
            this.urun_model,
            this.urun_serino,
            this.urun_aded,
            this.urun_fiyat,
            this.urun_tarih,
            this.urun_resim,
            this.durum});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(907, 340);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // urun_ad
            // 
            this.urun_ad.DataPropertyName = "urun_ad";
            this.urun_ad.HeaderText = "Ürün Adı";
            this.urun_ad.Name = "urun_ad";
            this.urun_ad.ReadOnly = true;
            // 
            // urun_model
            // 
            this.urun_model.DataPropertyName = "urun_model";
            this.urun_model.HeaderText = "Ürün Model";
            this.urun_model.Name = "urun_model";
            this.urun_model.ReadOnly = true;
            // 
            // urun_serino
            // 
            this.urun_serino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.urun_serino.DataPropertyName = "urun_serino";
            this.urun_serino.HeaderText = "Ürün Serino";
            this.urun_serino.Name = "urun_serino";
            this.urun_serino.ReadOnly = true;
            // 
            // urun_aded
            // 
            this.urun_aded.DataPropertyName = "urun_aded";
            this.urun_aded.HeaderText = "Ürün Adedi";
            this.urun_aded.Name = "urun_aded";
            this.urun_aded.ReadOnly = true;
            // 
            // urun_fiyat
            // 
            this.urun_fiyat.DataPropertyName = "urun_fiyat";
            this.urun_fiyat.HeaderText = "Ürün Fiyat";
            this.urun_fiyat.Name = "urun_fiyat";
            this.urun_fiyat.ReadOnly = true;
            // 
            // urun_tarih
            // 
            this.urun_tarih.DataPropertyName = "urun_tarih";
            this.urun_tarih.HeaderText = "Ürün Tarihi";
            this.urun_tarih.Name = "urun_tarih";
            this.urun_tarih.ReadOnly = true;
            // 
            // urun_resim
            // 
            this.urun_resim.DataPropertyName = "urun_resim";
            this.urun_resim.HeaderText = "Ürün Resim";
            this.urun_resim.Name = "urun_resim";
            this.urun_resim.ReadOnly = true;
            this.urun_resim.Visible = false;
            // 
            // durum
            // 
            this.durum.DataPropertyName = "durum";
            this.durum.HeaderText = "Durum";
            this.durum.Name = "durum";
            this.durum.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniStokEkleToolStripMenuItem,
            this.stokKopyalaToolStripMenuItem,
            this.değiştirToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 92);
            // 
            // yeniStokEkleToolStripMenuItem
            // 
            this.yeniStokEkleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.yeniStokEkleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.yeniStokEkleToolStripMenuItem.Image = global::StokDepo.Properties.Resources.black2;
            this.yeniStokEkleToolStripMenuItem.Name = "yeniStokEkleToolStripMenuItem";
            this.yeniStokEkleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.yeniStokEkleToolStripMenuItem.Text = "Yeni Stok Ekle";
            this.yeniStokEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniStokEkleToolStripMenuItem_Click);
            // 
            // stokKopyalaToolStripMenuItem
            // 
            this.stokKopyalaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.stokKopyalaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.stokKopyalaToolStripMenuItem.Image = global::StokDepo.Properties.Resources.black;
            this.stokKopyalaToolStripMenuItem.Name = "stokKopyalaToolStripMenuItem";
            this.stokKopyalaToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.stokKopyalaToolStripMenuItem.Text = "Stok Kopyala";
            this.stokKopyalaToolStripMenuItem.Click += new System.EventHandler(this.stokKopyalaToolStripMenuItem_Click);
            // 
            // değiştirToolStripMenuItem
            // 
            this.değiştirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.değiştirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.değiştirToolStripMenuItem.Image = global::StokDepo.Properties.Resources.cogwheel;
            this.değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            this.değiştirToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.değiştirToolStripMenuItem.Text = "Değiştir";
            this.değiştirToolStripMenuItem.Click += new System.EventHandler(this.değiştirToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.silToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.silToolStripMenuItem.Image = global::StokDepo.Properties.Resources.remove_symbol;
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Depo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.depo_ara);
            this.panel3.Controls.Add(this.depo_ekle);
            this.panel3.Controls.Add(this.depo_yenile);
            this.panel3.Location = new System.Drawing.Point(8, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 57);
            this.panel3.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Arama";
            // 
            // depo_ara
            // 
            this.depo_ara.Location = new System.Drawing.Point(49, 19);
            this.depo_ara.Name = "depo_ara";
            this.depo_ara.Size = new System.Drawing.Size(270, 20);
            this.depo_ara.TabIndex = 6;
            this.depo_ara.TextChanged += new System.EventHandler(this.depo_ara_TextChanged);
            // 
            // depo_ekle
            // 
            this.depo_ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(170)))), ((int)(((byte)(71)))));
            this.depo_ekle.Image = global::StokDepo.Properties.Resources.black2;
            this.depo_ekle.Location = new System.Drawing.Point(837, 3);
            this.depo_ekle.Name = "depo_ekle";
            this.depo_ekle.Size = new System.Drawing.Size(51, 51);
            this.depo_ekle.TabIndex = 5;
            this.depo_ekle.UseVisualStyleBackColor = false;
            this.depo_ekle.Click += new System.EventHandler(this.depo_ekle_Click);
            // 
            // depo_yenile
            // 
            this.depo_yenile.Image = global::StokDepo.Properties.Resources.arrows3;
            this.depo_yenile.Location = new System.Drawing.Point(780, 3);
            this.depo_yenile.Name = "depo_yenile";
            this.depo_yenile.Size = new System.Drawing.Size(51, 51);
            this.depo_yenile.TabIndex = 4;
            this.depo_yenile.UseVisualStyleBackColor = true;
            this.depo_yenile.Click += new System.EventHandler(this.depo_yenile_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depo_kodu,
            this.depo_adi,
            this.depo_durum,
            this.depo_gorevlisi,
            this.telefon,
            this.adres});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(0, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(907, 337);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // depo_kodu
            // 
            this.depo_kodu.HeaderText = "Depo Kodu";
            this.depo_kodu.Name = "depo_kodu";
            this.depo_kodu.ReadOnly = true;
            // 
            // depo_adi
            // 
            this.depo_adi.HeaderText = "Depo Adı";
            this.depo_adi.Name = "depo_adi";
            this.depo_adi.ReadOnly = true;
            // 
            // depo_durum
            // 
            this.depo_durum.HeaderText = "Durum";
            this.depo_durum.Name = "depo_durum";
            this.depo_durum.ReadOnly = true;
            // 
            // depo_gorevlisi
            // 
            this.depo_gorevlisi.HeaderText = "Depo Görevlisi";
            this.depo_gorevlisi.Name = "depo_gorevlisi";
            this.depo_gorevlisi.ReadOnly = true;
            // 
            // telefon
            // 
            this.telefon.HeaderText = "Telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            // 
            // adres
            // 
            this.adres.HeaderText = "Adres";
            this.adres.Name = "adres";
            this.adres.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(907, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Depo İşlemleri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // StokDepo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 464);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StokDepo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.StokDepo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button yenile;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_serino;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_aded;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun_resim;
        private System.Windows.Forms.DataGridViewTextBoxColumn durum;
        private System.Windows.Forms.TextBox urun_ara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniStokEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem değiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokKopyalaToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depo_ara;
        private System.Windows.Forms.Button depo_ekle;
        private System.Windows.Forms.Button depo_yenile;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn depo_kodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn depo_adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn depo_durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn depo_gorevlisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn adres;
    }
}