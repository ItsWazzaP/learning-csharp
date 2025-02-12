using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Learning.ConsolePrinting
{
    class ConsolePrinting
    {
        static void Main(string[] args)
        {
            //Program does everything one line after another
            Console.Title = "Dumb Rectangle";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("|---|");
            Console.WriteLine("|   |");
            Console.WriteLine("|   |");
            Console.WriteLine("|---|");


            //Pauses the console so it doesn't close
            Console.ReadLine();
        }
    }
}