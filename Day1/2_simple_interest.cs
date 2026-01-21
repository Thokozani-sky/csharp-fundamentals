using System;

class Program
{
    static void CalculateSimpleInterest()
    {
        Console.Write("Enter principal: ");
        double principal = double.Parse(Console.ReadLine());
        
        Console.Write("Enter rate: ");
        double rate = double.Parse(Console.ReadLine());
        
        Console.Write("Enter time: ");
        double time = double.Parse(Console.ReadLine());
        
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine(simpleInterest.ToString("F2"));
    }
    
    static void Main(string[] args)
    {
        CalculateSimpleInterest();
    }
}
