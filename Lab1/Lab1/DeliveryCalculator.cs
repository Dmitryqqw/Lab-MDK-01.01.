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
    }
}
