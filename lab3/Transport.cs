using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Transport
    {
        public TransportType Type { get; }
        public string Name { get; }
        public int Price { get; }

        public int Count { get; private set; }

        public Transport(TransportType type, string name, int price, int count)
        {
            Type = type;
            Name = name;
            Price = price;
            Count = count;
        }

        public bool HasEnough(int requested) => requested <= Count;

        public void Take(int quantity) => Count -= quantity;

        public override string ToString() => $"{Name} — {Price} руб., {Count} шт.";

    }
}