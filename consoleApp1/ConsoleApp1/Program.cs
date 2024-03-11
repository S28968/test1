
using System.Reflection;

class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Hello, World!");

        int[] tbl = { 1, 2, 3, 4 };

        foreach (int num in tbl)
        {
            //Console.WriteLine(num);
            //Console.WriteLine(num+1);
            //test Mod2
        }
        
        Console.WriteLine("test3");
        //Mod3

        float test = Avg(tbl);
        Console.WriteLine(test);

    }
    
    public static float Avg(int[] tab)
    {
        float sum = 0;
        foreach (int num in tab)
        {
            sum += num;
        }

        float result = sum/tab.Length;

        return result;

    }
}