namespace LeetCodePractice.LeetCodeDSA.Graph;

public class ValidatePath
{
    private HashSet<int> visitedNodes = new HashSet<int>();
    public ValidatePath()
    {
        ValidPath(3, [[0,1],[0,2],[3,5],[5,4],[4,3]], 0, 5);
    }
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        var newDict = ConvertEdgesToDict(edges);
        var result= Explore(source, destination, newDict);
        Console.WriteLine(result);
        return result;
    }
    public bool ExploreNew(int source, int destination, Dictionary<int, List<int>> dictionary)
    {
        if (source == destination) return true;
        dictionary.TryGetValue(source, out var neighbours);
        foreach (var neighbour in neighbours)
        {
            return ExploreNew(neighbour, destination, dictionary);
        }

        return false;
    }
    public bool Explore(int source, int destination, Dictionary<int, List<int>> dictionary)
    {
        var stack = new Stack<int>();
        stack.Push(source);

        while (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            visitedNodes.Add(poppedValue);
            if (poppedValue == destination) return true;
            dictionary.TryGetValue(poppedValue, out var neighbors);
            foreach (var neighbor in neighbors)
            {
                if(!visitedNodes.Contains(neighbor)) stack.Push(neighbor);
            }
        }

        return false;
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