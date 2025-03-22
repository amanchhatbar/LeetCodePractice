using LeetCodePractice.Domain;

namespace LeetCodePractice.BinaryTree;

public class SumOfNodes
{
    public SumOfNodes()
    {
        CreateBT createBt = new CreateBT();
        Console.WriteLine($"Non Recursive {NodeSums(createBt.BinaryTree)}");
        Console.WriteLine($"Recursive {NodeSumsRecursive(createBt.BinaryTree)}");
    }
    private int NodeSums(Node? node)
    {
        if (node == null) return 0;
        Stack<Node> stack = new Stack<Node>();
        stack.Push(node);
        var sum = 0;
        while (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            sum += poppedValue.Data;
            if(poppedValue.Left != null) stack.Push(poppedValue.Left);
            if(poppedValue.Right != null) stack.Push(poppedValue.Right);
        }

        return sum;
    }

    public int NodeSumsRecursive(Node? node)
    {
        if (node == null) return 0;

        return node.Data + NodeSumsRecursive(node.Left) + NodeSumsRecursive(node.Right);
    }
}