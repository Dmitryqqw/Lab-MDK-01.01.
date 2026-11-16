using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class DeliveryCalculator
    {
        public static double ReadPositiveDouble(string message)
        {
            double value;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (double.TryParse(input, out value) && value >= 0)
                    return value;

                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            }
        }

        public static int ReadHour(string message)
        {
            int hour;
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out hour) && hour >= 0 && hour <= 23)
                    return hour;

                Console.WriteLine("Некорректный ввод. Введите число от 0 до 23.");
            }
        }

    }
}
