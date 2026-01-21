using System;

class Program
{
    static void FindSecondLargest()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        
        int largest = -1;
        int secondLargest = -1;
        
        for (int i = 0; i < input.Length; i++)
        {
            int digit = int.Parse(input[i].ToString());
            
            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit > secondLargest && digit != largest)
            {
                secondLargest = digit;
            }
        }
        
        Console.WriteLine(secondLargest);
    }
    
    static void Main(string[] args)
    {
        FindSecondLargest();
    }
}
