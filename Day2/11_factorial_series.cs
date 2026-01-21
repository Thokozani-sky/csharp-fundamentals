using System;

class Program
{
    static void PrintFactorialSeries()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= n; i++)
        {
            int factorial = 1;
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }
            Console.WriteLine(i + "! = " + factorial);
        }
    }
    
    static void Main(string[] args)
    {
        PrintFactorialSeries();
    }
}
