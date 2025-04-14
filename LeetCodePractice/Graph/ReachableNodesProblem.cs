namespace LeetCodePractice.LeetCodeDSA.Graph;

public class ReachableNodesProblem
{
    private HashSet<int> visited = new HashSet<int>();
    public ReachableNodesProblem()
    {
        Console.WriteLine(ReachableNodes(7, [[0, 1], [0, 2], [0, 5], [0, 4], [3, 2], [6, 5]], [4, 2, 1]));
    }
    public int ReachableNodes(int n, int[][] edges, int[] restricted)
    {
        var dict = ConvertEdgesToDict(edges);
        var orderedList = dict.OrderBy(x => x.Key).ToList();
        var stack = new Stack<int>();
        stack.Push(orderedList[0].Key);
        var count = 0;
        while (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            visited.Add(poppedValue);
            count++;
            dict.TryGetValue(poppedValue, out var neighbors);
            foreach (var neighbor in neighbors)
            {
                if (!restricted.Contains(neighbor) && !visited.Contains(neighbor))
                {
                    stack.Push(neighbor);
                }
            }

        }

        return count;
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