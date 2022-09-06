namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f = 0;
            do
            {
                Console.Write("Введите число: ");
                int a = int.Parse(Console.ReadLine());
                int res = 1;
                for (int i = 2; i <= a; i++)
                {
                    res *= i;
                }
                Console.WriteLine($"Факториал {a} равен: {res}");
                Console.WriteLine("0 - ещё раз");
                f = int.Parse(Console.ReadLine());
            }
            while (f == 0);
            Console.ReadKey();
        }
    }
}