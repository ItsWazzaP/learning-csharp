using System;

public class Program {
    public static void Main(string[] args) {
        int number = int.Parse(Console.ReadLine());
        string result = "";
        
        // Write your code below
        result = (number > 0) ? "positive" : (number < 0) ? "negative" : "zero"; // Annoying and ugly one line IF-ELSE statement
        
        Console.WriteLine("The number is " + result);
    }
}