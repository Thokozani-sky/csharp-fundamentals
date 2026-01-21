using System;

class Program
{
    static void CheckStringContains()
    {
        Console.Write("Enter main string: ");
        string mainStr = Console.ReadLine();
        
        Console.Write("Enter substring to search: ");
        string subStr = Console.ReadLine();
        
        if (mainStr.Contains(subStr))
        {
            Console.WriteLine("Found");
        }
        else
        {
            Console.WriteLine("Not found");
        }
    }
    
    static void Main(string[] args)
    {
        CheckStringContains();
    }
}
