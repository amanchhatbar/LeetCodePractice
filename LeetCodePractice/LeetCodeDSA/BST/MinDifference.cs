using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BST;

public class MinDifference
{
    public int GetMinimumDifference(TreeNode root) {
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        var unorderList = new List<int>();
        while(stack.Count > 0){
            var poppedValue = stack.Pop();
            unorderList.Add(poppedValue.val);
            if(poppedValue.left != null) stack.Push(poppedValue.left);
            if(poppedValue.right != null) stack.Push(poppedValue.right);
        }

        unorderList.Sort();
        var result = Int32.MaxValue;
        for (int i = 0; i < unorderList.Count-1; i++)
        {
            var tempDifference = Math.Abs(unorderList[i] - unorderList[i + 1]);
            if (tempDifference < result)
            {
                result = tempDifference;
            }
        }

        return result;
    }
}