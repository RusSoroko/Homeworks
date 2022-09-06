namespace Task2
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

            Stack<int> stack = new Stack<int>();
            
            for (int i = 0; i < n; i++)
            { 
                stack.Push(arr[i]); 
            }

            foreach (int number in stack)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();

            int sc = stack.Count;

            for (int i = 0; i < sc; i++)
            {
                Console.Write($"{stack.Pop()} ");
            }
        }
    }
}