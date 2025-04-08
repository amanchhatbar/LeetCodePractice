namespace LeetCodePractice.LeetCodeDSA;

public class LongestCommonSubsequence
{
    public LongestCommonSubsequence()
    {
        LCS("abcde", "abce");
    }

    public int LCS(string text1, string text2)
    {
        var x = Recursive(0, 0, new Dictionary<(int, int), int>(), text1.ToCharArray(), text2.ToCharArray());
        return x;
    }

    private int Recursive(int i, int j, Dictionary<(int,int), int> memo, char[] text1Array, char[] text2Array)
    {
        if (i == text1Array.Length || j == text2Array.Length)
        {
            return 0;
        }

        if (memo.ContainsKey((i, j))) return memo[(i, j)];
        var answer = 0;
        if (text1Array[i] == text2Array[j])
        {
            answer = 1 + Recursive(i + 1, j + 1, memo, text1Array, text2Array);
        }
        else
        {
            answer = Math.Max(Recursive(i + 1, j, memo, text1Array, text2Array),
                Recursive(i, j + 1, memo, text1Array, text2Array));
        }

        memo[(i, j)] = answer;
        return answer;
    }
}