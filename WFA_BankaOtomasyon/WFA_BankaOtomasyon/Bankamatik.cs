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
    public partial class Bankamatik : Form
    {
        public Bankamatik()
        {
            InitializeComponent();
        }
        List<Musteri> musteriler = new List<Musteri>()
{
            new Musteri() {Ad="Mustafa",Soyad="Yardimci",Adresi="Maltepe/İstanbul", Cinsiyet="Erkek",DogumTarihi="04.09.1993", Bakiye=2000000,DogumYeri="Kastamonu",Sifre="123123",TcKimlikNo="11111111111",KullaniciAdi="Mustafa Yardimci"},
           new Musteri() {Ad="Ali",Soyad="Ors",Adresi="Yenisahra/İstanbul",Cinsiyet="Erkek",DogumTarihi="03.06.1988",Bakiye=100000000000000,DogumYeri="Eskişehir",Sifre="asdasd",TcKimlikNo="22222222222",KullaniciAdi="Ali Ors"},
           new Musteri() {Ad="Ayşe",Soyad="Korkmaz",Adresi="Yenimahalle/Ankara",Cinsiyet="Kadın",DogumTarihi="06.12.1995",Bakiye=1000,DogumYeri="Ankara",Sifre="qqq123",TcKimlikNo="33333333333",KullaniciAdi="Ayşe Korkmaz"},
            new Musteri() {Ad="Azra",Soyad="Yılmaz",Adresi="Buca/İzmir",Cinsiyet="Kadın",DogumYeri="Konya",DogumTarihi="22.10.1973",Bakiye=300000,Sifre="www123",TcKimlikNo="44444444444",KullaniciAdi="Azra Yılmaz"}
       };
        public string KullaniciAdi { get; set; }
        
        private void Bankamatik_Load(object sender, EventArgs e)
        {
            //Musteri must = new Musteri();
            foreach (Musteri item in musteriler)
            {
                if (item.KullaniciAdi == item.Ad + " " + item.Soyad)
                {
                    Musteri must = new Musteri();
                    lblAdSoyad.Text = Form1.gonderilecekveri;
                    //lblBakiye.Text = item.Bakiye.ToString("C2");
                    must.Bakiye = item.Bakiye;
                    lblBakiye.Text = item.Bakiye.ToString("C2");
                }
                
            }
           
        }

        

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            
            //ParaYatir p1 = new ParaYatir();
            //this.Hide();
            //p1.Show();
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
        //    ParaCek p2 = new ParaCek();
        //    this.Hide();
        //    p2.Show();
        }

        private void btnParaGonder_Click(object sender, EventArgs e)
        {
            //ParaGonder p3 = new ParaGonder();
            //this.Hide();
            //p3.Show();
        }
    }
}
