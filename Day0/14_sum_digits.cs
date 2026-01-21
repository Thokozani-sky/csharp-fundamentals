using System;

class Program {
    static void Main() {
        string number = Console.ReadLine();
        int sum = 0;
        foreach (char c in number) sum += c - '0';
        Console.WriteLine(sum);
    }
}
