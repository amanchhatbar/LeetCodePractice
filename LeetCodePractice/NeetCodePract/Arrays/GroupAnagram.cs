namespace LeetCodePractice.NeetCodePract;

public class GroupAnagram
{
    public GroupAnagram()
    {

        var result = GroupAnagrams(["ddddddddddg","dgggggggggg"]);

    }
    // iterate through all comparing with other.
    
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        if (strs.Length == 0) return new List<List<string>>();
        HashSet<int> visitedIndex = new HashSet<int>();
        var result = new List<List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            var temporary = new List<string>();
            if(visitedIndex.Contains(i)) continue;
            temporary.Add(strs[i]);
            for (int j = i + 1; j < strs.Length; j++)
            {
                if(visitedIndex.Contains(j)) continue;
                if (IsAnagram(strs[i], strs[j]))
                {
                    visitedIndex.Add(i);
                    visitedIndex.Add(j);
                    temporary.Add(strs[j]);
                }
            }
            result.Add(temporary);
        }


        return result;

    }
    // check if anagram
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;
        var sDict = new Dictionary<char, int>();
        foreach (var sChar in s)
        {
            if (!sDict.ContainsKey(sChar))
            {
                sDict.Add(sChar, 0);
            }
            sDict[sChar]++;
        }
        
        var tDict = new Dictionary<char, int>();
        foreach (var tChar in t)
        {
            if (!tDict.ContainsKey(tChar))
            {
                tDict.Add(tChar, 0);
            }
            tDict[tChar]++;
        }

        if (sDict.Count != tDict.Count) return false;

        foreach (var sDictValue in sDict)
        {
            if (!tDict.ContainsKey(sDictValue.Key)) return false;
            if (tDict.TryGetValue(sDictValue.Key, out int tDictValue))
            {
                if (tDictValue != sDictValue.Value) return false;
            }
        }


        return true;
    }
}