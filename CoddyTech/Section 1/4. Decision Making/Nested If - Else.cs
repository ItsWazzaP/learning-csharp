using System;

class Program {
    public static void Main(string[] args) {
        int age = int.Parse(Console.ReadLine()); // Don't change this line
        int height = int.Parse(Console.ReadLine()); // Don't change this line
        bool hasAdult = bool.Parse(Console.ReadLine()); // Don't change this line

        string status = "";
        
        // Write your code below
        if (age >= 12)
        {
            if (height > 150)
            {
                if (age < 15 && hasAdult == false)
                {
                    Console.WriteLine("Sorry, you need an adult with you");
                }
                else if (age < 15 && hasAdult == true)
                {
                    Console.WriteLine("You can ride with adult supervision!");
                }
                else
                {
                    Console.WriteLine("You can ride by yourself!");
                }
            }
            else
            {
                Console.WriteLine("Sorry, you're not tall enough");
            }
        }
        else
        {
            Console.WriteLine("Sorry, you're too young");
        }
        
        
        // Don't change below this line
        Console.WriteLine(status);
    }
}