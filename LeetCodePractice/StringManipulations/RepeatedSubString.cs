namespace LeetCodePractice.StringManipulations;

public class RepeatedSubString
{
    public RepeatedSubString()
    {
        var result = GetRepeatedSubstrings("inengineering");
    }
    public Dictionary<string, int> GetRepeatedSubstrings(string s)
    {
        int n = s.Length;
        var suffixes = new string[n];

        for (int i = 0; i < n; i++)
            suffixes[i] = s.Substring(i);

        Array.Sort(suffixes);

        var substringCounts = new Dictionary<string, int>();

        for (int i = 0; i < n - 1; i++)
        {
            string lcp = LongestCommonPrefix(suffixes[i], suffixes[i + 1]);

            for (int len = 2; len <= lcp.Length; len++) // we skip trivial length 1
            {
                string sub = lcp.Substring(0, len);
                if (substringCounts.ContainsKey(sub))
                    substringCounts[sub]++;
                else
                    substringCounts[sub] = 2; // found in two suffixes so far
            }
        }

        return substringCounts;
    }

    public string LongestCommonPrefix(string a, string b)
    {
        int len = Math.Min(a.Length, b.Length);
        int i = 0;
        while (i < len && a[i] == b[i]) i++;
        return a.Substring(0, i);
    }
}