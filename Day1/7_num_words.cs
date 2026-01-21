using System;

class Program
{
    static void NumberToWords()
    {
        Console.Write("Enter a number (0-9): ");
        int num = int.Parse(Console.ReadLine());
        
        string word = "";
        
        if (num == 0) word = "Zero";
        else if (num == 1) word = "One";
        else if (num == 2) word = "Two";
        else if (num == 3) word = "Three";
        else if (num == 4) word = "Four";
        else if (num == 5) word = "Five";
        else if (num == 6) word = "Six";
        else if (num == 7) word = "Seven";
        else if (num == 8) word = "Eight";
        else if (num == 9) word = "Nine";
        else word = "Invalid";
        
        Console.WriteLine(word);
    }
    
    static void Main(string[] args)
    {
        NumberToWords();
    }
}
