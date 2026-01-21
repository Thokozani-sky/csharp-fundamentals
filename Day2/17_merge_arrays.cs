using System;

class Program
{
    static void MergeArrays()
    {
        Console.Write("Enter first array (space-separated): ");
        string input1 = Console.ReadLine();
        string[] parts1 = input1.Split(' ');
        
        Console.Write("Enter second array (space-separated): ");
        string input2 = Console.ReadLine();
        string[] parts2 = input2.Split(' ');
        
        int[] array1 = new int[parts1.Length];
        for (int i = 0; i < parts1.Length; i++)
        {
            array1[i] = int.Parse(parts1[i]);
        }
        
        int[] array2 = new int[parts2.Length];
        for (int i = 0; i < parts2.Length; i++)
        {
            array2[i] = int.Parse(parts2[i]);
        }
        
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write(array1[i] + " ");
        }
        
        for (int i = 0; i < array2.Length; i++)
        {
            Console.Write(array2[i]);
            if (i < array2.Length - 1)
            {
                Console.Write(" ");
            }
        }
        
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        MergeArrays();
    }
}
