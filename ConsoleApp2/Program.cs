public class Program
{
    public static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
   
    public static void Hello(string name)
    {
        Console.WriteLine("Hello, " + name);
    }  

    public static void Main()
    {
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Hello(name);
      
        int a = 0;
        int b = 0;
        Console.Write("Введите первое число: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = int.Parse(Console.ReadLine());
        Sum(a, b);
    }
}