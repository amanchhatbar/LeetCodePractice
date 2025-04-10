namespace LeetCodePractice.LeetCodeDSA;

public class UniquePath2
{
    public UniquePath2()
    {
        UniquePathsWithObstacles([[0, 0, 0], [0, 1, 0], [0, 0, 0]]);
    }
    
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        var result = DFS(0, 0, obstacleGrid, new Dictionary<(int, int), int>());
        return result;
    }
    
    
    private int DFS(int i, int j, int[][] obstacleGrid, Dictionary<(int,int), int> memo){
        if (i == obstacleGrid.Length - 1 && j == obstacleGrid[0].Length - 1)
        {
            return obstacleGrid[i][j] == 1 ?  0 :  1;
        }

        if (memo.ContainsKey((i, j)))
        {
            return memo[(i,j)];
        }

        if (i >= obstacleGrid.Length || j >= obstacleGrid[0].Length)
        {
            return 0;
        }

        if (obstacleGrid[i][j] == 1)
        {
            return 0;
        }

        var result = 0;
        result = DFS(i + 1, j, obstacleGrid, memo) + DFS(i, j + 1, obstacleGrid, memo);
        memo.TryAdd((i, j), result);
        return result;
    }
}