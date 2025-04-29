using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Learning.DataTypes
{
    class DataTypes
    {
        static void Main(string[] args)
        {
            //Letters
            string phrase = "ASync Corporation";
            char grade = 'B';

            //Numbers
            int wholeNumber = 14;
            float LeastAccurateDecimalNumber = 42.33;
            double MediumAccurateDecimalNumber = 23.122; //Usually fine for many case scenarios
            decimal MostAccurateDecimalNumber = 97.86;

            //True-False
            bool isCSharp = true;
            bool isJava = false;
        }
    }
}