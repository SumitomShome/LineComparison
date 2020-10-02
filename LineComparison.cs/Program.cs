using System;
namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            Console.WriteLine("Enter the coordinates");
            double x1, y1, x2, y2, length_1, m1, m2, n1, n2, length_2;
            Console.WriteLine("Enter x coordinate of starting point for the first line");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of the starting point for the first line");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of the ending point for the first line");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of the ending point for the first line");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of the starting point for the second line");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of the starting point for the second line");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x coordinate of the ending point for the second line");
            m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y coordinate of the ending point for the second line");
            n2 = Convert.ToDouble(Console.ReadLine());
            length_1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("The length of the first line is:" + length_1);
            length_2 = Math.Sqrt(((m2 - m1) * (m2 - m1)) + ((n2 - n1) * (n2 - n1)));
            Console.WriteLine("The length of the second line is:" + length_2);
            Console.ReadKey();

        }
    }
}
