using LeetCodePractice.Domain;

namespace LeetCodePractice.BinaryTree;

public class DFSTraversal
{
    public void DFSBasic()
    {
        CreateBT createBt = new CreateBT();
        var inputTree = createBt.BinaryTree;

        Stack<Node> stack = new Stack<Node>();
        stack.Push(inputTree);

        while (stack.Count > 0)
        {
            var data = stack.Pop();
            Console.WriteLine($"Visited {data.Data}");
            
            if(data.Left != null) stack.Push(data.Left);
            if(data.Right != null) stack.Push(data.Right);
        }
    }

    public void DFSRecursive()
    {
        CreateBT createBt = new CreateBT();
        var inputTree = createBt.BinaryTree;
        DFSRecursive(inputTree);
    }

    private void DFSRecursive(Node? current)
    {
        if(current == null) return;
        
        Console.WriteLine($"DFSRecursive {current.Data}");
        if(current.Left != null) DFSRecursive(current.Left);
        if(current.Right != null) DFSRecursive(current.Right);
    }
}