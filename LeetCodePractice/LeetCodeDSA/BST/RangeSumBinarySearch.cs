using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BST;

public class RangeSumBinarySearch
{
    
    public int RangeSumBST(TreeNode root, int low, int high)
    {
        var stacks = new Stack<TreeNode>();
        stacks.Push(root);
        var sum = 0;
        while (stacks.Count > 0)
        {
            var poppedValue = stacks.Pop();
            if (low <= poppedValue.val && poppedValue.val >= high)
            {
                Console.WriteLine(poppedValue.val);
                sum += poppedValue.val;
            }

            if (poppedValue.left != null) stacks.Push(poppedValue.left);
            if (poppedValue.right != null) stacks.Push(poppedValue.right);
        }

        return sum;
    }
}