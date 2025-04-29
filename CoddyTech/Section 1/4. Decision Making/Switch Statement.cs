using System;

public class Program {
    public static void Main(string[] args) {
        int month = int.Parse(Console.ReadLine());
        string season = "";
        
        // Write your code below

        switch (month)
        {
        case 12:
        case 1:
        case 2:
            season = "Winter";
            break;
        
        case 3:
        case 4:
        case 5:
            season = "Spring";
            break;
        
        case 6:
        case 7:
        case 8:
            season = "Summer";
            break;
        
        case 9:
        case 10:
        case 11:
            season = "Autumn";
            break;
        
        default:
            break;

        }
        
        Console.WriteLine(season);
    }
}