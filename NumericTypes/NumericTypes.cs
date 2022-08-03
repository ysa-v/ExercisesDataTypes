using System;

namespace NumericTypes
{
    class NumericTypes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the height?");
            string heightInput = Console.ReadLine();
            Console.WriteLine("What is the width?");
            string widthInput = Console.ReadLine();

            double height = double.Parse(heightInput);
            double width = double.Parse(widthInput);

            double area = height * width;

            Console.WriteLine("The area of the rectangle is " + area.ToString() + ".");
        }
    }
}

