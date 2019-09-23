using System;
using System.Collections.Generic;
using System.Linq;

// https://www.spoj.com/problems/ARMY/
public static class ARMY
{
    public static string Solve(int[] godzillasArmy, int[] mechasArmy)
        => godzillasArmy.Max() >= mechasArmy.Max() ? "Godzilla" : "MechaGodzilla";
}

public static class Program
{
    private static void Main()
    {
        var numberOfBattles = int.Parse(Console.ReadLine());

        for (int b = 0; b < numberOfBattles; b++)
        {
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine(ARMY.Solve(
                godzillasArmy: Array.ConvertAll(Console.ReadLine().Split(), int.Parse),
                mechasArmy: Array.ConvertAll(Console.ReadLine().Split(), int.Parse)));
        }
    }
}