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
        private static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}