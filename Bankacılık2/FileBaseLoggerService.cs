using System;

namespace Bankacılık2
{
    class FileBaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("dosyaya loglandı");
        }
    }
}
