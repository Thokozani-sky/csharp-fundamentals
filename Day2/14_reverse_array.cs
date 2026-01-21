using System;

class Program
{
    static void ReverseArray()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }
        
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i]);
            if (i > 0)
            {
                Console.Write(" ");
            }
        }
        
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        ReverseArray();
    }
}
