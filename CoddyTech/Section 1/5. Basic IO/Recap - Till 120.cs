using System;

public class Program {
    public static void Main(string[] args) {
        // Write your code below
        //It can probably be done like   int years = int.Parse(Console.ReadLine());, won't waste my Coddy energy tho
        string years = Console.ReadLine();
        int years_int = int.Parse(years);

        int result = 120 - years_int;
        Console.WriteLine($"{result} years till 120");
    }
}