using System;
using System.Collections.Generic;
using System.Text;

namespace Bankacılık2
{
    class KonutKrediManager: IKrediManager
    {
        public void hesapla()
        {
            Console.WriteLine("konut kredisi hesaplandı.");
        }
    }
}
