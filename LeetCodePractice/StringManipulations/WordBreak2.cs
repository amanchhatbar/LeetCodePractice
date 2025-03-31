namespace LeetCodePractice.StringManipulations;

public class WordBreak2
{
    //TODO: does not work.
    public WordBreak2()
    {
        var result = WordBreak("pineapplepenapple", ["apple","pen","applepen","pine","pineapple"]);
    }
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        var finalList = new List<string>();
        foreach (var word in wordDict)
        {
            WordBreakTesting(s, wordDict.ToList(), new List<string>(){word}, finalList, 0);
            
        }
        return finalList;
    }

    private void WordBreakTesting(string originalString, List<string> wordDict, List<string> current, List<string> finalList, int start)
    {
        var testingString = string.Join("", current);
        if (current.Count> 0 && current[0] == "pine")
        {
            var x = true;
        }
        if (string.Compare(originalString, testingString) == 0)
        {
            finalList.Add(string.Join(" ", current));
            return;
        }

        for (int i = start; i < wordDict.Count; i++)
        {
            var newString = string.Join("", current);
            if (newString.Length < originalString.Length)
            {
                current.Add(wordDict[i]);
                WordBreakTesting(originalString, wordDict, current, finalList, i);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
    
    
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