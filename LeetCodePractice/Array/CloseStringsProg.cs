namespace LeetCodePractice.Recursion;

public class CloseStringsProg
{
    public CloseStringsProg()
    {
        CloseStrings("abc", "cba");
    }
    public bool CloseStrings(string word1, string word2) 
    {
        if(word1.Length != word2.Length) return false;

        var word1Dict = new Dictionary<char, int>();
        var word2Dict = new Dictionary<char, int>();

        foreach(var word1Char in word1){
            if (!word1Dict.ContainsKey(word1Char))
            {
                word1Dict.Add(word1Char, 0);
            }
            word1Dict[word1Char]++;
        }

        foreach(var word2Char in word2){
            if (!word2Dict.ContainsKey(word2Char))
            {
                if (!word1Dict.ContainsKey(word2Char)) return false;
                word2Dict.Add(word2Char, 0);
            }
            word2Dict[word2Char]++;
        }

        var orderedWord1 = word1Dict.OrderByDescending(x => x.Value).Select(x => x.Value).ToList();
        var orderedWord2 = word2Dict.OrderByDescending(x => x.Value).Select(x => x.Value).ToList();
        
        var i = 0;
        while (i < word1Dict.Count)
        {
            if (orderedWord1[i] != orderedWord2[i]) return false;
            i++;
        }

        return true;
    }
}