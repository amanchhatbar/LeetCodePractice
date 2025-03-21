namespace LeetCodePractice.DP;

public class HowSum
{
    public List<int>? HowSumProblem(int targetSum, List<int> numbers, List<int> output, Dictionary<int, List<int>> howDict)
    {
        if (howDict.TryGetValue(targetSum, out var value)) return value;
        if (targetSum == 0) return new List<int>();
        if (targetSum < 0) return null;

        foreach (var number in numbers)
        {
            var remainder = targetSum - number;
            var result = HowSumProblem(remainder, numbers, output, howDict);
            if (result != null)
            {
                output.Add(number);
                howDict.TryAdd(targetSum, output);
                return output;
            }
        }

        return null;
    }
}