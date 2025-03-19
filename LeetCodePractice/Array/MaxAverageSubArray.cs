namespace LeetCodePractice.Recursion;

public class MaxAverageSubArray
{
    public double FindMaxAverage(int[] nums, int k)
    {
        decimal maxAverage = 0;
        if (nums.Length-k == 0)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                maxAverage = maxAverage + nums[i];
            }

            var result = (maxAverage / k);
            return (double)result;
        }

        for (int i = 0; i < nums.Length - k; i++)
        {
            decimal tempAvg = 0;
            for (int j = i; j < i + k; j++)
            {
                tempAvg = tempAvg + nums[j];
            }

            tempAvg = tempAvg / k;
            if (tempAvg > maxAverage)
            {
                maxAverage = tempAvg;
            }
        }

        return (double)maxAverage;
    }
}