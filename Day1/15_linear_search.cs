using System;

class Program
{
    static void LinearSearch()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        Console.Write("Enter digit to search: ");
        int target = int.Parse(Console.ReadLine());
        
        int index = -1;
        
        for (int i = 0; i < input.Length; i++)
        {
            int digit = int.Parse(input[i].ToString());
            if (digit == target)
            {
                index = i;
                break;
            }
        }
        
        Console.WriteLine(index);
    }
    
    static void Main(string[] args)
    {
        LinearSearch();
    }
}
