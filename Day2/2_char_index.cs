using System;

class Program
{
    static void GetCharacterAtIndex()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        Console.Write("Enter index: ");
        int index = int.Parse(Console.ReadLine());
        
        if (index >= 0 && index < input.Length)
        {
            Console.WriteLine(input[index]);
        }
        else
        {
            Console.WriteLine("Invalid index");
        }
    }
    
    static void Main(string[] args)
    {
        GetCharacterAtIndex();
    }
}
