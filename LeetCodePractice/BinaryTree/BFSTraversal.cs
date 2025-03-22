using LeetCodePractice.Domain;

namespace LeetCodePractice.BinaryTree;

public class BFSTraversal
{
    public void bfsBasic()
    {
        CreateBT createBt = new CreateBT();
        var input = createBt.BinaryTree;

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(input);

        while (queue.Count > 0)
        {
            var dequeuedValue = queue.Dequeue();
            Console.WriteLine($"Dequeued Value {dequeuedValue.Data}");
            if(dequeuedValue.Left != null) queue.Enqueue(dequeuedValue.Left);
            if(dequeuedValue.Right != null) queue.Enqueue(dequeuedValue.Right);
        }
    }
}