using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Learning.WorkingWithNumbers
{
    class WorkingWithNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 8.5); //C# distinguishes between whole & decimal nums
            Console.WriteLine(5 % 2); //5 mod 2, gives a remainder, 5/2=2 w/ a remainder of 1
            Console.WriteLine(5 + 3 * 0.5); //C# does the operations in proper order, 3*0.5 first

            Console.WriteLine("");

            Console.WriteLine(5 / 2); //Gives a whole number (integer) back instead of a decimal
            Console.WriteLine(5 / 2.0); //This gives a decimal back

            Console.WriteLine("");

            int num = 6;
            num++; //Adds +1, -- does -1
            Console.WriteLine(num);

            Console.WriteLine("");

            Console.WriteLine(Math.Sqrt(num)); //Calls the Math function/method
            Console.WriteLine(Math.Pow(num, 3)); //num^3
            int num2 = 23;
            Console.WriteLine(Math.Max(num, num2)); //Gives out which one's max
        }
    }
}