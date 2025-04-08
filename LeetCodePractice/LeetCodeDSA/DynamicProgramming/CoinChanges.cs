namespace LeetCodePractice.LeetCodeDSA;

public class CoinChanges
{
    public CoinChanges()
    {
        var x = CoinChange([1, 2, 5], 11);
    }
    public int CoinChange(int[] coins, int amount)
    {
        var finalList = new List<List<int>>();
        DP(coins, amount, new List<int>(),finalList);
        var x = finalList.OrderBy(x => x.Count).First();
        var y = DFS(amount, coins, new Dictionary<int, int>());
        return 1;
    }
    
    private void DP(int[] coins, int target, List<int> current, List<List<int>> finalValue){
        if (target == 0)
        {
            finalValue.Add(new List<int>(current));
        }

        for (int j = 0; j < coins.Length; j++)
        {
            var difference = target - coins[j];
            if (difference >= 0)
            {
                current.Add(coins[j]);
                DP(coins, difference, current, finalValue);
                current.RemoveAt(current.Count - 1);
            }
        }
    }

    private int DFS(int target, int[] coins, Dictionary<int, int> memo)
    {
        if (target == 0) return 0;
        if (memo.ContainsKey(target)) return memo[target];

        int res = Int32.MaxValue;
        foreach (var coin in coins)
        {
            var difference = target - coin;
            if (difference >= 0)
            {
                var result = DFS(difference, coins, memo);
                if (result != Int32.MaxValue)
                {
                    res = Math.Min(res, 1 + result);
                }
            }
        }
        memo[target] = res;
        return res;
    }
}