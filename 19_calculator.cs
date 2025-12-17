using System;

class Program {
    static void Main() {
        double a = double.Parse(Console.ReadLine());
        char op = char.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (op == '+') Console.WriteLine(a + b);
        else if (op == '-') Console.WriteLine(a - b);
        else if (op == '*') Console.WriteLine(a * b);
        else if (op == '/') Console.WriteLine((a / b).ToString("F2"));
    }
}
