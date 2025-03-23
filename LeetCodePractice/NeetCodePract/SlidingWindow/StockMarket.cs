namespace LeetCodePractice.NeetCodePract.SlidingWindow;

public class StockMarket
{
    public StockMarket()
    {
        Console.WriteLine(MaxProfit([10, 1, 5, 6, 7, 1]));
    }
    public int MaxProfit(int[] prices)
    {
        var left = 0;
        var right = 1;
        var maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right]) //found something cheaper to buy
            {
                var tempProfit = prices[right] - prices[left];
                if (tempProfit > maxProfit)
                {
                    maxProfit = tempProfit;
                }
            }
            else
            {
                left = right;
            }

            right++;
        }

        return maxProfit;
    }
}