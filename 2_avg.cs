using System;
class Program {
    static void Main() {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double z = double.Parse(Console.ReadLine());
        Console.WriteLine("Average: " + ((x + y + z) / 3).ToString("F2"));
    }
}
