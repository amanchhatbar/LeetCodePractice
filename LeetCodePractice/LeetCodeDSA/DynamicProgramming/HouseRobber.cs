namespace LeetCodePractice.LeetCodeDSA;

public class HouseRobber
{
    public HouseRobber()
    {
        Rob([1, 1, 3, 3]);
    }
    public int Rob(int[] nums)
    {
        var x = DP(nums.Length-1, nums, new Dictionary<int, int>());
        Console.WriteLine(x);
        return x;
    }

    public int DP(int i, int[] nums, Dictionary<int, int> memo)
    {

        if (i == 0) return nums[0];
        if (i == 1) return Math.Max(nums[1], nums[0]);

        if (memo.ContainsKey(i)) return memo[i];
        var x = Math.Max(DP(i - 1, nums, memo), DP(i - 2, nums, memo) + nums[i]);
        memo.TryAdd(i, x);
        return x;
    }
}