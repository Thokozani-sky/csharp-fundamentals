using System;

class Program
{
    static void CalculatePower()
    {
        Console.Write("Enter base: ");
        int baseNum = int.Parse(Console.ReadLine());
        
        Console.Write("Enter exponent: ");
        int exponent = int.Parse(Console.ReadLine());
        
        int result = 1;
        
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNum;
        }
        
        Console.WriteLine(result);
    }
    
    static void Main(string[] args)
    {
        CalculatePower();
    }
}
