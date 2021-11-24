// See https://aka.ms/new-console-template for more information

class Program
{
    static Func<int, string> PrintNumberName = X =>
    {
        switch (X)
        {
            case 1:
                return "One";
                case 2:
                return "Two";
                case 3:
                return "Three";
            default:
                throw new ArgumentOutOfRangeException();
        }
    };

    static void Main()
    {
        Console.WriteLine(PrintNumberName(2));
    }
}
