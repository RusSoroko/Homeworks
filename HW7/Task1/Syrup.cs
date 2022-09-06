using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Syrup : Drug
    {
        public Syrup(string name, double price, string taste) : base(name, price)
        {
           Taste = taste;
        }

        public string Taste { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Taste: {Taste}");
        }

        public override void PrintWayToUse()
        {
            Console.WriteLine("Take one spoon before bed");
        }
    }
}
