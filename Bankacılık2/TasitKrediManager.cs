using System;
using System.Collections.Generic;
using System.Text;

namespace Bankacılık2
{
    class TasitKrediManager: IKrediManager 
    {
        public void hesapla()
        {
            Console.WriteLine("tasit kredisi hesaplandı.");
        }

    }
}
