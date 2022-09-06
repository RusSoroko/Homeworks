namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(21, -28);
            Fraction fraction2 = new Fraction(4, 3);

            Console.Write("Дробь 1: ");
            Fraction.Print(fraction1);

            Console.Write("Дробь 2: ");
            Fraction.Print(fraction2);

            Console.Write("Сумма: ");
            Fraction.Print(Fraction.Sum(fraction1, fraction2));

            Console.Write("Вычитание: ");
            Fraction.Print(Fraction.Subtraction(fraction1, fraction2));

            Console.Write("Деление: ");
            Fraction.Print(Fraction.Division(fraction1, fraction2));

            Console.Write("Умножение: ");
            Fraction.Print(Fraction.Multiplication(fraction1, fraction2));

            Console.Write("Десятичное прдеставление дробей: {0:F2}; {1:F2}", Fraction.ToDecimal(fraction1), Fraction.ToDecimal(fraction2));
            
        }
    }
}