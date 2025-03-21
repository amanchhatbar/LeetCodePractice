namespace LeetCodePractice.DP;

public class Fibonacci
{
    // using memoization , Dictionary<int, int> dictFib
    public int CalculateFib(int n)
    {
        if (n <= 2) return 1;
        return CalculateFib(n - 1) + CalculateFib(n - 2);
    }

    public long CalculateFibMemoization(int n, Dictionary<int, long> fibDict)
    {
        if (fibDict.TryGetValue(n, out var value))
        {
            return value;
        }
        if (n <= 2) return 1;
        var calculatedFib = CalculateFibMemoization(n - 1, fibDict) + CalculateFibMemoization(n - 2, fibDict);
        fibDict.TryAdd(n, calculatedFib);
        return calculatedFib;
    }
}