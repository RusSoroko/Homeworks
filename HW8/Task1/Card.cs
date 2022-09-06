using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Card : IPaymentMethod
    {
        string _cardNumber;

        public double amountOfMoney { get; set; }

    }
}
