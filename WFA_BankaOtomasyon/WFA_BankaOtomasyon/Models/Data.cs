using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BankaOtomasyon.Models
{
   public class Data
    {
        
        //public Data()
        //{
        //     Data b1 = new Data();
       
        //}
        /*
        Musteri[] musteriler =
{
            new Musteri() {Ad="Mustafa",Soyad="Yardimci",Adresi="Maltepe/İstanbul", Cinsiyet="Erkek",DogumTarihi="04.09.1993", Bakiye=2000000,DogumYeri="Kastamonu",Sifre="123123",TcKimlikNo="11111111111",KullaniciAdi="Mustafa Yardimci"},
           new Musteri() {Ad="Ali",Soyad="Ors",Adresi="Yenisahra/İstanbul",Cinsiyet="Erkek",DogumTarihi="03.06.1988",Bakiye=100000000000000,DogumYeri="Eskişehir",Sifre="asdasd",TcKimlikNo="22222222222",KullaniciAdi="Ali Ors"},
           new Musteri() {Ad="Ayşe",Soyad="Korkmaz",Adresi="Yenimahalle/Ankara",Cinsiyet="Kadın",DogumTarihi="06.12.1995",Bakiye=1000,DogumYeri="Ankara",Sifre="qqq123",TcKimlikNo="33333333333",KullaniciAdi="Ayşe Korkmaz"},
            new Musteri() {Ad="Azra",Soyad="Yılmaz",Adresi="Buca/İzmir",Cinsiyet="Kadın",DogumYeri="Konya",DogumTarihi="22.10.1973",Bakiye=300000,Sifre="www123",TcKimlikNo="44444444444",KullaniciAdi="Azra Yılmaz"}
       };
       */
        public string KullaniciAdi { get; set; }
        public List<Musteri> Musteriler { get; set; }
        public string TcKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogumTarihi { get; set; }
        public string DogumYeri { get; set; }
        public string Cinsiyet { get; set; }
        public string Adresi { get; set; }
        public string Sifre { get; set; }
        
        public  decimal Bakiye { get; set; }
        
        

        //public void BakiyeHesapla()
        //{
        //    Bakiye = 0;

        //}



    }
}
