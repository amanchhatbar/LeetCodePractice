namespace LeetCodePractice.DP;

public class HowManyConstructStrings
{
    public int? ConstructStrings(string input, List<string> words, Dictionary<string, int> dictionary = null)
    {
        if (dictionary == null)
        {
            dictionary = new Dictionary<string, int>();
        }
        if (dictionary.TryGetValue(input, out var value)) return value;
        
        if (input == "") return 0;
        if (!words.Any(input.StartsWith)) return null;

        foreach (var word in words)
        {
            if (input.StartsWith(word))
            {
                var remainder = RemoveFromBeginning(input, word);
                var result = ConstructStrings(remainder, words);
                if (result.HasValue)
                {
                    return result.Value + 1;
                }
            }
        }

        return null;
    }
    
    private string RemoveFromBeginning(string s, string t)
    {
        var tLength = t.Length;
        var result = s.Substring(tLength, s.Length - tLength);
        return result;
    }
}