using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi " +" : " + urun.Adi);
        }

        public void Ekle2(string urunadi, string aciklama, double fiyat,int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunadi);
        }

    }
}
