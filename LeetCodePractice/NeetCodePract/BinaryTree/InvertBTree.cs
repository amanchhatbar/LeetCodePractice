using LeetCodePractice.Domain;

namespace LeetCodePractice.NeetCodePract.BinaryTree;

public class InvertBTree
{
    public TreeNode InvertTree(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            var temp = node.left;
            node.left = node.right;
            node.right = temp;
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }

        return root;
    }
}