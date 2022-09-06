namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone("1234567", "Nokia", 56.33);
            Phone phone2 = new Phone("7654321", "Samsung", -56.33);

            Console.WriteLine($"Номер: {phone1.Number}, модель: {phone1.Model}, вес: {phone1.Weight}");
            Console.WriteLine($"Номер: {phone2.Number}, модель: {phone2.Model}, вес: {phone2.Weight}");

            phone1.Number = "0123456";
            //phone1.Model = "Apple";
            //phone1.Weight = 3.98;

            phone2.RecieveCall("Alex");
        }
    }
}