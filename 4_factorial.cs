using System;
class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int f = 1;
        for (int i = 1; i <= n; i++) f *= i;
        Console.WriteLine(n + "! = " + f);
    }
}
