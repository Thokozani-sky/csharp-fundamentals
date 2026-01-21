using System;

class Program
{
    static void PrintUniqueElements()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }
        
        bool[] printed = new bool[numbers.Length];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (!printed[i])
            {
                Console.Write(numbers[i] + " ");
                
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        printed[j] = true;
                    }
                }
            }
        }
        
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        PrintUniqueElements();
    }
}
