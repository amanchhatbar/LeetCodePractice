using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BST;

public class InsertBSTree
{
    public TreeNode InsertIntoBST(TreeNode root, int val)
    {
        var nodeToInsert = new TreeNode(val);
        if(root == null) return nodeToInsert;
        var stack = new Stack<TreeNode>();
        
        stack.Push(root);

        while (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            if (poppedValue.val < val)
            {
                if (poppedValue.right != null) stack.Push(poppedValue.right);
                else poppedValue.right = nodeToInsert;
            }
            else
            {
                if (poppedValue.left != null) stack.Push(poppedValue.left);
                else poppedValue.left = nodeToInsert;
            }

        }

        return root;
    }
}