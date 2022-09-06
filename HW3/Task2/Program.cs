namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = int.Parse(Console.ReadLine());

            if (a > 100 && b > 100)
                Console.WriteLine("Каждое из чисел А и В больше 100");
            if (a % 2 == 0 ^ b % 2 == 0)
                Console.WriteLine("Только одно из чисел А и В четное");
            if (a > 0 || b > 0)
                Console.WriteLine("Одно из чисел А и В положительное");
            if (a % 3 == 0 && b % 3 == 0 && c % 3 == 0)
                Console.WriteLine("Каждое из чисел А, В, С кратно трем");
            if (((a < 50 ^ b < 50) && c >= 50) || (a >= 50 && b >= 50 && c < 50))
                Console.WriteLine("Только одно из чисел А, В и С меньше 50");
            if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("Одно из чисел А, В, С отрицательное");
            Console.WriteLine("Для коммита");

            Console.ReadKey();


        }
    }
}