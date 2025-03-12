namespace LeetCodePractice.StringManipulations;

public class MaxCandies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        // loop through array to get max value
        var maxCandies = 0;
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] > maxCandies)
            {
                maxCandies = candies[i];
            }
        }
        
        //loop through array again comparing against max value
        var result = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= maxCandies)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        return result;
    }
}