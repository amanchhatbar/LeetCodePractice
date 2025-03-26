namespace LeetCodePractice.NeetCodePract;

public class Anagram
{
    public Anagram()
    {
        Console.WriteLine(IsAnagram("racecar", "carrace"));
    }
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var controlDict = new Dictionary<char, int>();

        foreach(char sChar in s)
        {
            if (!controlDict.ContainsKey(sChar)) controlDict.Add(sChar, 0);
            controlDict[sChar]++;
        }
        
        var testDict = new Dictionary<char, int>();

        foreach(char tChar in t)
        {
            if (!testDict.ContainsKey(tChar)) testDict.Add(tChar, 0);
            testDict[tChar]++;
        }

        if (controlDict.Count != testDict.Count) return false;

        foreach (var controlDictValue in controlDict)
        {
            if (!testDict.ContainsKey(controlDictValue.Key)) return false;
            testDict.TryGetValue(controlDictValue.Key, out var testDictValue);
            if (controlDictValue.Value != testDictValue) return false;
        }

        return true;
    }
}