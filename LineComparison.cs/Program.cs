using System;
namespace LineComparison
{
    class Program
    {
        static float CalculateLength(double x1, double y1, double x2, double y2)
        {
            float length = (float)Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            float[] length = new float[2];
            for (int i = 0; i <= 1; i++)
            {
                double x1 = 0, x2 = 0, y1 = 0, y2 = 0;
                Console.WriteLine("Enter the coordinates for the line" +(i+1));
                Console.WriteLine("Enter x coordinate of starting point");
                x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter y coordinate of the starting point");
                y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter x coordinate of the ending point");
                x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter y coordinate of the ending point");
                y2 = Convert.ToDouble(Console.ReadLine());
                length[i] = CalculateLength(x1, y1, x2, y2);
                Console.WriteLine("The length of the line is: " +length[i]);
            }
            int x = length[0].CompareTo(length[1]);
            if (length[0].Equals(length[1]))
             {
                Console.WriteLine("The lines are of equal length");
            }
             else if (length[0] > length[1])
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
}
            
