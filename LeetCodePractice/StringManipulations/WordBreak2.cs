namespace LeetCodePractice.StringManipulations;

public class WordBreak2
{
    public IList<string> WordBreak()
    {
        var result = WordBreakSingle("pineapplepenapple", ["apple","pen","applepen","pine","pineapple"], new Stack<string>());
        var finalResult = new List<string>();
        var singleResult = string.Empty;
        while (result.Count > 0)
        {
            var poppedValue = result.Pop();
            if (poppedValue == "#")
            {
                finalResult.Add(singleResult.Trim());
                singleResult = string.Empty;
            }
            else
            {
                singleResult = $"{singleResult} {poppedValue}";    
            }
        }
        finalResult.Add(singleResult.Trim());
        return new List<string>();
    }

    public Stack<string>? WordBreakSingle(string s, IList<string> wordDict, Stack<string> finalWords)
    {
        if (s == "") return new Stack<string>();
        if (!wordDict.Any(s.StartsWith)) return null;
        
        for (int i = 0; i < wordDict.Count; i++)
        {
            if (s.StartsWith(wordDict[i]))
            {
                var remainder = getSubString(s, wordDict[i]);
                var result = WordBreakSingle(remainder, wordDict, finalWords);
                if (result != null)
                {
                    finalWords.Push(wordDict[i]);
                    // if (i == 0)
                    // {
                    //     finalWords.Push("#");    
                    // }
                }
            }
            
        }

        return finalWords;
    }

    private string getSubString(string input, string word)
    {
        var wordLength = word.Length;
        var subString = input.Substring(wordLength, input.Length - word.Length);
        return subString;
    }
}