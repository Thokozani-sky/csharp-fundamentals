using System;

class Program
{
    static void FindMinInArray()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        int min = int.Parse(parts[0]);
        
        for (int i = 1; i < parts.Length; i++)
        {
            int num = int.Parse(parts[i]);
            if (num < min)
            {
                min = num;
            }
        }
        
        Console.WriteLine(min);
    }
    
    static void Main(string[] args)
    {
        FindMinInArray();
    }
}
