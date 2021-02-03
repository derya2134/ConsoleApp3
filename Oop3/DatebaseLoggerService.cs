using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class DatebaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı");
        }
    }
}
