namespace LeetCodePractice.DP;

public class CanSum
{
    public bool CanItSum(int targetSum, List<int> numbers, Dictionary<int, bool> targetSumDict)
    {
        if (targetSumDict.TryGetValue(targetSum, out var sum)) return sum;
        if (targetSum == 0) return true;
        if (targetSum < 0) return false;

        foreach (var number in numbers)
        {
            var remainder = targetSum - number;
            if (CanItSum(remainder, numbers, targetSumDict))
            {
                targetSumDict.TryAdd(targetSum, true);
                return true;
            }
        }

        targetSumDict.TryAdd(targetSum, false);
        return false;
    }
}