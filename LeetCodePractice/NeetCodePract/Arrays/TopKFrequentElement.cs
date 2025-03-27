namespace LeetCodePractice.NeetCodePract;

public class TopKFrequentElement
{
    public TopKFrequentElement()
    {
        TopKFrequent([1, 2, 2, 3, 3, 3], 2);
    }
    public int[] TopKFrequent(int[] nums, int k)
    {
        var result = new int[k];
        if (nums.Length == 0) return result; 
        
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if(!dict.ContainsKey(num)) dict.Add(num, 0);
            dict[num]++;
        }

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        foreach (var dictValue in dict)
        {
            priorityQueue.Enqueue(dictValue.Key, dictValue.Value);
        }

        int counter = 0;
        while (counter < k)
        {
            result[counter] = priorityQueue.Dequeue();
            counter++;
        }

        return result;
    }
}