namespace LeetCodePractice.Stack;

public class ValidParanthesis
{
    public ValidParanthesis()
    {
        Console.WriteLine(IsValid("([]{})"));
    }
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        var stack = new Stack<char>();
        var sCharArray = s.ToCharArray();

        foreach (var sChar in sCharArray)
        {
            if (stack.Count > 0)
            {
                var stackTopValue = stack.Peek();
                if ((stackTopValue == '(' && sChar == ')' )
                    || (stackTopValue == '{' && sChar == '}') 
                    || (stackTopValue == '[' && sChar == ']'))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(sChar);
                }
            }
            else
            {
                stack.Push(sChar);
            }
        }

        return stack.Count == 0;
    }
}