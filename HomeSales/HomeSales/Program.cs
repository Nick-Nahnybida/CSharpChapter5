using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{

    class Program
    {
        

        static void Main(string[] args)
        {
            double danielleTotal = 0;
            double danielleSale = 0;
            double edwardTotal = 0;
            double edwardSale = 0;
            double francisTotal = 0;
            double francisSale = 0;
            double grandTotal = 0;
            string input;

            do
            {
                WriteLine("Please enter the salesperson's initial >>>>> ");
                input = ReadLine();

                if (input == "d" || input == "D")
                {
                    WriteLine("Enter the amount of the sale");
                    danielleSale = Convert.ToDouble(ReadLine());
                    danielleTotal = danielleSale + danielleTotal;
                }
                else if (input == "e" || input == "E")
                {
                    WriteLine("Enter the amount of the sale");
                    edwardSale = Convert.ToDouble(ReadLine());
                    edwardTotal = edwardSale + edwardTotal;
                }
                else if (input == "f" || input == "F")
                {
                    WriteLine("Enter the amount of the sale");
                    francisSale = Convert.ToDouble(ReadLine());
                    francisTotal = francisSale + francisTotal;
                }
                else if (input == "z" || input == "Z") {
                    grandTotal = danielleTotal + edwardTotal + francisTotal;
                }
                else
                {
                    WriteLine("Invalid initial. Please enter a valid initial.");
                }
              
            } while (input != "z");
            if (danielleTotal > edwardTotal && danielleTotal > francisTotal)
            {
                WriteLine("Danielle is the winner with a total of " + danielleTotal.ToString("C") + " in sales");
                WriteLine("Edward had a total of " + edwardTotal.ToString("C") + " in sales");
                WriteLine("Francis had a total of " + francisTotal.ToString("C") + " in sales");
                WriteLine("The overall sales were " + francisTotal.ToString("C"));
            }
            else if (edwardTotal > danielleTotal && edwardTotal > francisTotal)
            {
                WriteLine("Edward is the winner with a total of " + edwardTotal.ToString("C") + " in sales");
                WriteLine("Francis had a total of " + francisTotal.ToString("C") + " in sales");
                WriteLine("Danielle had a total of " + danielleTotal.ToString("C") + " in sales");
                WriteLine("The overall sales were " + francisTotal.ToString("C"));
            }
            else if (francisTotal > danielleTotal && francisTotal > edwardTotal)
            {
                WriteLine("Francis is the winner with a total of " + francisTotal.ToString("C") + " in sales");
                WriteLine("Edward had a total of " + edwardTotal.ToString("C") + " in sales");
                WriteLine("Danielle had a total of " + danielleTotal.ToString("C") + " in sales");
                WriteLine("The overall sales were " + francisTotal.ToString("C"));
            }

        }
    }
}
