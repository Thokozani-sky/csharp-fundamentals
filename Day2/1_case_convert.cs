using System;

class Program
{
    static void ConvertToLowercase()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(input.ToLower());
    }
    
    static void Main(string[] args)
    {
        ConvertToLowercase();
    }
}
