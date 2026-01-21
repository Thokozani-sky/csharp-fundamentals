using System;

class Program
{
    static void TrimSpaces()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(input.Trim());
    }
    
    static void Main(string[] args)
    {
        TrimSpaces();
    }
}
