using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double orderCost = DeliveryCalculator.ReadPositiveDouble("Введите стоимость заказа (руб): ");
            double distance = DeliveryCalculator.ReadPositiveDouble("Введите расстояние доставки (км): ");
            int hour = DeliveryCalculator.ReadHour("Введите время заказа (час, 0-23): ");
        }
        private static object orderCost;
        private static object distance;
        private static object hour;

        double deliveryCost = DeliveryCalculator.CalculateDeliveryCost(orderCost, distance, hour);
        double totalAmount = orderCost + deliveryCost;
    }
}
