using System;

public class Program {
    public static void Main(string[] args) {
        // Write your code below
        string string_input = Console.ReadLine();
        int int_input = int.Parse(string_input);

        if (int_input == 1)
        {
            Console.WriteLine("T");
        }
        else
        {
            Console.WriteLine("F");
        }
        //No error handling or whatever has been added to any programs just yet, probably won't too unless it's a lecture.
    }
}