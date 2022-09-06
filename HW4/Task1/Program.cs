namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Console.WriteLine("Введите элементы массива: ");

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 1; i < n;)
            {
                sum += arr[i];
                i += 2;
            }
            Console.WriteLine($"Сумма элементов массива с нечетными индексами: {sum}");

            int min = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Минимальный элемент в массиве: {min}");

            Console.ReadKey();
        }

    }
}