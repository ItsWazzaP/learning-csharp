using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Learning.WorkingWithStrings
{
    class WorkingWithStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giraffe\nAcademy"); //New line
            Console.WriteLine("Giraffe\"Academy"); //Printing "

            string phrase = "Giraffe Academy";
            Console.WriteLine("The phrase is " + phrase.Length + " characters long");
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase[0]); //Prints out what the 0 (1st) character is. If [2] prints the 3rd
            Console.WriteLine(phrase.IndexOf("Academy")); //At what index position does Academy start
            Console.WriteLine(phrase.IndexOf('f'));
            Console.WriteLine(phrase.IndexOf('z')); //Will give out -1, means there's not an index of that there
            Console.WriteLine(phrase.Substring(8, 3)); //Grabs characters from index pos 8 and forwards, "," signifies how many characters you wanna grab
        }
    }
}