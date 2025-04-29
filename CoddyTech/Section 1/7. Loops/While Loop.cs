using System;

public class Program {
    public static void Main(string[] args) {
        // Write your code below
        double number = double.Parse(Console.ReadLine());

        while (number >= 3.5)
        {
            number = number / 2;
        }
        Console.WriteLine(number);
    }
}