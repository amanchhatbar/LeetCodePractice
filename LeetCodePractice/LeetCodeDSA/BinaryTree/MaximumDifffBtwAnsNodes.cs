using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BinaryTree;

public class MaximumDifffBtwAnsNodes
{
    public int MaxAncestorDiff(TreeNode root)
    {
        return DFS(root, root.val, root.val);
    }

    private int DFS(TreeNode root, int max, int min)
    {

        if (root == null)
        {
            return max - min;
        }

        max = Math.Max(max, root.val);
        min = Math.Min(min, root.val);

        var left = DFS(root.left, max, min);
        var right = DFS(root.right, max, min);
        return Math.Max(left, right);
    }
}