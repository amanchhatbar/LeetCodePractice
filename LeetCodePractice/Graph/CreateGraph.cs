namespace LeetCodePractice.Graph;

public abstract class CreateGraph
{
    protected Dictionary<char, List<char>> _graph = new Dictionary<char, List<char>>();
    protected Dictionary<int, List<int>> _largestComponent = new Dictionary<int, List<int>>();

    protected CreateGraph()
    {
        _graph.Add('a', ['b', 'c']);
        _graph.Add('b', ['d']);
        _graph.Add('c', ['e']);
        _graph.Add('d', ['f']);
        _graph.Add('e', new List<char>());
        _graph.Add('f', new List<char>());

        _largestComponent.Add(0, [8, 1, 5]);
        _largestComponent.Add(1, [0]);
        _largestComponent.Add(5, [0, 8]);
        _largestComponent.Add(8, [0, 5]);
        _largestComponent.Add(2, [3, 4]);
        _largestComponent.Add(3, [2, 4]);
        _largestComponent.Add(4, [3, 2]);
    }
}