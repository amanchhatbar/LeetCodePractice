namespace LeetCodePractice.Recursion;

public class BowAndArrow
{
    public BowAndArrow()
    {
        Console.WriteLine(MinimumShots(2, [8,10]));
    }

    public int MinimumShots(int numbOfShots, int[] input)
    {
        // Binary search and get the middle values from the list of values.
        var currentScore = 0;
        foreach (var inp in input)
        {
            currentScore += inp;
        }

        double requiredAvg = 9.5;
        
        var additionalScore = 0;
        while (true)
        {
            var totalHits = input.Length + additionalScore;
            double totalScore = currentScore + (10 * additionalScore);
            double currentAverage = totalScore / totalHits;
            if (Math.Abs(currentAverage) == requiredAvg) break;
            additionalScore++;

            if (additionalScore > 1000)
            {
                return -1;
            }
        }

        return additionalScore;
    }
}