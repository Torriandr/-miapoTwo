public class Program
{
    public static void Sort(char[] str)
    {
        for (int i = 0; i < str.Length - 1; ++i)
        {
            for (int j = i + 1; j < str.Length; ++j)
            {
                if (String.CompareOrdinal(str[i].ToString(), str[j].ToString()) > 0)
                {
                    (str[i], str[j]) = (str[j], str[i]);
                }
            }
        }
    }
    
    public static void Compare(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine("Первое больше второго");
        }
        else if (a < b)
        {
            Console.WriteLine("Первое меньше второго");
        }
        else
        {
            Console.WriteLine("Числа равны");
        }
    }
   
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
        Compare(a, b);
        Sum(a, b);
        Console.WriteLine("Введите любую строку:");
        char[] str = Console.ReadLine().ToCharArray();
        Sort(str);
        Console.WriteLine(str);
    }
}