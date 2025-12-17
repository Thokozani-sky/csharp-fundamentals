using System;

class Program {
    static void Main() {
        string[] parts = Console.ReadLine().Split(' ');
        bool ascending = true;
        for (int i = 1; i < parts.Length; i++) {
            if (int.Parse(parts[i]) < int.Parse(parts[i-1])) {
                ascending = false;
                break;
            }
        }
        Console.WriteLine(ascending ? "Ascending" : "Not ascending");
    }
}
