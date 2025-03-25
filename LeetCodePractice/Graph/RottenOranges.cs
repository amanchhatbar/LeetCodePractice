namespace LeetCodePractice.Graph;

public class RottenOranges
{
    public RottenOranges()
    {
        OrangesRotting([[2, 1, 1], [1, 1, 0], [0, 1, 1]]);
    }
    
    public int OrangesRotting(int[][] grid) {
        //BFS
        var totalTime = 0;
        List<(int, int)> freshList = new List<(int, int)>();
        List<(int, int)> rottenList = new List<(int, int)>();
        List<(int, int)> emptyGrid = new List<(int, int)>();

        for (int i = 0; i < grid[0].Length; i++)
        {
            for (int j = 0; j < grid[1].Length; j++)
            {
                switch (grid[i][j])
                {
                    case 0 : emptyGrid.Add((i, j));
                        break;
                    case 1 : freshList.Add((i, j));
                        break;
                    case 2 : rottenList.Add((i, j));
                        break;
                    
                }
            }
        }
        
        //Start with rotten oranges and mark all fresh rotten with one time increment.
        var didChange = true;
        foreach (var rottenOrange in rottenList)
        {
            didChange = MarkRotten(rottenOrange, freshList, rottenList, emptyGrid, grid);
            if (didChange) totalTime++;
        }
        
        return totalTime;
    }


    private bool MarkRotten((int,int) rottenOrange, List<(int, int)> freshList, List<(int, int)> rottenList, List<(int, int)> emptyGrid, int[][] grid)
    {
        var didWork = false;
        
            // check if it can move in either direction && has a fresh list object then move
            var nextVisit = new List<(int, int)>()
            {
                (rottenOrange.Item1 - 1, rottenOrange.Item2),
                (rottenOrange.Item1 + 1, rottenOrange.Item2),
                (rottenOrange.Item1, rottenOrange.Item2 - 1),
                (rottenOrange.Item1, rottenOrange.Item2 + 1)
            };

            foreach (var nextVisitPos in nextVisit)
            {
                if (nextVisitPos.Item1 > 0 && nextVisitPos.Item2 > 0
                                           && nextVisitPos.Item1 < grid[0].Length && nextVisitPos.Item2 < grid[1].Length
                                           && freshList.Contains(nextVisitPos))
                {
                    var index = freshList.IndexOf(nextVisitPos);
                    rottenList.Add(nextVisitPos);
                    freshList.RemoveAt(index);
                    didWork = true;
                }
            }
            // else do nothing
        

        return didWork;
    }
}