using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class BasvuruManager
    {
        //Method İnjection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();
            loggerService.Log();
        
        }
        public void KrediOnBilglendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
