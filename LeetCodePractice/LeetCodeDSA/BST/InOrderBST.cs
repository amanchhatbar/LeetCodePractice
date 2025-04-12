using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BST;

public class InOrderBST
{
    public void InorderTraversal(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode current = root;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            Console.Write(current.val + " ");
            current = current.right;
        }
    }
}