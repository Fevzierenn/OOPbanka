using System;
using System.Collections.Generic;
using System.Text;

namespace Bankacılık2
{
    class SMSLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("sms logger servisi çalıştı");
        }
    }
}
