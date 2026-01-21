using System;

class Program
{
    static void ValidatePassword()
    {
        Console.Write("Enter password: ");
        string password = Console.ReadLine();
        
        if (password.Length >= 8)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
    
    static void Main(string[] args)
    {
        ValidatePassword();
    }
}
