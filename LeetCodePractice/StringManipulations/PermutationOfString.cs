namespace LeetCodePractice.StringManipulations;

public class PermutationOfString
{
    public bool IsPermutation(string s, string t)
    {
        var sCharArray = s.ToCharArray();
        var tCharArray = t.ToCharArray();

        if (sCharArray.Length != tCharArray.Length)
        {
            return false;
        }

        var sDictionary = new Dictionary<char, int>();
        var tDictionary = new Dictionary<char, int>();
        for (int i = 0; i < sCharArray.Length; i++)
        {
            AddOrUpdateDictionary(sDictionary, sCharArray[i]);
            AddOrUpdateDictionary(tDictionary, tCharArray[i]);
        }

        var sortedSDict = sDictionary.OrderBy(x => x.Key).ToList();
        var sortedTDict = tDictionary.OrderBy(x => x.Key).ToList();

        for (int i = 0; i < sortedTDict.Count(); i++)
        {
            if (sortedSDict[i].Value != sortedTDict[i].Value)
            {
                return false;
            }
        }

        return true;
    }

    private void AddOrUpdateDictionary(Dictionary<char, int> dictionary, char charArray)
    {
        if (dictionary.ContainsKey(charArray))
        {
            dictionary.TryGetValue(charArray, out var value);
            dictionary[charArray] = value + 1;
        }
        else
        {
            dictionary.Add(charArray, 1);
        }
    }
}