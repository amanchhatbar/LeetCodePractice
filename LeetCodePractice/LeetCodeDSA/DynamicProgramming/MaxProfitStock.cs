namespace LeetCodePractice.LeetCodeDSA;

public class MaxProfitStock
{
    public MaxProfitStock()
    {
        Console.WriteLine(MaxProfit(3, [1, 3, 7, 5, 10, 3]));
    }
    public int MaxProfit(int k, int[] prices)
    {
        //return DP(0, 0, k, new Dictionary<(int, int, int), int>(), prices);
        return DFSWithTrans(0, 0, prices, new Dictionary<(int, int), int>(), k);
    }

    private int DP(int i, int holding, int remain, Dictionary<(int, int, int), int> memo, int[] prices)
    {
        if (i == prices.Length || remain == 0)
        {
            return 0;
        }

        if (memo.ContainsKey((i, holding, remain))) return memo[(i, holding, remain)];
        
        int answer = DP(i+1, holding, remain, memo, prices);
        if (holding == 1)
        {
            answer = Math.Max(answer, prices[i] + DP(i + 1, 0, remain - 1, memo, prices));
        }
        else
        {
            answer = Math.Max(answer, -prices[i] + DP(i + 1, 1, remain, memo, prices));
        }

        memo.TryAdd((i, holding, remain), answer);

        return answer;
    }
    
    
    private int DFSWithTrans(int i, int holding, int[] prices, Dictionary<(int,int), int> memo, int transaction)
    {
        if (i == prices.Length) return 0;
        if (memo.ContainsKey((i, holding))) return memo[(i, holding)];

        int answer = DFSWithTrans(i + 1, holding, prices, memo, transaction);

        if (holding == 1)
        {
            answer = Math.Max(answer, prices[i] + DFSWithTrans(i + 1, 0, prices, memo, transaction));
        }
        else
        {
            answer = Math.Max(answer, -prices[i] + DFSWithTrans(i + 1, 1, prices, memo, transaction) - transaction);
        }

        memo.TryAdd((i, holding), answer);
        return answer;
    } 
}