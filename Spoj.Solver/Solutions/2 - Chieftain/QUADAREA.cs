using System;
using System.Collections.Generic;
using System.Linq;

// https://www.spoj.com/problems/QUADAREA/
public static class QUADAREA
{
    // Brahmagupta's formula for getting the largest area of a quadrilateral given its sides.
    public static double Solve(double a, double b, double c, double d)
    {
        double s = (a + b + c + d) / 2;

        return Math.Sqrt((s - a) * (s - b) * (s - c) * (s - d));
    }
}

public static class Program
{
    private static void Main()
    {
        var numberOfCases = int.Parse(Console.ReadLine());

        for (int c = 0; c < numberOfCases; c++)
        {
            double[] line = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            Console.WriteLine(QUADAREA.Solve(line[0], line[1], line[2], line[3]));
        }
    }
}