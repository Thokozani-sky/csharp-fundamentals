using System;

class Program
{
    static void PrintStringLength()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(input.Length);
    }
    
    static void Main(string[] args)
    {
        PrintStringLength();
    }
}
