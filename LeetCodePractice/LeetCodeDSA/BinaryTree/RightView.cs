using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BinaryTree;

public class RightView
{
    public IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();
        if(root == null) return result;
        
        var queue = new Queue<(TreeNode node, int level)>();
        queue.Enqueue((root, 0));
        
        while(queue.Count > 0)
        {
            var poppedValue = queue.Dequeue();
            var level = 0;
            if (queue.TryPeek(out (TreeNode node, int level) tuple))
            {
                level = poppedValue.level;
                if (tuple.level != poppedValue.level)
                {
                    result.Add(poppedValue.node.val);
                }
            }
            if(queue.Count == 0){
                result.Add(poppedValue.node.val);
            }

            level += 1;
            if(poppedValue.node.left!= null) queue.Enqueue((poppedValue.node.left, level));
            if(poppedValue.node.right!= null) queue.Enqueue((poppedValue.node.right, level));
        }
        return result;
    }
}