using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DisplayMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    if (a == 0)
                    {
                        Write("{0}\t", a);
                    }
                    else
                    {
                        Write("{0}\t", a * b);
                    }
                }
                WriteLine();
            }

            ReadLine();
        }
    }
}
