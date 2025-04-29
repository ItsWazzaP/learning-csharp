using System;

public class Program {
    public static void Main(string[] args) {
        int wind = int.Parse(Console.ReadLine()); // Don't change this line
        string status = "unset";
        
        if (wind < 8) {
            status = "Calm";
        } else if (wind >= 8 && wind <= 31) {
            status = "Breeze";
        } else if (wind >= 32 && wind <= 63) {
            status = "Gale";
        } else {
            status = "Storm";
        }       
        // Don't change the line below
        Console.WriteLine("status = " + status);
    }
}