using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Learning.CalculatorProgram
{
    class CalculatorProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            //Really simple, only addition
            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}