namespace LeetCodePractice.LeetCodeDSA;

public class MinimumPathSum
{
    public MinimumPathSum()
    {
        Console.WriteLine(MinPathSum([[1, 3, 1], [1, 5, 1], [4, 2, 1]]));
    }
    public int MinPathSum(int[][] grid)
    {
        return RecursiveSum(grid.Length-1, grid[0].Length-1, grid ,new Dictionary<(int, int), int>());
    }

    public int RecursiveSum(int i, int j, int[][] grid, Dictionary<(int, int), int> memo)
    {
        if (i == 0 && j == 0) return grid[i][j];
        
        if (i < 0 || j < 0) return 0;

        if (memo.ContainsKey((i, j))) return memo[(i, j)];
        
        // if we reach the last row then there is no down
        if (i == 0) return grid[i][j] + RecursiveSum(i, j - 1, grid, memo);
        if (j == 0) return grid[i][j] + RecursiveSum(i - 1, j, grid, memo);

        var result = grid[i][j] + Math.Min(RecursiveSum(i, j - 1, grid, memo), RecursiveSum(i - 1, j, grid, memo));
        memo.TryAdd((i, j), result);
        return result;
    }
}