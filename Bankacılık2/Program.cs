using System;
using System.Collections.Generic;

namespace Bankacılık2
{
    class Program
    {
        static void Main(string[] args)
        {
            İhtiyacKrediManager ihtiyackredisi = new İhtiyacKrediManager();
            TasitKrediManager tasitkredisi = new TasitKrediManager();
            KonutKrediManager konutkredisi = new KonutKrediManager();

            BasvuruYap basvur = new BasvuruYap();

            //basvur.Basvuru(ihtiyackredisi,new DataBaseLoggerService());
            //basvur.Basvuru(tasitkredisi, new DataBaseLoggerService());
            //basvur.Basvuru(konutkredisi, new FileBaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager> { ihtiyackredisi, tasitkredisi , konutkredisi };
            basvur.KrediOnBilgilendirmesiYap(krediler);


            basvur.Basvuru(new EsnafKredisiManager(),new List<ILoggerService> {new SMSLoggerService(),new FileBaseLoggerService()}) ;
        }
    }
}
