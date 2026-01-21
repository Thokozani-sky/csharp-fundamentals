using System;

class Program
{
    static void CategorizeAge()
    {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        
        string category;
        
        if (age >= 0 && age <= 12)
        {
            category = "Child";
        }
        else if (age >= 13 && age <= 19)
        {
            category = "Teen";
        }
        else if (age >= 20 && age <= 59)
        {
            category = "Adult";
        }
        else
        {
            category = "Senior";
        }
        
        Console.WriteLine(category);
    }
    
    static void Main(string[] args)
    {
        CategorizeAge();
    }
}
