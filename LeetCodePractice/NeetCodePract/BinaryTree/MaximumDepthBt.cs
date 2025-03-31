using LeetCodePractice.Domain;

namespace LeetCodePractice.NeetCodePract.BinaryTree;

public class MaximumDepthBt
{
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0; 
        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}