using System;
using System.Collections.Generic;
using System.Text;

namespace Bankacılık2
{
    class BasvuruYap
    {
        public void Basvuru(IKrediManager kredituru,List<ILoggerService> loggerService) 
        {      //interfacelerde onu kalıtan sınıfı tutabilir. 
            kredituru.hesapla();

            foreach (var item in loggerService)
            {
                item.Log();
            }
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.hesapla();
               
            }
        
        }
    }
}
