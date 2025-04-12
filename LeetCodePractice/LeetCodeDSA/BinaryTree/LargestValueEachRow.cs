using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.BinaryTree;

public class LargestValueEachRow
{
    public IList<int> LargestValues(TreeNode root)
    {
        var result = new List<int>();
        var levelDictionary = new Dictionary<int, List<int>>();
        var queue = new Queue<(TreeNode node, int queueLevel)>();
        var level = 0;
        queue.Enqueue((root, level));
        while (queue.Count > 0)
        {
            var dequeuedValue = queue.Dequeue();
            if (levelDictionary.TryGetValue(dequeuedValue.queueLevel, out var ints))
            {
                ints.Add(dequeuedValue.node.val);
                levelDictionary[dequeuedValue.queueLevel] = ints;
            }
            else
            {
                levelDictionary.Add(dequeuedValue.queueLevel, new List<int>(){dequeuedValue.node.val});
            }
            
            level = dequeuedValue.queueLevel + 1;
            if(dequeuedValue.node.left!= null) {
                queue.Enqueue((dequeuedValue.node.left, level));
                //Console.WriteLine($"level: {level}, NodeValue: {dequeuedValue.node.left.val}");
            }
            if(dequeuedValue.node.right!= null) {
                queue.Enqueue((dequeuedValue.node.right, level));
                //Console.WriteLine($"level: {level}, NodeValue: {dequeuedValue.node.right.val}");
            }
        }

        foreach (var levelKeyValue in levelDictionary)
        {
            result.Add(levelKeyValue.Value.Min());
        }
        return result;
    }
}