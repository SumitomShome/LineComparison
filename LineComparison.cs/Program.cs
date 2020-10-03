using System;
using System;
namespace LineCompare
{
    class Program
    {
       public static void Main(string[] args)
        {
            ComparisonClass lines = new ComparisonClass();
            double[] lengthOfLine = new double[2];
            for (int noOfLine = 0; noOfLine <= 1; noOfLine++)
            {
                lengthOfLine[noOfLine] = lines.CalculateLength();
            }
            lines.CompareLength(lengthOfLine[0], lengthOfLine[1]);
            Console.ReadKey();
        }
    }
}
            
