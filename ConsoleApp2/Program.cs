public class Program
{
    public static void Hello(string name)
    {
        Console.WriteLine("Hello, " + name);
    }  

    public static void Main()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Hello(name);
    }
}a