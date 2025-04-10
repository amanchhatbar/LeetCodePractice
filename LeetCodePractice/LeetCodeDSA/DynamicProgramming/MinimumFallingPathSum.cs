namespace LeetCodePractice.LeetCodeDSA;

public class MinimumFallingPathSum
{
    public MinimumFallingPathSum()
    {
        Console.WriteLine(MinFallingPathSum([[2, 1, 3], [6, 5, 4], [7, 8, 9]]));
    }
    public int MinFallingPathSum(int[][] matrix)
    {
        var minPath = Int32.MaxValue;
        var dictionary = new Dictionary<(int, int), int>();
        for (int i = 0; i < matrix.Length; i++)
        {
            var result = DP(0, i, matrix, dictionary);
            minPath = Math.Min(result, minPath);
        }
        return minPath;
    }

    private int DP(int row, int col, int[][] matrix, Dictionary<(int,int), int> memo)
    {
        if (col < 0 || col == matrix.Length) return Int32.MaxValue;
        if (memo.ContainsKey((row, col))) return memo[(row, col)];
        if (row == matrix[0].Length - 1) return matrix[row][col];

        var result= matrix[row][col] + Math.Min(DP(row + 1, col - 1, matrix, memo), Math.Min(DP(row + 1, col, matrix, memo),
            DP(row + 1, col + 1, matrix, memo)));
        memo.TryAdd((row, col), result);
        return result;
    }
}