namespace LeetCodePractice.StringManipulations;

public class LongestSubstringWithKRepeating
{
    public LongestSubstringWithKRepeating()
    {
        Console.WriteLine(LongestSubstring("ababacb", 3));
    }
    public int LongestSubstring(string s, int k)
    {
        if (s.Length == 0) return 0;

        var freq = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (!freq.ContainsKey(ch)) freq[ch] = 0;
            freq[ch]++;
        }

        foreach (var entry in freq)
        {
            if (entry.Value < k)
            {
                char badChar = entry.Key;
                var parts = s.Split(badChar);
                int maxLen = 0;
                foreach (var part in parts)
                {
                    maxLen = Math.Max(maxLen, LongestSubstring(part, k));
                }
                return maxLen;
            }
        }

        return s.Length; // All characters meet the requirement
    }
}