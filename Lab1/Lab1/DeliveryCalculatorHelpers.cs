using System;

namespace Lab1
{
    internal static class DeliveryCalculatorHelpers
    {

        public static double CalculateDeliveryCost(double orderCost, double distance, int hour)
        {
            const double basePrice = 150;
            const double additionalKmPrice = 50;
            const double peakMultiplier = 1.3;

            double totalPrice;
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

        internal static double CalculateDeliveryCost(object orderCost, object distance, object hour)
        {
            throw new NotImplementedException();
        }
    }
}