using System;

class Program
{
    static void CountOddNumbers()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        int count = 0;
        
        for (int i = 0; i < parts.Length; i++)
        {
            int num = int.Parse(parts[i]);
            if (num % 2 != 0)
            {
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
    
    static void Main(string[] args)
    {
        CountOddNumbers();
    }
}
