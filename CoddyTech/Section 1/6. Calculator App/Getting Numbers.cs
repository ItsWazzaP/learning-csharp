using System;

public class Program {
    public static void Main(string[] args) {
        //Check Recap - Till 120.cs for a better parsing method
        //Basic Operations.cs also has one
        Console.WriteLine("Calculator App");
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();

        float num1_converted = float.Parse(num1);
        float num2_converted = float.Parse(num2);

        Console.WriteLine(num1_converted);
        Console.WriteLine(num2_converted);
    }
}