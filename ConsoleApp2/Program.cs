public class Program
{
    public static void Sum(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static void Main()
    {
        int a = 0;
        int b = 0;
        Console.Write("Введите первое число: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = int.Parse(Console.ReadLine());
        Sum(a, b);
    }
}