using System;

class Program
{
    static void SplitAndPrint()
    {
        Console.Write("Enter comma-separated values: ");
        string input = Console.ReadLine();
        
        string[] parts = input.Split(',');
        
        for (int i = 0; i < parts.Length; i++)
        {
            Console.WriteLine(parts[i].Trim());
        }
    }
    
    static void Main(string[] args)
    {
        SplitAndPrint();
    }
}
