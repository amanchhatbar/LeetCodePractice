namespace LeetCodePractice.StringManipulations;

public class ReverseWords
{
    public string ReverseWordsFunction(string s)
    {
        var sCharArray = s.ToCharArray();
        var tempWord = string.Empty;
        var wordStack = new Stack<string>();
        foreach (var sChar in sCharArray)
        {
            if (sChar == ' ' && !string.IsNullOrWhiteSpace(tempWord) && !string.IsNullOrEmpty(tempWord))
            {
                wordStack.Push(tempWord.Trim());
                tempWord = String.Empty;
            }
            else
            {
                tempWord += sChar;    
            }
        }
        wordStack.Push(tempWord.Trim());
        var finalWord = string.Empty;
        while (wordStack.TryPop(out string result))
        {
            finalWord += " " + result;
        }

        return finalWord.Trim();
    }
}