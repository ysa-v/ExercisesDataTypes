using System;

namespace MoreNumericTypes
{
    class MoreNumericTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string milesInput = Console.ReadLine();
            Console.WriteLine("How much gas (in gallons) have you used?");
            string gasInput = Console.ReadLine();

            double miles = double.Parse(milesInput);
            double gas = double.Parse(gasInput);

            double mpg = miles / gas;

            Console.WriteLine("Your mpg is " + mpg.ToString() + ".");
        }
    }
}

