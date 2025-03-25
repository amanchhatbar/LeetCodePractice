namespace LeetCodePractice.NeetCodePract.Graph;

public class Islands
{
    public Islands()
    {
        char[][] grid =
        [
            ['1', '1', '0', '0', '0'],
            ['1', '1', '0', '0', '0'],
            ['0', '0', '1', '0', '0'],
            ['0', '0', '0', '1', '1']
        ];
        Console.WriteLine(NumIslands(grid));
    }
    public int NumIslands(char[][] grid)
    {
        var visitedGrid = new Dictionary<(int, int), int>();
        var islandCounter = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (ExploreNodes(i, j, grid, visitedGrid))
                {
                    islandCounter++;
                }
            }
        }

        return islandCounter;
    }


    private bool ExploreNodes(int i, int j, char[][] grid, Dictionary<(int, int), int> visitedGrid)
    {
        if (i < 0 || j < 0) return false;
        if (i >= grid.Length || j >= grid[0].Length) return false;
        if (grid[i][j] == '0') return false;
        if (visitedGrid.ContainsKey((i, j))) return false;
        visitedGrid.Add((i, j), i);
        ExploreNodes(i + 1, j, grid, visitedGrid);
        ExploreNodes(i, j + 1, grid, visitedGrid);
        ExploreNodes(i - 1, j, grid, visitedGrid);
        ExploreNodes(i, j - 1, grid, visitedGrid);
        return true;
    }
}