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

        var priorityQueue = new PriorityQueue<(char, int), int>(Comparer<int>.Create((a, b) => b - a));
        foreach (var keyValue in dictionary)
        {
            priorityQueue.Enqueue((keyValue.Key, keyValue.Value), keyValue.Value);
        }

        var result = new List<char>();

        (char c, int freq) previous = ('#', 0);

        while (priorityQueue.Count > 0)
        {
            var (currentChar, currentFreq) = priorityQueue.Dequeue();
            result.Add(currentChar);

            if (previous.freq > 0)
            {
                priorityQueue.Enqueue(previous, previous.freq);
            }

            previous = (currentChar, currentFreq - 1);
        }

        if (result.Count == s.Length)
        {
            return new string(result.ToArray());
        }

        return String.Empty;
    }
}