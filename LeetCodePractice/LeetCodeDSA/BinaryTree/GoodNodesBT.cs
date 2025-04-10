
namespace LeetCodePractice.LeetCodeDSA.BinaryTree;

public class GoodNodesBT
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public GoodNodesBT()
    {
        
    }
    public int GoodNodes(TreeNode root) {
        return GoodNodesUsingStack(root);
    }
    
    public int GoodNodesUsingStack(TreeNode root){
        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, Int32.MinValue));
        var counter = 1;
        while(stack.Count > 0){
            var poppedValue = stack.Pop();
            if(poppedValue.Item1.left != null){
                counter += poppedValue.Item2 <= poppedValue.Item1.left.val ? 1 : 0;
                stack.Push((poppedValue.Item1.left, Math.Max(poppedValue.Item2, poppedValue.Item1.val)));
            }
            if(poppedValue.Item1.right != null){
                counter += poppedValue.Item2 <= poppedValue.Item1.right.val ? 1 : 0;
                stack.Push((poppedValue.Item1.right,Math.Max(poppedValue.Item2, poppedValue.Item1.val)));
            }
        }
        return counter;
    }
}