namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pill pill1 = new Pill("Aspirin", 3.50, false);
            Pill pill2 = new Pill("Valium", 45.36, true);

            Salve salve1 = new Salve("Fastum gel", 23.46, "white");
            Salve salve2 = new Salve("Wang Prom Green Balm", 51, "green");

            Syrup syrup1 = new Syrup("Altei", 3.44, "herbal");
            Syrup syrup2 = new Syrup("Ambroviks", 7.10, "pineapple");

            pill1.Print();
            Console.WriteLine();

            salve1.Print();
            Console.WriteLine();

            syrup1.Print();
            Console.WriteLine();

            Drug[] drugs = new Drug[]
            {
                pill1,
                pill2,
                salve1,
                salve2,
                syrup1,
                syrup2
            };

            foreach (Drug drug in drugs)
            {
                drug.Print();
                drug.PrintWayToUse();
                Console.WriteLine();
            }

        }
    }
}