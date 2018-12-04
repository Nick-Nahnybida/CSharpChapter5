using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumFourInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            const int MAX = 4;
            string inputString;

            for (int i = 0; i < MAX; ++i)
            {
                WriteLine("Enter a Number.");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                sum = sum + num;
            }
            WriteLine("The sum is " + sum + ".");
        }
    }
}
