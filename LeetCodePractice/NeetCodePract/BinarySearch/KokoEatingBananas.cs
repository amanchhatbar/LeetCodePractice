namespace LeetCodePractice.NeetCodePract.BinarySearch;

public class KokoEatingBananas
{
    public KokoEatingBananas()
    {
        MinEatingSpeed([25,10,23,4], 4);
    }
    
    public int MinEatingSpeed(int[] piles, int h)
    {
        // find the max value from piles.
        var maxValueFromPiles = piles.Max();
        var searchablePile = new List<int>();
        for (int i = 1; i <= maxValueFromPiles; i++)
        {
            searchablePile.Add(i);
        }
        
        // find the middle value from max and min and run through the simulation to decide which side to look at.
        
        var left = 1;
        var right = maxValueFromPiles;
        var result = right;
        while (left <= right)
        {
            var middleValue = left + (right - left) / 2;
            if (IsGreaterThan(middleValue, piles, h))
            {
                result = middleValue;
                right = middleValue - 1;
            }
            else
            {
                left = middleValue + 1;
            }
        }
        return result;
    }

    private bool IsGreaterThan(int middleValue, int[] piles, int h)
    {
        var sum = 0;
        foreach (var pile in piles)
        {
            sum += (int)Math.Ceiling((double)pile / middleValue);
        }

        return sum <= h;

    }
}