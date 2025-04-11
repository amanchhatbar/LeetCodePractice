namespace LeetCodePractice.Graph;

public class RottenOranges
{
    public RottenOranges()
    {
        Console.WriteLine(OrangesRotting([[2, 1, 1], [1, 1, 0], [0, 1, 1]]));
    }
    
    public int OrangesRotting(int[][] grid)
    {
        var queue = new Queue<(int, int)>();
        var directions = new List<(int, int)> {(-1, 0), (0, 1), (1, 0), (0, -1)};
        var freshOranges = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 2)
                {
                    queue.Enqueue((i, j));
                }

                if (grid[i][j] == 1) freshOranges++;
            }
        }

        var minutesElapsed = 0;
        while (queue.Count > 0 && freshOranges > 0)
        {
            var size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var rottenCoordinates = queue.Dequeue();

                foreach (var direction in directions)
                {
                    var newX = direction.Item1 + rottenCoordinates.Item1;
                    var newY = direction.Item2 + rottenCoordinates.Item2;

                    if (newX < 0 || newY < 0) continue;
                    if (newX >= grid.Length || newY >= grid[0].Length) continue;

                    if (grid[newX][newY] != 1) continue;

                    grid[newX][newY] = 2;
                    queue.Enqueue((newX, newY));
                    freshOranges--;
                }
            }

            minutesElapsed++;
        }

        return freshOranges > 0 ? -1 : minutesElapsed;
    }
}