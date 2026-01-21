using System;

class Program
{
    static void SumOddNumbers()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        int sum = 0;
        
        for (int i = 0; i < parts.Length; i++)
        {
            int num = int.Parse(parts[i]);
            if (num % 2 != 0)
            {
                sum += num;
            }
        }
        
        Console.WriteLine(sum);
    }
    
    static void Main(string[] args)
    {
        SumOddNumbers();
    }
}
