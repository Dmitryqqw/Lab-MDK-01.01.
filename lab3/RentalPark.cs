using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class RentalPark
    {
        private readonly Transport[] _transports;

    public RentalPark()
        {
            _transports = new[]
            {
                new Transport(TransportType.Велосипед, "велосипед", 1200, 12),
                new Transport(TransportType.Самокат,    "самокат",    700, 20),
                new Transport(TransportType.Ролики,     "ролики",     450, 15),
                new Transport(TransportType.Лыжи,       "лыжи",      1600,  8),
                new Transport(TransportType.Скейтборд,  "скейтборд",  950, 10)
            };
        }

        public void PrintPark()
        {
            Console.WriteLine("Парк проката:");
            for (int i = 0; i < _transports.Length; i++)
                Console.WriteLine($"{i + 1}. {_transports[i]}");
        }

        public void PrintRemains()
        {
            Console.Write("Осталось транспорта: ");
            for (int i = 0; i < _transports.Length; i++)
            {
                Console.Write($"{_transports[i].Name} {_transports[i].Count}");
                if (i < _transports.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}