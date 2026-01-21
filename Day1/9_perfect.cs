using System;

class Program
{
    static void CheckPerfectNumber()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        int sum = 0;
        
        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }
        
        if (sum == num)
        {
            Console.WriteLine("Perfect number");
        }
        else
        {
            Console.WriteLine("Not a perfect number");
        }
    }
    
    static void Main(string[] args)
    {
        CheckPerfectNumber();
    }
}
