namespace LeetCodePractice.StringManipulations;

public class ReorgStrings
{
    public string ReorganizeString(string s)
    {
        var sToCharArray = s.ToCharArray();
        var dictionary = new Dictionary<char, int>();
        foreach (var sChar in sToCharArray)
        {
            if (!dictionary.ContainsKey(sChar)) dictionary.Add(sChar, 0);
            dictionary[sChar]++;
        }

        var priorityQueue = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b - a));
        foreach (var keyValue in dictionary)
        {
            priorityQueue.Enqueue(keyValue.Key, keyValue.Value);
        }

        var finalQueue = new Queue<(char, int)>();
        var timeInterval = 0;
        var resultString = string.Empty;
        while (priorityQueue.Count > 0 || finalQueue.Count > 0)
        {
            timeInterval++;
            if (priorityQueue.Count > 0)
            {
                priorityQueue.TryPeek(out char element, out int count);
                priorityQueue.Dequeue();
                resultString += element;
                var newCount = count - 1;
                if (newCount > 0)
                {
                    finalQueue.Enqueue((element, newCount + 1));
                }
            }

            if (finalQueue.Count > 0 && finalQueue.Peek().Item2 == timeInterval)
            {
                var dequeueValue = finalQueue.Dequeue();
                priorityQueue.Enqueue(dequeueValue.Item1, dequeueValue.Item1);
            }
        }

        return resultString;
    }
}