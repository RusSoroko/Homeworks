using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal interface IPaymentMethod
    {
        public bool IsPaymentPossible(double amountOfMoneyRequiredForPayment )
        {
            if (amountOfMoneyRequiredForPayment > money )
            {
                return false;
            }
            return true;
        }

        public void MakePayment(double)
        {

        }

        public void AddMoney(double)
        {

        }



    }
}
