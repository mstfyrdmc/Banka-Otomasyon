using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BankaOtomasyon.Models;

namespace WFA_BankaOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Musteriler
        //  Musteri[] musteriler =
        //{
        //      new Musteri() {Ad="Mustafa",Soyad="Yardimci",Adresi="Maltepe/İstanbul", Cinsiyet="Erkek",DogumTarihi="04.09.1993", Bakiye=2000000,DogumYeri="Kastamonu",Sifre="123123",TcKimlikNo="11111111111"},
        //      new Musteri() {Ad="Ali",Soyad="Ors",Adresi="Yenisahra/İstanbul",Cinsiyet="Erkek",DogumTarihi="03.06.1988",Bakiye=100000000000000,DogumYeri="Eskişehir",Sifre="asdasd",TcKimlikNo="22222222222"},
        //      new Musteri() {Ad="Ayşe",Soyad="Korkmaz",Adresi="Yenimahalle/Ankara",Cinsiyet="Kadın",DogumTarihi="06.12.1995",Bakiye=1000,DogumYeri="Ankara",Sifre="qqq123",TcKimlikNo="33333333333"},
        //      new Musteri() {Ad="Azra",Soyad="Yılmaz",Adresi="Buca/İzmir",Cinsiyet="Kadın",DogumYeri="Konya",DogumTarihi="22.10.1973",Bakiye=300000,Sifre="www123",TcKimlikNo="44444444444"}
        //  }; 
        #endregion
        public static string gonderilecekveri;//yeni

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtTc.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı veya şifrenizi girin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if ((txtTc.Text == "11111111111" && txtSifre.Text == "123123" ) || (txtTc.Text == "22222222222" && txtSifre.Text == "asdasd") || (txtTc.Text == "33333333333" && txtSifre.Text == "qqq123") || (txtTc.Text == "44444444444" && txtSifre.Text == "www123"))
            {
                gonderilecekveri = txtKullaniciAdi.Text;
                Bankamatik girisSayfasi = new Bankamatik();
                girisSayfasi.KullaniciAdi = txtKullaniciAdi.Text;
                this.Hide();
                girisSayfasi.Show();
              
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz  T.C ve ya  Şifre bilgilerinde bir müşteri bulunamadı. Lütfen bilgilerinizi kontrol edin veya sistem yöneticisine başvurun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
