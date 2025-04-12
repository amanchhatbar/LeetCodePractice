using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BinaryTree;

public class ZigZagTravel
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        var stack = new Stack<TreeNode>();
        queue.Enqueue(root);
        var result = new List<IList<int>>();
        while (queue.Count > 0 || stack.Count > 0)
        {
            var temp = new List<int>();
            while (queue.Count > 0)
            {
                var dequeuedValue = queue.Dequeue();
                temp.Add(dequeuedValue.val);
                if (dequeuedValue.left != null) stack.Push(dequeuedValue.left);
                if (dequeuedValue.right != null) stack.Push(dequeuedValue.right);
            }

            if(temp.Count > 0) result.Add(new List<int>(temp));
            temp.Clear();
            
            while (stack.Count > 0)
            {
                var poppedValue = stack.Pop();
                temp.Add(poppedValue.val);
                if (poppedValue.left != null) queue.Enqueue(poppedValue.left);
                if (poppedValue.right != null) queue.Enqueue(poppedValue.right);
            }
            if(temp.Count > 0) result.Add(new List<int>(temp));
        }

        return result;
    }
}