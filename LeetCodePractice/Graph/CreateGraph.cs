namespace LeetCodePractice.Graph;

public abstract class CreateGraph
{
    protected Dictionary<char, List<char>> _graph = new Dictionary<char, List<char>>();

    protected CreateGraph()
    {
        _graph.Add('a', ['b', 'c']);
        _graph.Add('b', ['d']);
        _graph.Add('c', ['e']);
        _graph.Add('d', ['f']);
        _graph.Add('e', new List<char>());
        _graph.Add('f', new List<char>());
    }
}