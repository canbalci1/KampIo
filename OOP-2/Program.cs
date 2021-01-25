using System;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Can Balcı
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "123451";
            musteri1.Adi = "Can";
            musteri1.Soyadi = "Balci";
            musteri1.TcNo = "1234567890";

            //Balcı Ltd

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Balci Ltd";
            musteri2.VergiNo = "123456789";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);

        }
    }
}
