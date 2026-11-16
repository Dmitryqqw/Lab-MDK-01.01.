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
        private int CheckAvailability(int[] ordered)
        {
            for (int i = 0; i < _transports.Length; i++)
                if (!_transports[i].HasEnough(ordered[i]))
                    return i;
            return -1;
        }

        private int CalculateCost(int[] ordered)
        {
            int total = 0;
            for (int i = 0; i < _transports.Length; i++)
                total += _transports[i].Price * ordered[i];
            return total;
        }

        private void ApplyOrder(int[] ordered)
        {
            for (int i = 0; i < _transports.Length; i++)
                _transports[i].Take(ordered[i]);
        }

        private int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value))
                    return value;
                Console.WriteLine("Ошибка: введите целое число.");
            }
        }

        private int ReadTransportNumber()
        {
            while (true)
            {
                int num = ReadInt("Введите номер транспорта (0 — конец заказа): ");
                if (num == 0) return 0;
                if (num >= 1 && num <= _transports.Length) return num;
                Console.WriteLine($"Ошибка: номер должен быть от 1 до {_transports.Length} или 0.");
            }
        }

        // Добавил метод ReadQuantity для чтения количества
        private int ReadQuantity()
        {
            while (true)
            {
                int qty = ReadInt("Введите количество: ");
                if (qty >= 0) return qty;
                Console.WriteLine("Ошибка: количество не может быть отрицательным.");
            }
        }
    }
}