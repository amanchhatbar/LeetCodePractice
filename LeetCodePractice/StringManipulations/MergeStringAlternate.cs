namespace LeetCodePractice.StringManipulations;

public class MergeStringAlternate
{
    public string MergeAlternately(string word1, string word2)
    {
        var getMaxLength = word1.Length > word2.Length ? word1.Length : word2.Length;
        var result = string.Empty;
        for (int i = 0; i < getMaxLength; i++)
        {
            if (word1.Length > i)
            {
                result += word1[i];
            }
            if (word2.Length > i)
            {
                result += word2[i];
            }
        }

        return result;
    }
}