using System;
using System.Linq;
class Program {
    static void Main() {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine("Max: " + nums.Max());
    }
}
