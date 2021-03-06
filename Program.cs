﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            List<double> length = new List<double>();
            for (int i = 1; i < 3;i++)
                {
                    Console.WriteLine("Enter the co-ordinates of one end of line {0} in x,y format", i);
                    string[] firstPoint = (Console.ReadLine()).Split(",");
                    double x1 = Convert.ToDouble(firstPoint[0]);
                    double y1 = Convert.ToDouble(firstPoint[1]);
                    Console.WriteLine("Enter the co-ordinates of other end of line {0} in x,y format",i);
                    string[] secondPoint = (Console.ReadLine()).Split(",");
                    double x2 = Convert.ToDouble(secondPoint[0]);
                    double y2 = Convert.ToDouble(secondPoint[1]);
                    double len = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
                    length.Add(len);
                    Console.WriteLine("Length of given line{0} is {1}",i, len);
                }
            if (length[0] == length[1])
                Console.WriteLine("The lengths of both the lines are equal");
            if (length[0]>length[1])
            {
                Console.WriteLine("The length of Line 1 is greater than that of line 2");
            }
            else
                Console.WriteLine("The length of Line 2 is greater than that of line 1");




        }
    }
}
