using System;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");
            
            Console.WriteLine("Enter the co-ordinates of one end in x,y format");
            string[] first_Point = (Console.ReadLine()).Split(",");
            double x1 = Convert.ToDouble(first_Point[0]);
            double y1 = Convert.ToDouble(first_Point[1]);
            Console.WriteLine("Enter the co-ordinates of other end in x,y format");
            string[] second_Point = (Console.ReadLine()).Split(",");
            double x2 = Convert.ToDouble(second_Point[0]);
            double y2 = Convert.ToDouble(second_Point[1]);
            double length = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            Console.WriteLine("Length of given line is {0}",length);


        }
    }
}
