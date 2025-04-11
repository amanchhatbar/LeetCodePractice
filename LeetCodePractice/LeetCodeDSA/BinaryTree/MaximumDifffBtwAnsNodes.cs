using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BinaryTree;

public class MaximumDifffBtwAnsNodes
{
    public int MaxAncestorDiff(TreeNode root)
    {
        return DFS(root, Int32.MinValue, Int32.MaxValue);
    }
    
    
    private int DFS(TreeNode node, int maxValue, int minValue)
    {
        if (node == null) return 0;
        
        var left = DFS(node.left, maxValue, minValue);
        var right = DFS(node.right, maxValue, minValue);
        return 1;
    }
}