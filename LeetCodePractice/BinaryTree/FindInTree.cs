using LeetCodePractice.Domain;

namespace LeetCodePractice.BinaryTree;

public class FindInTree
{
    public FindInTree()
    {
        
    }
    public bool FindTargetInTree(int? target, Node? node)
    {
        if (node == null || !target.HasValue)
        {
            return false;
        }

        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var poppedValue = queue.Dequeue();
            if (poppedValue.Data == target) return true;
            if(poppedValue.Left != null) queue.Enqueue(poppedValue.Left);
            if(poppedValue.Right != null) queue.Enqueue(poppedValue.Right);
        }
        return false;
    }

public bool FindTargetInTreeRecursive(int? target, Node? node)
    {
        if (node == null || !target.HasValue)
        {
            return false;
        }

        if (node.Data == target) return true;

        var result = FindTargetInTreeRecursive(target, node.Left) || FindTargetInTreeRecursive(target, node.Right);

        return result;
    }
}