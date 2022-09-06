using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Fraction
    {
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            var nod = Fraction.Nod(numerator, denominator);
            Numerator = numerator / nod;
            Denominator = denominator / nod;
        }

        public int Numerator { get; set; }
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if (value < 0)
                {
                    _denominator = Math.Abs(value);
                }
                else
                {
                    _denominator = value;
                }
            }
        }

        internal static int Nod(int numerator, int denomirator)
        {
            numerator = Math.Abs(numerator);
            denomirator = Math.Abs(denomirator);
            while (denomirator != 0 && numerator != 0)
            {
                if (numerator % denomirator > 0)
                {
                    var temp = numerator;
                    numerator = denomirator;
                    denomirator = temp % denomirator;
                }
                else
                {
                    break;
                }
            }
            if (denomirator != 0 && numerator != 0)
            {
                return denomirator;
            }
            return 1;
        }

        internal static void Print(Fraction fraction)
        {
            Console.WriteLine($"{fraction.Numerator}/{fraction.Denominator}");
        }

        internal static Fraction Sum(Fraction fraction1, Fraction fraction2)
        {
            var result = new Fraction(fraction1.Numerator * fraction2.Denominator + fraction2.Numerator * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator);
            return result;
        }

        internal static Fraction Subtraction(Fraction fraction1, Fraction fraction2)
        {
            var result = new Fraction(fraction1.Numerator * fraction2.Denominator - fraction2.Numerator * fraction1.Denominator, fraction1.Denominator * fraction2.Denominator);
            return result;
        }

        internal static Fraction Multiplication(Fraction fraction1, Fraction fraction2)
        {
            var result = new Fraction(fraction1.Numerator * fraction2.Numerator, fraction1.Denominator * fraction2.Denominator);
            return result;
        }

        internal static Fraction Division(Fraction fraction1, Fraction fraction2)
        {
            var result = new Fraction(fraction1.Numerator * fraction2.Denominator, fraction1.Denominator * fraction2.Numerator);
            return result;
        }

        internal static double ToDecimal(Fraction fraction)
        {
            return (double)fraction.Numerator / (double)fraction.Denominator;
        }
    }
}
