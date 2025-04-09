namespace LeetCodePractice.LeetCodeDSA;

public class UniquePathsProblem
{
    public UniquePathsProblem()
    {
        Console.WriteLine(UniquePaths(3,2));
    }
    public int UniquePaths(int m, int n)
    {
        return Recurssion(m, n, new Dictionary<(int, int), int>());
    }

    private int Recurssion(int m, int n, Dictionary<(int,int), int> memo){
        if(m == 1 && n == 1) return 1;
        if(m == 0 || n == 0) return 0;
        if (memo.ContainsKey((m, n))) return memo[(m, n)];

        int ways = 0;
        ways = Recurssion(m - 1, n, memo) + Recurssion(m, n - 1, memo);

        memo.TryAdd((m,n), ways);
        return ways;
    }
}