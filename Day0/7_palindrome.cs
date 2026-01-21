using System;
class Program {
    static void Main() {
        string s = Console.ReadLine().Replace(" ", "").ToLower();
        string r = new string(s.ToCharArray().Reverse().ToArray());
        if (s == r) Console.WriteLine("Palindrome");
        else Console.WriteLine("Not a palindrome");
    }
}
