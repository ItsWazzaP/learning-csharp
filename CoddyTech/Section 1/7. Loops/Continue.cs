//The continue statement stops the current iteration and continues to the next iteration. Basically skips 1 step.

using System;

public class Program {
    public static void Main(string[] args) {
        for (int i = 1; i <= 20; i++) {
            // Write your code here

            if (i % 2 != 0)
            {
                continue;
            }

            // Printing numbers
            Console.WriteLine(i);
        }
    }
}