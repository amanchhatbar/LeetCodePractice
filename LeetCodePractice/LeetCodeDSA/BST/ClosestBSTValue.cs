using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BST;

public class ClosestBSTValue
{
    
    public int ClosestValue(TreeNode root, double target)
    {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        var result = 0;

        while (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            if (target > poppedValue.val)
            {
                // right
                if (poppedValue.right != null)
                {
                    if(target > poppedValue.right.val) stack.Push(poppedValue.right);
                    else
                    {
                        result = ((double)poppedValue.val - target) < ((double)poppedValue.right.val - target)
                            ? poppedValue.val
                            : poppedValue.right.val;
                    }
                }
            }
            else
            {
                //left
                if (poppedValue.left != null)
                {
                    if(target > poppedValue.left.val) stack.Push(poppedValue.left);
                    else
                    {
                        result = ((double)poppedValue.val - target) < ((double)poppedValue.left.val - target)
                            ? poppedValue.val
                            : poppedValue.left.val;
                    }
                }
            }
        }

        return result;
    }
}