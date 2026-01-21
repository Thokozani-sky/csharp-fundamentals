using System;

class Program
{
    static void SumEvenNumbers()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        int sum = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
            int digit = int.Parse(input[i].ToString());
            if (digit % 2 == 0)
            {
                sum += digit;
            }
        }
        
        Console.WriteLine(sum);
    }
    
    static void Main(string[] args)
    {
        SumEvenNumbers();
    }
}
