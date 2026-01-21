using System;

class Program
{
    static void ReverseNumber()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        int reversed = 0;
        
        while (num > 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }
        
        Console.WriteLine(reversed);
    }
    
    static void Main(string[] args)
    {
        ReverseNumber();
    }
}
