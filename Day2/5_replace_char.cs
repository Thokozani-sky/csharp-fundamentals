using System;

class Program
{
    static void ReplaceCharacter()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        
        Console.Write("Enter character to replace: ");
        char oldChar = Console.ReadLine()[0];
        
        Console.Write("Enter replacement character: ");
        char newChar = Console.ReadLine()[0];
        
        string result = input.Replace(oldChar, newChar);
        Console.WriteLine(result);
    }
    
    static void Main(string[] args)
    {
        ReplaceCharacter();
    }
}
