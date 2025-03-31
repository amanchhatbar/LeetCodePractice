using LeetCodePractice.Domain;

namespace LeetCodePractice.BinaryTree;

public class DistanceKNode
{
    public DistanceKNode()
    {
        
    }
    public IList<int> DistanceK(TreeNode root, TreeNode target, int k) 
    {
        Dictionary<TreeNode, TreeNode> parentMap = new Dictionary<TreeNode, TreeNode>();
        HashSet<TreeNode> visited = new HashSet<TreeNode>();
        List<int> result = new List<int>();
        
        // Step 1: Build Parent Map
        BuildParentMap(root, null, parentMap);
        
        // Step 2: Perform BFS from target node
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(target);
        visited.Add(target);
        int distance = 0;
        
        while (queue.Count > 0) {
            int size = queue.Count;
            if (distance == k) {
                foreach (var node in queue) {
                    result.Add(node.val);
                }
                return result;
            }
            
            for (int i = 0; i < size; i++) {
                TreeNode current = queue.Dequeue();
                
                if (current.left != null && !visited.Contains(current.left)) {
                    visited.Add(current.left);
                    queue.Enqueue(current.left);
                }
                if (current.right != null && !visited.Contains(current.right)) {
                    visited.Add(current.right);
                    queue.Enqueue(current.right);
                }
                if (parentMap.ContainsKey(current) && parentMap[current] != null && !visited.Contains(parentMap[current])) {
                    visited.Add(parentMap[current]);
                    queue.Enqueue(parentMap[current]);
                }
            }
            
            distance++;
        }
        
        return result;
    }
    
    private void BuildParentMap(TreeNode node, TreeNode parent, Dictionary<TreeNode, TreeNode> parentMap) {
        if (node == null) return;
        parentMap[node] = parent;
        BuildParentMap(node.left, node, parentMap);
        BuildParentMap(node.right, node, parentMap);
    }
}