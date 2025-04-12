using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BinaryTree;

public class DeepestLeavesSums
{
    public int DeepestLeavesSum(TreeNode root)
    {
        var queue = new Queue<(TreeNode node, int level)>();
        queue.Enqueue((root, 0));
        var keyValuePair = new KeyValuePair<int, int>();

        while (queue.Count > 0)
        {
            var dequeuedValue = queue.Dequeue();
            if (keyValuePair.Key == dequeuedValue.level)
            {
                var sum = dequeuedValue.node.val + keyValuePair.Value;
                keyValuePair = new KeyValuePair<int, int>(keyValuePair.Key, sum);
            }
            else
            {
                keyValuePair = new KeyValuePair<int, int>(dequeuedValue.level, dequeuedValue.node.val);
            }

            if (dequeuedValue.node.left != null) queue.Enqueue((dequeuedValue.node.left, dequeuedValue.level + 1));
            if (dequeuedValue.node.right != null) queue.Enqueue((dequeuedValue.node.right, dequeuedValue.level + 1));

        }

        return keyValuePair.Value;
    }
}