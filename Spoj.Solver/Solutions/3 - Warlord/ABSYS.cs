using System;

// https://www.spoj.com/problems/ABSYS/
// Takes an equation with the format "number + number = number" where one number
// is obfuscated by an inkblot and returns the equation with no numbers obfuscated.
public static class ABSYS
{
    private const string _inkblot = "machula";

    public static string Solve(string equation)
    {
        var equationParts = equation.Split();

        int addend1; // lineParts[0];
        int addend2; // lineParts[2];
        int sum; // lineParts[4];

        if (equationParts[0].Contains(_inkblot))
        {
            addend2 = int.Parse(equationParts[2]);
            sum = int.Parse(equationParts[4]);
            addend1 = sum - addend2;
        }
        else if (equationParts[2].Contains(_inkblot))
        {
            addend1 = int.Parse(equationParts[0]);
            sum = int.Parse(equationParts[4]);
            addend2 = sum - addend1;
        }
        else
        {
            addend1 = int.Parse(equationParts[0]);
            addend2 = int.Parse(equationParts[2]);
            sum = addend1 + addend2;
        }

        return $"{addend1} + {addend2} = {sum}";
    }
}

public static class Program
{
    private static void Main()
    {
        var numberOfCases = int.Parse(Console.ReadLine());

        for (int c = 0; c < numberOfCases; c++)
        {
            Console.ReadLine(); // Consumes blank line

            Console.WriteLine(
                ABSYS.Solve(Console.ReadLine()));
        }
    }
}