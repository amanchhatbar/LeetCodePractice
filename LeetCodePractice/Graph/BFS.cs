namespace LeetCodePractice.Graph;

public class BFS: CreateGraph
{
    public BFS():base()
    {
        BFSMethod('a');
    }
    public void BFSMethod(char source)
    {
        var queue = new Queue<char>();
        queue.Enqueue(source);

        while (queue.Count > 0)
        {
            var dequeuedVal = queue.Dequeue();
            _graph.TryGetValue(dequeuedVal, out var neighbours);
            Console.WriteLine($"{dequeuedVal}");
            if (neighbours != null)
            {
                foreach (var neighbour in neighbours)
                {
                    queue.Enqueue(neighbour);
                } 
            }
        }
    }
}