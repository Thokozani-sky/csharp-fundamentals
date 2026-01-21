using System;

class Program
{
    static void BubbleSort()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        int[] digits = new int[input.Length];
        
        for (int i = 0; i < input.Length; i++)
        {
            digits[i] = int.Parse(input[i].ToString());
        }
        
        for (int i = 0; i < digits.Length - 1; i++)
        {
            for (int j = 0; j < digits.Length - i - 1; j++)
            {
                if (digits[j] > digits[j + 1])
                {
                    int temp = digits[j];
                    digits[j] = digits[j + 1];
                    digits[j + 1] = temp;
                }
            }
        }
        
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        BubbleSort();
    }
}
