using System;

class Program
{
    static void CalculateArrayStats()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        int sum = 0;
        int count = parts.Length;
        
        for (int i = 0; i < count; i++)
        {
            sum += int.Parse(parts[i]);
        }
        
        double average = (double)sum / count;
        
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average.ToString("F2"));
    }
    
    static void Main(string[] args)
    {
        CalculateArrayStats();
    }
}
