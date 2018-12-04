using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowerCaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char input;
            do
            {
                Write("Enter a lowercase letter.");
                input = Convert.ToChar(ReadLine());

                if (char.IsLower(input))
                {
                    WriteLine("Character is lower case.");
                }
                else
                {
                    WriteLine("Character is not Lowercase.");
                }
            } while (input != '!');
        }
    }
}
