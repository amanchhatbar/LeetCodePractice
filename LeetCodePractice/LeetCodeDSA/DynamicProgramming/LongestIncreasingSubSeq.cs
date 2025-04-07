namespace LeetCodePractice.LeetCodeDSA;

public class LongestIncreasingSubSeq
{
    public LongestIncreasingSubSeq()
    {
        Console.WriteLine(LengthOfLIS([9,1,4,2,3,3,7]));
    }
    
    public int LengthOfLIS(int[] nums)
    {
        var result = 0;
        var dictionary = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            result = Math.Max(result, DP(i, nums, dictionary));
        }

        return result;
    }

    private int DP(int i, int[] nums, Dictionary<int, int> memo)
    {
        if (memo.ContainsKey(i)) return memo[i];
        var result = 1;
        for (int j = 0; j < i; j++)
        {
            if (nums[i] > nums[j])
            {
                result = Math.Max(result, DP(j, nums, memo) + 1);
            }
        }

        memo.TryAdd(i, result);

        return result;
    }
}