namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            for (int i = a; i <= b; i++)
            {
                Console.Write($"{i} ");
            }
            Console.ReadKey();
        }
    }
}