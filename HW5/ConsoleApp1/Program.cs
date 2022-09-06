Console.WriteLine(Days.Monday);
Console.WriteLine((Days)1);
string response = Console.ReadLine();
Days day = (Days)Enum.Parse(typeof(Days), response);
Days day1 = Enum.Parse<Days>(response);
string[] names = Enum.GetNames(typeof(Days));
int intResponse = int.Parse(response);
Days enteredDay = (Days)intResponse;
switch (enteredDay)
{
    case Days.Monday:
        {
            Console.WriteLine("Monday");
            break;
        }
    case Days.Tuesday:
        {
            Console.WriteLine("Tuesday");
            break;
        }
    case Days.Wednesday:
        {
            Console.WriteLine("Wednesday");
            break;
        }
    case Days.Sunday:
        {
            Console.WriteLine("Sunday");
            break;
        }
}
enum Days : long
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 999
}