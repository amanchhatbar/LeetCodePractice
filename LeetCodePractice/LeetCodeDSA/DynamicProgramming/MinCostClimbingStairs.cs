namespace LeetCodePractice.LeetCodeDSA;

public class MinCostClimbingStairs
{
    public MinCostClimbingStairs()
    {
        MinCostClimbingStairsVa([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]);
    }
    
    public int MinCostClimbingStairsVa(int[] cost)
    {
        var result = Recursion(cost.Length, cost, new Dictionary<int, int>());
        return result;
    }

    public int Recursion(int i, int[] cost, Dictionary<int, int> memo)
    {
        if (i <= 1) return 0;
        if (memo.ContainsKey(i)) return memo[i];
        var x = Math.Min(cost[i - 1] + Recursion(i - 1, cost, memo), cost[i - 2] + Recursion(i - 2, cost, memo));
        memo.TryAdd(i, x);
        return x;
    }
}