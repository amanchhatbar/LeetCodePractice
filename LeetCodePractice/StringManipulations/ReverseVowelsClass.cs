using System.Collections;

namespace LeetCodePractice.StringManipulations;

public class ReverseVowelsClass
{
    private readonly List<char> vowels = new List<char>()
    {
        'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'
    };
    public string ReverseVowels(string s)
    {
        // 0 1 2 3 4 5
        var vowelStack = new Stack<char>();
        var sCharArray = s.ToCharArray();
        foreach (var sChar in sCharArray)
        {
            if (vowels.Contains(sChar))
            {
                vowelStack.Push(sChar);
            }
        }

        for (int i = 0; i < sCharArray.Length; i++)
        {
            if (vowels.Contains(sCharArray[i]))
            {
                var poppedStack = vowelStack.Pop();
                sCharArray[i] = poppedStack;
            }
        }

        var finalResult = string.Empty;
        for (int i = 0; i < sCharArray.Length; i++)
        {
            finalResult += sCharArray[i];
        }
        return finalResult;
    }
}