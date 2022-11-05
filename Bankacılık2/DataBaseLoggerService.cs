using System;
using System.Collections.Generic;
using System.Text;

namespace Bankacılık2
{
    class DataBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("veri tabanına loglandı");
        }
    }
}
