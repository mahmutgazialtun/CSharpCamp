using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Gazi";
            musteri1.Soyadi = "Altun";
            musteri1.TcNo = "1231231313";


            //Tüzel müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4242424";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123123133221";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManeger = new CustomerManager();
            customerManeger.Add(musteri1);
            customerManeger.Add(musteri2);

        }
    }
}
