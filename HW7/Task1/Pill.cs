using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Pill : Drug
    {
        public Pill(string name, double price, bool isPrescription) : base(name, price)
        {
            IsPrescription = isPrescription;
        }

        public bool IsPrescription { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Is prescription: {IsPrescription}");
        }

        public override void PrintWayToUse()
        {
            Console.WriteLine("Take the pill with water after a meal");
        }
    }
}
