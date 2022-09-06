using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Phone
    {
        private double _weight;

        public Phone(string number, string model, double weight)
        {
            Number = number;
            Model = model;
            Weight = weight;
        }

        public string Number
        {
            get;
            set;
        }

        public string Model
        {
            get;
            private set;
        }

        public double Weight
        {
            get
            {
                return _weight;
            }
            private set
            {
                if (value < 0)
                {
                    _weight = 0;
                }
                else
                {
                    _weight = value;
                }
            }
        }
        
        public void RecieveCall(string name)
        {
            Console.WriteLine($"Вам звонит {name}");
        }
    }
}
