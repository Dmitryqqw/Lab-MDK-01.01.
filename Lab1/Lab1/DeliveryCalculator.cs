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

        internal static double CalculateDeliveryCost(object orderCost, object distance, object hour)
        {
            throw new NotImplementedException();
        }

        static double CalculateDeliveryCost(double orderCost, double distance, int hour)
        {
            const double basePrice = 150;
            const double additionalKmPrice = 50;
            const double peakMultiplier = 1.3;

            double totalPrice = 0;

            if (orderCost >= 2000)
            {
                totalPrice = 0;
            }
            else
            {
                totalPrice = basePrice;
                if (distance > 3)
                {
                    totalPrice += (distance - 3) * additionalKmPrice;
                }
            }

            if (IsPeakHour(hour))
            {
                totalPrice *= peakMultiplier;
            }

            return Math.Round(totalPrice);
        }

       

    }
}
