namespace LeetCodePractice.LeetCodeDSA.BackTracking;

public class PathFromSource
{
    public PathFromSource()
    {
        var result = AllPathsSourceTarget([[1, 2], [3], [3], []]);
    }
    
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var finalList = new List<IList<int>>();
        Recursive(finalList, new List<int>(), 0, graph.Length - 1, graph);
        return finalList;
    }
    
    public void Recursive(List<IList<int>> finalList, List<int> current, int start, int destination, int[][] graph)
    {
        if (start == destination)
        {
            finalList.Add(new List<int>(current));
            return;
        }

        var neighbors = graph[start];
        if (!current.Contains(start)) current.Add(start);
        foreach (var neighbor in neighbors)
        {
            if (!current.Contains(neighbor))
            {
                current.Add(neighbor);
                Recursive(finalList, current, neighbor, destination, graph);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}