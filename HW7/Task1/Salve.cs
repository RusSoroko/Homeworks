using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Salve : Drug
    {
        public Salve(string name, double price, string color) : base(name, price)
        {
            Color = color;
        }

        public string Color { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Color: {Color}");
        }

        public override void PrintWayToUse()
        {
            Console.WriteLine("Spread a thin layer on the skin");
        }
        
    }
}
