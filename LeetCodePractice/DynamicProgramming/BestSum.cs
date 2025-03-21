namespace LeetCodePractice.DP;

//TODO need to fix this
public class BestSum
{
    public List<int>? BestSumMemo(int targetSum, int[] numbers, Dictionary<int, List<int>> memo = null)
    {
        {
            if (memo == null)
                memo = new Dictionary<int, List<int>>();

            if (memo.ContainsKey(targetSum))
                return memo[targetSum]; 

            if (targetSum == 0)
                return new List<int>(); 

            if (targetSum < 0)
                return null; 

            List<int> shortestCombination = null;

            foreach (int num in numbers)
            {
                int remainder = targetSum - num;
                List<int> remainderCombination = BestSumMemo(remainder, numbers, memo);

                if (remainderCombination != null)
                {
                    List<int> combination = new List<int>(remainderCombination) { num };

                    if (shortestCombination == null || combination.Count < shortestCombination.Count)
                    {
                        shortestCombination = combination;
                    }
                }
            }

            memo[targetSum] = shortestCombination; // Store in memo
            return shortestCombination;
        }
    }
}