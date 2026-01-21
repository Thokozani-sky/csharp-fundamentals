using System;

class Program {
    static void Main() {
        string text = Console.ReadLine().ToLower();
        int count = 0;
        foreach (char c in text) {
            if (c=='a'||c=='e'||c=='i'||c=='o'||c=='u') count++;
        }
        Console.WriteLine(count);
    }
}
