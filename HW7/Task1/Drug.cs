using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal abstract class Drug
    {
        public Drug(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Name: {0}; Price: {1:F2}", Name, Price );
        }

        public abstract void PrintWayToUse();


    }
}
