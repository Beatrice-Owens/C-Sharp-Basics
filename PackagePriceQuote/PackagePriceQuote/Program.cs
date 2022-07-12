using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackagePriceQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            //using decimal data type due to primary purpose being financial and likelyhood of necessary decimal places for weight, height, etc.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight.");
            decimal weight = Convert.ToDecimal(Console.ReadLine()); //decimal var cast from str input

            if (weight > 50) //branching - if package weight is over 50 then: 
            {
                Console.WriteLine("Package too heavy to be shipped via Packge Express. Have a good day.");
                Console.ReadLine();
            }
            else //if the weight is 50 or under then continue: 
            {
                Console.WriteLine("Please enter package width.");
                decimal width = Convert.ToDecimal(Console.ReadLine()); //casting str to decimal 
                Console.WriteLine("Please enter package height.");
                decimal height = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Please enter package length.");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                decimal dimensionTotal = width + height + length; //dec var to check if package size is too large
                decimal quote = ((width * height * length) * weight) / 100; //formula for determining price
                quote = decimal.Round(quote, 2); //making sure the price is rounded to two decimal places

                //ternary operation so another if/else branching isn't necessary
                string estTotal = dimensionTotal > 50 ? "Package too big to be shipped via Package Express." : "Your estimated total for shipping this package is: $" + quote;

                Console.WriteLine(estTotal); //display results to console
                Console.ReadLine(); //keep it displayed until told otherwise
            }
        }
    }
}
