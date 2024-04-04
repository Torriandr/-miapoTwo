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
    
    public static void Main()
    {
        Console.WriteLine("Введите любую строку:");
        char[] str = Console.ReadLine().ToCharArray();
        Sort(str);
        Console.WriteLine(str);
    }
}