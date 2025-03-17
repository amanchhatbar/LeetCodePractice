namespace LeetCodePractice.Recursion;

public class Subsequence
{
    public bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        {
            return false;
        }
        var sCharArray = s.ToCharArray();
        var tCharArray = t.ToCharArray();
        var sCounter = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if (tCharArray[i] == sCharArray[sCounter])
            {
                sCharArray[sCounter] = '1';
                sCounter++;
            }
        }

        return sCharArray.ToList().All(x => x == '1');
    }
}