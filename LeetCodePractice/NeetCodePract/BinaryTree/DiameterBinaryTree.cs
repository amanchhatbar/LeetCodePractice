using LeetCodePractice.Domain;

namespace LeetCodePractice.NeetCodePract.BinaryTree;

public class DiameterBinaryTree
{
    
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        int res = 0;
        DFS(root, ref res);
        return res;
    }

    public int DFS(TreeNode node, ref int result)
    {
        if (node == null) return 0;

        var left = DFS(node.left, ref result);
        var right = DFS(node.right, ref result);
        result = Math.Max(result, left + right);
        return 1 + Math.Max(left, right);
    }
}