using System;

class Program
{
    static void FindDigitRoot()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        while (num >= 10)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            num = sum;
        }
        
        Console.WriteLine(num);
    }
    
    static void Main(string[] args)
    {
        FindDigitRoot();
    }
}
