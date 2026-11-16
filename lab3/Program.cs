using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
          var park = new RentalPark();
          park.PrintPark();
          park.ProcessOrder();
          park.PrintRemains();
            
        }
    }
}
