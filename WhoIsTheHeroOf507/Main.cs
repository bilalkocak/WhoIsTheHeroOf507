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

namespace WhoIsTheHeroOf507
{
    public partial class Main : Form
    {
        int result;
        int kellePuan = 0;
        int turPuan = 0;


        public void puanHesapla()
        {
            baglanti.Open();
            //emre puan
            int emre = 0, kocak = 0, uzun = 0;
            SqlCommand emrePuanHesapla = new SqlCommand("SELECT Puan FROM EmrePuan", baglanti);
            SqlDataReader emreOku = emrePuanHesapla.ExecuteReader();

            while (emreOku.Read())
            {
                emre += (int)emreOku["Puan"];

            }

            baglanti.Close();
            baglanti.Open();


            //kocak puan
            SqlCommand kocakPuanHesapla = new SqlCommand("SELECT Puan FROM KocakPuan", baglanti);
            SqlDataReader kocakOku = kocakPuanHesapla.ExecuteReader();

            while (kocakOku.Read())
            {
                kocak += (int)kocakOku["Puan"];

            }


            baglanti.Close();
            baglanti.Open();
            //uzun puan
            SqlCommand uzunPuanHesapla = new SqlCommand("SELECT Puan FROM UzunPuan", baglanti);
            SqlDataReader uzunOku = uzunPuanHesapla.ExecuteReader();

            while (uzunOku.Read())
            {
                uzun += (int)uzunOku["Puan"];
            }


            baglanti.Close();
            puanDurumuSirala(emre, kocak, uzun);
        }
        public void puanDurumuSirala(int emrePuanToplam, int kocakPuanToplam, int uzunPuanToplam)
        {
            if ((emrePuanToplam > kocakPuanToplam) && (emrePuanToplam > uzunPuanToplam))
            {
                birinciAd.Text = "Emre İ.";
                birinciPuan.Text = emrePuanToplam.ToString();
                if (uzunPuanToplam > kocakPuanToplam)
                {
                    ikinciAd.Text = "B.Uzun";
                    ikinciPuan.Text = uzunPuanToplam.ToString();
                    ucuncuAd.Text = "B.Kocak";
                    ucuncuPuan.Text = kocakPuanToplam.ToString();
                }
                else
                {
                    ikinciAd.Text = "B.Kocak";
                    ikinciPuan.Text = kocakPuanToplam.ToString();
                    ucuncuAd.Text = "B.Uzun";
                    ucuncuPuan.Text = uzunPuanToplam.ToString();
                }
            }
            if ((uzunPuanToplam > kocakPuanToplam) && (uzunPuanToplam > emrePuanToplam))
            {
                birinciAd.Text = "B.Uzun";
                birinciPuan.Text = uzunPuanToplam.ToString();
                if (emrePuanToplam > kocakPuanToplam)
                {
                    ikinciAd.Text = "Emre İ.";
                    ikinciPuan.Text = emrePuanToplam.ToString();
                    ucuncuAd.Text = "B.Kocak";
                    ucuncuPuan.Text = kocakPuanToplam.ToString();
                }
                else
                {
                    ikinciAd.Text = "B.Kocak";
                    ikinciPuan.Text = kocakPuanToplam.ToString();
                    ucuncuAd.Text = "Emre İ.";
                    ucuncuPuan.Text = emrePuanToplam.ToString();
                }
            }
            if ((uzunPuanToplam < kocakPuanToplam) && (kocakPuanToplam > uzunPuanToplam))
            {
                birinciAd.Text = "B.Kocak";
                birinciPuan.Text = kocakPuanToplam.ToString();
                if (emrePuanToplam > uzunPuanToplam)
                {
                    ikinciAd.Text = "Emre İ.";
                    ikinciPuan.Text = emrePuanToplam.ToString();
                    ucuncuAd.Text = "B.Uzun";
                    ucuncuPuan.Text = uzunPuanToplam.ToString();
                }
                else
                {
                    ikinciAd.Text = "B.Uzun";
                    ikinciPuan.Text = uzunPuanToplam.ToString();
                    ucuncuAd.Text = "Emre İ.";
                    ucuncuPuan.Text = emrePuanToplam.ToString();
                }
            }

        }

        public Main()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=BILALKOÇAK\\SQLEXPRESS;Initial Catalog=507;Integrated Security=True");


        private void Form1_Load(object sender, EventArgs e)
        {

            puanHesapla();

        }
        private void VeriGoster(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from SiparisKayit", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void kayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitEkle = new SqlCommand("insert into SiparisKayit(İsim,Yer,Tür,Kelle) values (@i,@y,@t,@k)", baglanti);


            kayitEkle.Parameters.Add("@i", comboİsim.Text);
            kayitEkle.Parameters.Add("@y", comboYer.Text);
            kayitEkle.Parameters.Add("@t", comboTür.Text);
            kayitEkle.Parameters.Add("@k", comboKelle.Text);

            kayitEkle.ExecuteNonQuery();

            if (sonucisim.Text == "Emre")
            {
                SqlCommand emrePuanEkle = new SqlCommand("insert into EmrePuan(Puan) values (@e)", baglanti);
                emrePuanEkle.Parameters.Add("@e", result);
                emrePuanEkle.ExecuteNonQuery();
            }
            if (sonucisim.Text == "Koçak")
            {
                SqlCommand KocakPuanEkle = new SqlCommand("insert into KocakPuan(Puan) values (@k1)", baglanti);
                KocakPuanEkle.Parameters.Add("@k1", result);
                KocakPuanEkle.ExecuteNonQuery();
            }
            if (sonucisim.Text == "Uzun")
            {
                SqlCommand UzunPuanEkle = new SqlCommand("insert into UzunPuan(Puan) values (@u)", baglanti);
                UzunPuanEkle.Parameters.Add("@u", result);
                UzunPuanEkle.ExecuteNonQuery();
            }
            baglanti.Close();
            puanHesapla();

        }

        private void Devam_Click(object sender, EventArgs e)
        {

            if (comboTür.Text == "Odadan İnme")
            {
                turPuan = 10;
            }
            else if (comboTür.Text == "Yol Üstü")
            {
                turPuan = 4;
            }
            else if (comboTür.Text == "Yol Değiştirme")
            {
                turPuan = 7;
            }
            else if (comboTür.Text == "Oda Dışı Sipariş")
            {
                turPuan = 12;
            }
            if (comboKelle.Text == "1")
            {
                kellePuan = 2;
            }
            else if (comboKelle.Text == "2")
            {
                kellePuan = 4;
            }
            result = kellePuan + turPuan;
            sonucisim.Text = comboİsim.Text;
            sonucTurPuan.Text = turPuan.ToString();
            sonucKellePuan.Text = kellePuan.ToString();
            SonucToplamPuan.Text = result.ToString();
        }
    }
}
