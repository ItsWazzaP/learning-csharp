using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            string characterName = "Johninator";
            int characterAge = 20;

            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            //You can modify the value of a variable after its set like this:
            characterName = "Michael";
            characterAge = 35;
            Console.WriteLine("He really likes the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);
        }
    }
}