namespace LeetCodePractice.Graph;

public class HasPath : CreateGraph
{
    public HasPath()
    {
        Console.WriteLine(HasPathOrNotRecursive('a', 'f'));
    }
    private void HasPathOrNot(char source, char destination)
    {
        Stack<char> stack = new Stack<char>();
        stack.Push(source);

        while (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            if (poppedValue == destination)
            {
                Console.WriteLine($"Found Destination {destination}");
                break;
            }

            _graph.TryGetValue(poppedValue, out var neighbours);
            if (neighbours != null)
            {
                foreach (var neighbour in neighbours)
                {
                    stack.Push(neighbour);
                }
            }
        }
    }
    
    private bool HasPathOrNotRecursive(char source, char destination)
    {
        if (source == destination) return true;
        _graph.TryGetValue(source, out var neighbours);
        foreach (var neighbour in neighbours)
        {
            return HasPathOrNotRecursive(neighbour, destination);
        }

        return false;
    }
}