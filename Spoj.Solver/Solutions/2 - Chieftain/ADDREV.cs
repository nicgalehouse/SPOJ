using System;

// https://www.spoj.com/problems/ADDREV/
// Reverses two integers then sums them then returns the reversed sum.
public static class ADDREV
{
    public static int Solve(int x, int y)
        => Reverse(Reverse(x) + Reverse(y));

    private static int Reverse(int x)
    {
        var a = x.ToString().ToCharArray();
        Array.Reverse(a);

        return int.Parse(new string(a));
    }
}

public static class Program
{
    private static void Main()
    {
        var linesToRead = int.Parse(Console.ReadLine());

        for (int i = 0; i < linesToRead; i++)
        {
            var line = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Console.WriteLine(
                ADDREV.Solve(line[0], line[1]));
        }
    }
}