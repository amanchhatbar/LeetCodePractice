namespace LeetCodePractice.Recursion;

public class PhoneLetterCombinations
{
    public PhoneLetterCombinations()
    {
        LetterCombinations("23");
    }

    private IList<string> answer;

    private List<List<char>> words = new()
    {
        new List<char>(),
        new List<char>(),
        new List<char> { 'a', 'b', 'c' },
        new List<char> { 'd', 'e', 'f' },
        new List<char> { 'g', 'h', 'i' },
        new List<char> { 'j', 'k', 'l' },
        new List<char> { 'm', 'n', 'o' },
        new List<char> { 'p', 'q', 'r', 's' },
        new List<char> { 't', 'u', 'v' },
        new List<char> { 'w', 'x', 'y', 'z' }
    };

    public IList<string> LetterCombinations(string digits)
    {
        //permutations
        answer = new List<string>();
        Backtrack(0, digits, new List<char>());

        return answer;
    }

    private void Backtrack(int idx, string digits, List<char> lst)
    {
        if (idx == digits.Length)
        {
            if (lst.Count > 0)
            {
                string res = new string(lst.ToArray());
                answer.Add(res);
            }

            return;
        }

        int num = digits[idx] - '0';
        for (int i = 0; i < words[num].Count; i++)
        {
            lst.Add(words[num][i]);
            Backtrack(idx + 1, digits, lst);
            lst.RemoveAt(lst.Count - 1);
        }
    }
}