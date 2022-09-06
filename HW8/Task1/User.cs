using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class User
    {
        public Dictionary<string, IPaymentMethod> paymentMethods { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int ID { get; set; }

    }
}
