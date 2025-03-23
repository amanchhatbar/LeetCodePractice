namespace LeetCodePractice.Graph;

public class LargestComponent : CreateGraph
{
    public LargestComponent()
    {
        PrintLargestComponent();
    }

    private void PrintLargestComponent()
    {
        var largest = 0;
        var visited = new HashSet<int>();
        foreach (var element in _largestComponent)
        {
            var newLarge = ExploreAndCount(element.Key, visited);
            if (newLarge > largest)
            {
                largest = newLarge;
            }
        }
        
        Console.WriteLine($"Largest component {largest}");
    }

    private int ExploreAndCount(int node, HashSet<int> visited)
    {
        if (visited.Contains(node)) return 0;
        _largestComponent.TryGetValue(node, out List<int> neighbours);
        var counter = 1;
        visited.Add(node);
        foreach (var neighbour in neighbours)
        {
            counter += ExploreAndCount(neighbour, visited);
        }

        return counter;
    }
}