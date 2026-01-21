using System;

class Program
{
    static void PrintDigitFrequency()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        int[] frequency = new int[10];
        
        for (int i = 0; i < input.Length; i++)
        {
            int digit = int.Parse(input[i].ToString());
            frequency[digit]++;
        }
        
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine(i + " appears " + frequency[i] + " times");
            }
        }
    }
    
    static void Main(string[] args)
    {
        PrintDigitFrequency();
    }
}
