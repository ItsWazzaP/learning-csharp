using System;

public class Program {
    public static void Main(string[] args) {
        string firstNumberString = Console.ReadLine();
        string secondNumberString = Console.ReadLine();

        // Use Parse to convert the numbers
        int number1 = int.Parse(firstNumberString);
        int number2 = int.Parse(secondNumberString);
        
        int result = number1 + number2;

        // Print the sum of the numbers
        Console.WriteLine(result);

        //Parse is turning one variable type into another (from what I've seen in this lecture)
        //Console.ReadLine() always gives a string, not an int or any other variable

    }
}