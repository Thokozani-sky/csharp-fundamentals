using System;

class Program
{
    static void FindLCM()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        int a = num1;
        int b = num2;
        
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        int gcd = a;
        int lcm = (num1 * num2) / gcd;
        
        Console.WriteLine(lcm);
    }
    
    static void Main(string[] args)
    {
        FindLCM();
    }
}
