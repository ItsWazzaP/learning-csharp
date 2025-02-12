using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Learning.GettingUserInput
{
    class GettingUserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);
            if (ageInt >= 30)
                Console.WriteLine("You're older than I thought!");
            else
                Console.WriteLine("You're young!");

            Console.ReadLine();
        }
    }
}