namespace LeetCodePractice.Recursion;

public class TaskScheduler
{
    public int LeastInterval(char[] tasks, int n)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach (var task in tasks)
        {
            if (!dict.ContainsKey(task))
            {
                dict.Add(task, 0);
            }

            dict[task]++;
        }

        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        foreach (var dictValue in dict)
        {
            maxHeap.Enqueue(dictValue.Value, dictValue.Value);
        }

        Queue<(int, int)> mainQueue = new Queue<(int, int)>();
        var processingTime = 0;
        while (maxHeap.Count > 0 || mainQueue.Count > 0)
        {
            processingTime++;
            if (maxHeap.Count > 0)
            {
                var dequeuedValue = maxHeap.Dequeue() - 1;
                if (dequeuedValue > 0)
                {
                    mainQueue.Enqueue((dequeuedValue, processingTime + n));
                }
            }

            if (mainQueue.Count > 0 && mainQueue.Peek().Item2 == processingTime)
            {
                var mainDequeued = mainQueue.Dequeue();
                maxHeap.Enqueue(mainDequeued.Item1, mainDequeued.Item1);
            }
        }

        return processingTime;
    }
}