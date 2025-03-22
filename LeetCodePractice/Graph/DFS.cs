namespace LeetCodePractice.Graph;

public class DFS : CreateGraph
{
    public DFS() : base()
    {
        DFSRecursive('a');
    }

    private void DFSMethod(char source)
    {
        Stack<char> stack = new Stack<char>();
        stack.Push(source);

        while (stack.Count>0)
        {
            var popped = stack.Pop();
            Console.WriteLine(popped);
            _graph.TryGetValue(popped, out var neighbours);
            foreach (var neighbour in neighbours)
            {
                stack.Push(neighbour);
            }
        }
    }

    private void DFSRecursive(char source)
    {
        _graph.TryGetValue(source, out var neighbours);
        Console.WriteLine(source);
        foreach (var neighbour in neighbours)
        {
            DFSRecursive(neighbour);
        }
    }
}