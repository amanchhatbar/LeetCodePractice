namespace LeetCodePractice.DP;

public class CanConstructString
{
    public bool CanConstruct(string input, List<string> words, Dictionary<string, bool> dictionary = null)
    {
        if (dictionary == null)
        {
            dictionary = new Dictionary<string, bool>();
        }
        if (dictionary.TryGetValue(input, out var value)) return value;
        
        if (input == "") return true;
        if (!words.Any(input.StartsWith)) return false;

        foreach (var word in words)
        {
            if (input.StartsWith(word))
            {
                var remainder = RemoveFromBeginning(input, word);
                var output = CanConstruct(remainder, words);
                if (output)
                {
                    dictionary.TryAdd(input, true);
                    return true;
                }
            }
            
        }

        dictionary.TryAdd(input, false);
        return false;

    }

    private string RemoveFromBeginning(string s, string t)
    {
        var tLength = t.Length;
        var result = s.Substring(tLength, s.Length - tLength);
        return result;
    }
}