namespace LeetCodePractice.LeetCodeDSA.Graph;

public class ConnectedComponents
{
    private HashSet<int> visited = new HashSet<int>();
    public ConnectedComponents()
    {
        Console.WriteLine(CountComponents(4, [[2,3],[1,2],[1,3]]));
    }
    public int CountComponents(int n, int[][] edges)
    {
        var input = ConvertEdgesToDict(edges);
        var count = input.Count == n ? 0 : Math.Abs(input.Count - n);
        foreach (var inputKey in input)
        {
            if (Explore(input, inputKey.Key))
            {
                count++;
            }
        }

        return count;
    }

    private bool Explore(Dictionary<int, List<int>> nodes, int start)
    {
        if (visited.Contains(start)) return false;
        visited.Add(start);
        nodes.TryGetValue(start, out var neighbors);
        foreach (var neighbor in neighbors)
        {
            Explore(nodes, neighbor);
        }
        return true;
    }
    
    private Dictionary<int, List<int>> ConvertEdgesToDict(int[][] edges)
    {
        var result = new Dictionary<int, List<int>>();
        foreach (var edge in edges)
        {
            if (!result.ContainsKey(edge[0]))
            {
                result.Add(edge[0], new List<int>(){edge[1]});
            }
            else
            {
                var value = result[edge[0]];
                value.Add(edge[1]);
                result[edge[0]] = value;
            }
            
            if (!result.ContainsKey(edge[1]))
            {
                result.Add(edge[1], new List<int>(){edge[0]});
            }
            else
            {
                var value = result[edge[1]];
                value.Add(edge[0]);
                result[edge[1]] = value;
            }
        }

        return result;
    }
}