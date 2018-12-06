using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = -1;
            do
            {
                num = num + 2;
                WriteLine(num);
            }
            while (num != 99);
        }
    }
}
