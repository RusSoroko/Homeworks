namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество столбов: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите расстояние между столбами (в м): ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите ширину столба (в см): ");
            int c = int.Parse(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                b = b * 100 * (a - 1);
                c = c * (a - 2);
                Console.WriteLine($"Расстояние между первым и последним столбом в см: {b + c}");
            }
            Console.ReadKey();
        }
    }
}