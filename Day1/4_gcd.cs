using System;

class Program
{
    static void FindGCD()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        Console.WriteLine(a);
    }
    
    static void Main(string[] args)
    {
        FindGCD();
    }
}
