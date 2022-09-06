namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите операцию (+,-,/,*) : ");
            string oper = Console.ReadLine();
            switch (oper)
            {
                case "+":
                    Console.WriteLine($"Результат: {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {a - b}");
                    break;
                case "/":
                    Console.WriteLine($"Результат: {a / b}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {a * b}");
                    break;
                default:
                    Console.WriteLine("Неверная операция!");
                    break;
            }
            Console.ReadKey();
        }
    }
}