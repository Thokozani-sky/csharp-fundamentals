using System;

class Program
{
    static void CompareStrings()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();
        
        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();
        
        if (str1.ToLower() == str2.ToLower())
        {
            Console.WriteLine("Strings are equal");
        }
        else
        {
            Console.WriteLine("Strings are not equal");
        }
    }
    
    static void Main(string[] args)
    {
        CompareStrings();
    }
}
