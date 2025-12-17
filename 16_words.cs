using System;

class Program {
    static void Main() {
        string text = Console.ReadLine();
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine(words.Length);
    }
}
