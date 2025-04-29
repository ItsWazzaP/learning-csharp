using System;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Calculator App");
        //Better way of parsing
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;

        //Adding :Fx to the print statement determines how many decimals get printed. Handy!
        Console.WriteLine($"Sum: {sum:F2}");
        Console.WriteLine($"Difference: {difference:F2}");
        Console.WriteLine($"Product: {product:F2}");
        Console.WriteLine($"Quotient: {quotient:F2}");
    }
}