using System;

class Program
{
    static void PrintAsciiArt()
    {
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= size; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    
    static void Main(string[] args)
    {
        PrintAsciiArt();
    }
}
