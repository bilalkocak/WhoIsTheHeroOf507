namespace WhoIsTheHeroOf507
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._507DataSet = new WhoIsTheHeroOf507._507DataSet();
            this.siparisKayitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siparisKayitTableAdapter = new WhoIsTheHeroOf507._507DataSetTableAdapters.SiparisKayitTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.verileriGoster = new System.Windows.Forms.Button();
            this.kayit = new System.Windows.Forms.Button();
            this.İsim = new System.Windows.Forms.Label();
            this.comboİsim = new System.Windows.Forms.ComboBox();
            this.comboYer = new System.Windows.Forms.ComboBox();
            this.yer = new System.Windows.Forms.Label();
            this.comboTür = new System.Windows.Forms.ComboBox();
            this.tür = new System.Windows.Forms.Label();
            this.comboKelle = new System.Windows.Forms.ComboBox();
            this.kisi = new System.Windows.Forms.Label();
            this.gbKayıt = new System.Windows.Forms.GroupBox();
            this.sil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SonucToplamPuan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sonucKellePuan = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sonucTurPuan = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sonucisim = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.devam = new System.Windows.Forms.Button();
            this.ucuncuAd = new System.Windows.Forms.Label();
            this.ucuncuPuan = new System.Windows.Forms.Label();
            this.birinciPuan = new System.Windows.Forms.Label();
            this.birinciAd = new System.Windows.Forms.Label();
            this.ikinciPuan = new System.Windows.Forms.Label();
            this.ikinciAd = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._507DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKayitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbKayıt.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _507DataSet
            // 
            this._507DataSet.DataSetName = "_507DataSet";
            this._507DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siparisKayitBindingSource
            // 
            this.siparisKayitBindingSource.DataMember = "SiparisKayit";
            this.siparisKayitBindingSource.DataSource = this._507DataSet;
            // 
            // siparisKayitTableAdapter
            // 
            this.siparisKayitTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // verileriGoster
            // 
            this.verileriGoster.Location = new System.Drawing.Point(69, 244);
            this.verileriGoster.Name = "verileriGoster";
            this.verileriGoster.Size = new System.Drawing.Size(143, 33);
            this.verileriGoster.TabIndex = 1;
            this.verileriGoster.Text = "Verileri Göster";
            this.verileriGoster.UseVisualStyleBackColor = true;
            this.verileriGoster.Click += new System.EventHandler(this.veriGoster);
            // 
            // kayit
            // 
            this.kayit.Location = new System.Drawing.Point(153, 159);
            this.kayit.Name = "kayit";
            this.kayit.Size = new System.Drawing.Size(133, 33);
            this.kayit.TabIndex = 2;
            this.kayit.Text = "Kaydet";
            this.kayit.UseVisualStyleBackColor = true;
            this.kayit.Click += new System.EventHandler(this.kayit_Click);
            // 
            // İsim
            // 
            this.İsim.AutoSize = true;
            this.İsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İsim.Location = new System.Drawing.Point(23, 21);
            this.İsim.Name = "İsim";
            this.İsim.Size = new System.Drawing.Size(38, 20);
            this.İsim.TabIndex = 3;
            this.İsim.Text = "İsim";
            // 
            // comboİsim
            // 
            this.comboİsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboİsim.FormattingEnabled = true;
            this.comboİsim.Items.AddRange(new object[] {
            "Emre",
            "Koçak",
            "Uzun"});
            this.comboİsim.Location = new System.Drawing.Point(67, 18);
            this.comboİsim.Name = "comboİsim";
            this.comboİsim.Size = new System.Drawing.Size(225, 28);
            this.comboİsim.TabIndex = 5;
            this.comboİsim.Text = "İsim seç";
            // 
            // comboYer
            // 
            this.comboYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboYer.FormattingEnabled = true;
            this.comboYer.Items.AddRange(new object[] {
            "Çiğköfte",
            "Petrol",
            "Reis",
            "Çıtır",
            "Diğer"});
            this.comboYer.Location = new System.Drawing.Point(67, 52);
            this.comboYer.Name = "comboYer";
            this.comboYer.Size = new System.Drawing.Size(225, 28);
            this.comboYer.TabIndex = 7;
            this.comboYer.Text = "Yer seç";
            // 
            // yer
            // 
            this.yer.AutoSize = true;
            this.yer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yer.Location = new System.Drawing.Point(23, 55);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(34, 20);
            this.yer.TabIndex = 6;
            this.yer.Text = "Yer";
            // 
            // comboTür
            // 
            this.comboTür.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboTür.FormattingEnabled = true;
            this.comboTür.Items.AddRange(new object[] {
            "Odadan İnme",
            "Yol Üstü",
            "Yol Değiştirme",
            "Oda Dışı Sipariş"});
            this.comboTür.Location = new System.Drawing.Point(67, 86);
            this.comboTür.Name = "comboTür";
            this.comboTür.Size = new System.Drawing.Size(225, 28);
            this.comboTür.TabIndex = 9;
            this.comboTür.Text = "Tür seç";
            // 
            // tür
            // 
            this.tür.AutoSize = true;
            this.tür.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tür.Location = new System.Drawing.Point(23, 89);
            this.tür.Name = "tür";
            this.tür.Size = new System.Drawing.Size(32, 20);
            this.tür.TabIndex = 8;
            this.tür.Text = "Tür";
            // 
            // comboKelle
            // 
            this.comboKelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboKelle.FormattingEnabled = true;
            this.comboKelle.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboKelle.Location = new System.Drawing.Point(67, 120);
            this.comboKelle.Name = "comboKelle";
            this.comboKelle.Size = new System.Drawing.Size(225, 28);
            this.comboKelle.TabIndex = 11;
            this.comboKelle.Text = "Kişi sayısı";
            // 
            // kisi
            // 
            this.kisi.AutoSize = true;
            this.kisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kisi.Location = new System.Drawing.Point(23, 123);
            this.kisi.Name = "kisi";
            this.kisi.Size = new System.Drawing.Size(43, 20);
            this.kisi.TabIndex = 10;
            this.kisi.Text = "Kelle";
            // 
            // gbKayıt
            // 
            this.gbKayıt.Controls.Add(this.devam);
            this.gbKayıt.Controls.Add(this.comboTür);
            this.gbKayıt.Controls.Add(this.kisi);
            this.gbKayıt.Controls.Add(this.tür);
            this.gbKayıt.Controls.Add(this.İsim);
            this.gbKayıt.Controls.Add(this.comboKelle);
            this.gbKayıt.Controls.Add(this.yer);
            this.gbKayıt.Controls.Add(this.comboYer);
            this.gbKayıt.Controls.Add(this.comboİsim);
            this.gbKayıt.Location = new System.Drawing.Point(12, 5);
            this.gbKayıt.Name = "gbKayıt";
            this.gbKayıt.Size = new System.Drawing.Size(339, 198);
            this.gbKayıt.TabIndex = 14;
            this.gbKayıt.TabStop = false;
            this.gbKayıt.Text = " Kayıt Alanı";
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(218, 244);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(150, 33);
            this.sil.TabIndex = 15;
            this.sil.Text = "Seçili Kaydı Sil";
            this.sil.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ikinciPuan);
            this.groupBox1.Controls.Add(this.ikinciAd);
            this.groupBox1.Controls.Add(this.birinciPuan);
            this.groupBox1.Controls.Add(this.birinciAd);
            this.groupBox1.Controls.Add(this.ucuncuPuan);
            this.groupBox1.Controls.Add(this.ucuncuAd);
            this.groupBox1.Location = new System.Drawing.Point(469, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 283);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puan Durumu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.sil);
            this.groupBox2.Controls.Add(this.verileriGoster);
            this.groupBox2.Location = new System.Drawing.Point(12, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 283);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Puan Durumu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SonucToplamPuan);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.sonucKellePuan);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.sonucTurPuan);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.sonucisim);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.kayit);
            this.groupBox3.Location = new System.Drawing.Point(384, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 198);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sonuç";
            // 
            // SonucToplamPuan
            // 
            this.SonucToplamPuan.AutoSize = true;
            this.SonucToplamPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SonucToplamPuan.Location = new System.Drawing.Point(173, 123);
            this.SonucToplamPuan.Name = "SonucToplamPuan";
            this.SonucToplamPuan.Size = new System.Drawing.Size(18, 20);
            this.SonucToplamPuan.TabIndex = 11;
            this.SonucToplamPuan.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(37, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Toplam Puan: ";
            // 
            // sonucKellePuan
            // 
            this.sonucKellePuan.AutoSize = true;
            this.sonucKellePuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucKellePuan.Location = new System.Drawing.Point(173, 90);
            this.sonucKellePuan.Name = "sonucKellePuan";
            this.sonucKellePuan.Size = new System.Drawing.Size(18, 20);
            this.sonucKellePuan.TabIndex = 9;
            this.sonucKellePuan.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(52, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kelle Puanı: ";
            // 
            // sonucTurPuan
            // 
            this.sonucTurPuan.AutoSize = true;
            this.sonucTurPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucTurPuan.Location = new System.Drawing.Point(173, 60);
            this.sonucTurPuan.Name = "sonucTurPuan";
            this.sonucTurPuan.Size = new System.Drawing.Size(18, 20);
            this.sonucTurPuan.TabIndex = 7;
            this.sonucTurPuan.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(63, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tür Puanı: ";
            // 
            // sonucisim
            // 
            this.sonucisim.AutoSize = true;
            this.sonucisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucisim.Location = new System.Drawing.Point(173, 33);
            this.sonucisim.Name = "sonucisim";
            this.sonucisim.Size = new System.Drawing.Size(0, 20);
            this.sonucisim.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(101, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "İsim: ";
            // 
            // devam
            // 
            this.devam.Location = new System.Drawing.Point(159, 159);
            this.devam.Name = "devam";
            this.devam.Size = new System.Drawing.Size(133, 33);
            this.devam.TabIndex = 13;
            this.devam.Text = "Devam";
            this.devam.UseVisualStyleBackColor = true;
            this.devam.Click += new System.EventHandler(this.devam_Click);
            // 
            // ucuncuAd
            // 
            this.ucuncuAd.AutoSize = true;
            this.ucuncuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucuncuAd.Location = new System.Drawing.Point(64, 170);
            this.ucuncuAd.Name = "ucuncuAd";
            this.ucuncuAd.Size = new System.Drawing.Size(0, 22);
            this.ucuncuAd.TabIndex = 0;
            // 
            // ucuncuPuan
            // 
            this.ucuncuPuan.AutoSize = true;
            this.ucuncuPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucuncuPuan.Location = new System.Drawing.Point(169, 170);
            this.ucuncuPuan.Name = "ucuncuPuan";
            this.ucuncuPuan.Size = new System.Drawing.Size(0, 22);
            this.ucuncuPuan.TabIndex = 1;
            // 
            // birinciPuan
            // 
            this.birinciPuan.AutoSize = true;
            this.birinciPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birinciPuan.Location = new System.Drawing.Point(169, 87);
            this.birinciPuan.Name = "birinciPuan";
            this.birinciPuan.Size = new System.Drawing.Size(0, 22);
            this.birinciPuan.TabIndex = 3;
            // 
            // birinciAd
            // 
            this.birinciAd.AutoSize = true;
            this.birinciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birinciAd.Location = new System.Drawing.Point(63, 87);
            this.birinciAd.Name = "birinciAd";
            this.birinciAd.Size = new System.Drawing.Size(0, 22);
            this.birinciAd.TabIndex = 2;
            // 
            // ikinciPuan
            // 
            this.ikinciPuan.AutoSize = true;
            this.ikinciPuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ikinciPuan.Location = new System.Drawing.Point(169, 130);
            this.ikinciPuan.Name = "ikinciPuan";
            this.ikinciPuan.Size = new System.Drawing.Size(0, 22);
            this.ikinciPuan.TabIndex = 5;
            // 
            // ikinciAd
            // 
            this.ikinciAd.AutoSize = true;
            this.ikinciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ikinciAd.Location = new System.Drawing.Point(63, 130);
            this.ikinciAd.Name = "ikinciAd";
            this.ikinciAd.Size = new System.Drawing.Size(0, 22);
            this.ikinciAd.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(149, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Puan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(90, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "İsim";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(6, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "Sıra";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(23, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 22);
            this.label14.TabIndex = 10;
            this.label14.Text = "2.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(23, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "1.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(23, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 22);
            this.label16.TabIndex = 8;
            this.label16.Text = "3.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 515);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbKayıt);
            this.Name = "Form1";
            this.Text = "WhoIsTheHeroOf507";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._507DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisKayitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbKayıt.ResumeLayout(false);
            this.gbKayıt.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private _507DataSet _507DataSet;
        private System.Windows.Forms.BindingSource siparisKayitBindingSource;
        private _507DataSetTableAdapters.SiparisKayitTableAdapter siparisKayitTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button verileriGoster;
        private System.Windows.Forms.Button kayit;
        private System.Windows.Forms.Label İsim;
        private System.Windows.Forms.ComboBox comboİsim;
        private System.Windows.Forms.ComboBox comboYer;
        private System.Windows.Forms.Label yer;
        private System.Windows.Forms.ComboBox comboTür;
        private System.Windows.Forms.Label tür;
        private System.Windows.Forms.ComboBox comboKelle;
        private System.Windows.Forms.Label kisi;
        private System.Windows.Forms.GroupBox gbKayıt;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label SonucToplamPuan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label sonucKellePuan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label sonucTurPuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sonucisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button devam;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ikinciPuan;
        private System.Windows.Forms.Label ikinciAd;
        private System.Windows.Forms.Label birinciPuan;
        private System.Windows.Forms.Label birinciAd;
        private System.Windows.Forms.Label ucuncuPuan;
        private System.Windows.Forms.Label ucuncuAd;
    }
}

