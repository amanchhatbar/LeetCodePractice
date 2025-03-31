namespace LeetCodePractice.Stack;

public class ValidBracketsStringStars
{
    public ValidBracketsStringStars()
    {
        CheckValidString("((**)");
    }
    public bool CheckValidString(string s) {
        // maintain two stacks
        // one will go through the brackets and push and pop
        // second will just use *s and will be used later.

        var sCharArray = s.ToCharArray();
        var normalStack = new Stack<char>();
        var starStack = new Stack<char>();
        normalStack.Push(sCharArray[0]);
        for (int i = 1; i < sCharArray.Length; i++)
        {
            if(sCharArray[i] == '(' && normalStack.Count > 0) normalStack.Push(sCharArray[i]);
            else if (sCharArray[i] == ')' && normalStack.Count > 0)
            {
                if (normalStack.Count == 0 && starStack.Count == 0) return false;
                if (normalStack.Count > 0) normalStack.Pop();
                else starStack.Pop();
            }
            else
            {
                starStack.Push(sCharArray[i]);
            }
        }

        while (normalStack.Count > 0 && starStack.Count > 0)
        {
            if (normalStack.Pop() > starStack.Pop()) return false;
        }
        return normalStack.Count == 0;
    }
}