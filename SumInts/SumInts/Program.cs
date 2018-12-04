using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            string inputString;

            do
            {
                WriteLine("Enter a number.");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                sum = sum + num;
                WriteLine("The ongoing sum is " + sum + ". Enter 999 to exit the loop.");
            } while (num != 999);
        }
    }
}
