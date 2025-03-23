namespace LeetCodePractice.Graph;

public class ConnectedComponents : CreateGraph
{

    public ConnectedComponents()
    {
        ConnectedCount();
    }

    public void ConnectedCount()
    {
        var visitedDictionary = new HashSet<char>();
        var count = 0;
        foreach (var key in _graph)
        {
            if (ExploreNodes(key.Key, visitedDictionary))
            {
                count++;
            }
        }
        
        Console.WriteLine($"Number of connected nodes {count}");
    }

    private bool ExploreNodes(char node, HashSet<char> visited)
    {
        if (visited.Contains(node)) return false;
        _graph.TryGetValue(node, out var neighbours);
        visited.Add(node);
        foreach (var neighbour in neighbours)
        {
            ExploreNodes(neighbour, visited);
        }
        return true;
    }
}