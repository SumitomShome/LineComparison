using System;
using System.Collections.Generic;
using System.Text;
namespace LineCompare
{
    public class ComparisonClass
    {
        public double CalculateLength()
        {
            private double x1, y1, x2, y2;
            Console.WriteLine("Enter the coordinates for the line");
            Console.WriteLine("Enter x coordinate of starting point");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of the starting point");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of the ending point");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of the ending point");
            y2 = Convert.ToDouble(Console.ReadLine());
            float length = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return length;
        }
        public void CompareLength(double length1, double length2)
        {
            int differenceInLength = length1.CompareTo(length2);
            if (length1.Equals(length2))
            {
                Console.WriteLine("The lines are of equal length");
            }
            else if (differenceInLength > 0)
            {
                Console.WriteLine("The 1st line is longer than the 2nd line");
            }
            else
            {
                Console.WriteLine("The 2nd line is longer than the 1st line");
            }
            Console.ReadKey();
        }
}
