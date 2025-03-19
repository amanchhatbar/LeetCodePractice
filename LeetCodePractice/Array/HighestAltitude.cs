namespace LeetCodePractice.Recursion;

public class HighestAltitude
{
    public int LargestAltitude(int[] gain)
    {
        var maxAtlitude = 0;
        var tempAtt = 0;
        for (int i = 0; i < gain.Length; i++)
        {
            tempAtt = tempAtt + gain[i];
            if (tempAtt > maxAtlitude)
            {
                maxAtlitude = tempAtt;
            }
        }

        return maxAtlitude;
    }
}