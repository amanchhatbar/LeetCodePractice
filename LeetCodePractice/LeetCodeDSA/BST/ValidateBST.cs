using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BST;

public class ValidateBST
{
    public bool IsValidBST(TreeNode root)
    {
        if(root == null) return true;
        var stack = new Stack<TreeNode>();
        TreeNode preNode = null;
        TreeNode current = root;
        while (stack.Count > 0 || current != null)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            if (preNode != null && current.val <= preNode.val) return false;
            preNode = current;
            current = current.right;

        }
        return true;
    }
}