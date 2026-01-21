using System;

class Program
{
    static void CheckArmstrong()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        int original = num;
        int sum = 0;
        int digits = 0;
        
        int temp = num;
        while (temp > 0)
        {
            digits++;
            temp /= 10;
        }
        
        temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            int power = 1;
            for (int i = 0; i < digits; i++)
            {
                power *= digit;
            }
            sum += power;
            temp /= 10;
        }
        
        if (sum == original)
        {
            Console.WriteLine("Armstrong number");
        }
        else
        {
            Console.WriteLine("Not an Armstrong number");
        }
    }
    
    static void Main(string[] args)
    {
        CheckArmstrong();
    }
}
