using System;

class Program
{
    static void PrintFibonacciUpTo()
    {
        Console.Write("Enter limit: ");
        int limit = int.Parse(Console.ReadLine());
        
        int a = 0;
        int b = 1;
        
        while (a <= limit)
        {
            Console.Write(a + " ");
            int next = a + b;
            a = b;
            b = next;
        }
        
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        PrintFibonacciUpTo();
    }
}
