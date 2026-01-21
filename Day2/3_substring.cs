using System;

class Program
{
    static void ExtractSubstring()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        Console.Write("Enter start index: ");
        int start = int.Parse(Console.ReadLine());
        
        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());
        
        int length = end - start;
        Console.WriteLine(input.Substring(start, length));
    }
    
    static void Main(string[] args)
    {
        ExtractSubstring();
    }
}
