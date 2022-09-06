namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            a = -a;
            Console.WriteLine($"Противоположное число: {a}");
            Console.ReadKey();
        }
    }
}