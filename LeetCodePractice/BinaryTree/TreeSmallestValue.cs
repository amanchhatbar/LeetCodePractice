using LeetCodePractice.Domain;

namespace LeetCodePractice.BinaryTree;

public class TreeSmallestValue
{
    public TreeSmallestValue()
    {
        CreateBT createBt = new CreateBT();
        Console.WriteLine(MinValue(createBt.BinaryTree));
    }

    private int MinValue(Node? node)
    {
        if (node == null) return 0;

        Stack<Node> stack = new Stack<Node>();
        stack.Push(node);
        var minValue = Int32.MaxValue;
        if (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            if (poppedValue.Data < minValue)
            {
                minValue = poppedValue.Data;
            }
            
            if(poppedValue.Left != null) stack.Push(poppedValue.Left);
            if(poppedValue.Right != null) stack.Push(poppedValue.Right);
        }

        return minValue;
    }
}