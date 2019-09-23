using System;
using System.Collections.Generic;
using System.Linq;

// https://www.spoj.com/problems/NSTEPS/
public static class NSTEPS
{
    public static int? Solve(int x, int y)
    {
        if (x == y)
            return x % 2 == 0
                ? x * 2
                : x * 2 - 1;

        if (x == y + 2)
            return x % 2 == 0
                ? x + y
                : x + y - 1;

        return null;
    }
}

public static class Program
{
    private static void Main()
    {
        var numberOfCases = int.Parse(Console.ReadLine());

        for (int c = 0; c < numberOfCases; c++)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(
                NSTEPS.Solve(line[0], line[1])?.ToString() ?? "No Number");
        }
    }
}