using System;

class Program
{
    static void FindDuplicates()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        
        int[] numbers = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }
        
        bool[] printed = new bool[numbers.Length];
        bool foundDuplicate = false;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (printed[i]) continue;
            
            int count = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }
            }
            
            if (count > 1)
            {
                Console.Write(numbers[i] + " ");
                foundDuplicate = true;
                
                for (int k = 0; k < numbers.Length; k++)
                {
                    if (numbers[k] == numbers[i])
                    {
                        printed[k] = true;
                    }
                }
            }
        }
        
        if (foundDuplicate)
        {
            Console.WriteLine();
        }
    }
    
    static void Main(string[] args)
    {
        FindDuplicates();
    }
}
