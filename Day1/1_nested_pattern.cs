using System;

class Program
{
    static void PrintNestedPattern()
    {
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
    
    static void Main(string[] args)
    {
        PrintNestedPattern();
    }
}
