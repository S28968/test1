
class Program
{
    public static void Main(string[]args)
    {
        Console.WriteLine("Hello, World!");

        int[] tbl = { 1, 2, 3, 4 };

        foreach (int num in tbl)
        {
            Console.WriteLine(num);
            Console.WriteLine(num+1);
            //test Mod2
        }
        
        Console.WriteLine("test3");
    }
}