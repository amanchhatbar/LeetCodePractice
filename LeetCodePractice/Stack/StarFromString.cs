namespace LeetCodePractice.Stack;

public class StarFromString
{
    public string RemoveStars(string s)
    {
        var sCharArray = s.ToCharArray();
        var stackBucket = new Stack<char>();
        for (int i = 0; i < sCharArray.Length; i++)
        {
            if (sCharArray[i] == '*')
            {
                if(stackBucket.Count > 0) stackBucket.Pop();
            }
            else
            {
                stackBucket.Push(sCharArray[i]);
            }
        }

        var resultCharArray = new char[stackBucket.Count];
        var maxLength = stackBucket.Count - 1;
        while (stackBucket.TryPop(out var result))
        {
            resultCharArray[maxLength] = result;
            maxLength--;
        }

        var resultString = string.Empty;
        foreach (var resultChar in resultCharArray)
        {
            resultString += resultChar;
        }

        return resultString;
    }
}