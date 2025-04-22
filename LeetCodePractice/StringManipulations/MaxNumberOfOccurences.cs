namespace LeetCodePractice.StringManipulations;

public class MaxNumberOfOccurences
{
    public MaxNumberOfOccurences()
    {
        Console.WriteLine(MaxFreq("abcde", 2, 3, 3));
    }
    public int MaxFreq(string s, int maxLetters, int minSize, int maxSize)
    {
        // external for loop will go over each letter
        // get substring from the string between min and max
        // if it has unique chars less than or equal to maxLetters
        // add it to the dictionary
        var maxFreqDict = new Dictionary<string, int>();
        for (int i = 0; i <= s.Length - minSize; i++)
        {
            if (i == 6)
            {
                var x = 0;
            }
            var internalMin = minSize;
            while (internalMin <= maxSize)
            {
                if (i + internalMin <= s.Length)
                {
                    var subString = s.Substring(i, internalMin);
                    var hashSetString = subString.ToHashSet();
                    if (hashSetString.Count <= maxLetters)
                    {
                        if (!maxFreqDict.ContainsKey(subString)) maxFreqDict.Add(subString, 0);
                        maxFreqDict[subString]++;
                    }
                }
                internalMin++;
            }
        }

        var sortedDict = maxFreqDict.Count == 0 ? 0 : maxFreqDict.OrderByDescending(x => x.Value).First().Value;
        return sortedDict;
    }
}