using LeetCodePractice.Domain;

namespace LeetCodePractice.Stack;

public class MinStack
{
    private Stack<int> stack;
    public MinStack()
    {
        stack = new Stack<int>();
    }
    
    public void Push(int val) 
    {
        stack.Push(val);
    }
    
    public void Pop()
    {
        stack.TryPop(out int result);
    }
    
    public int Top()
    {
        stack.TryPeek(out var result);
        return result;
    }
    
    public int GetMin()
    {
        Stack<int> temporary = new Stack<int>();
        var result = temporary.Peek();
        while (stack.Count > 0)
        {
            var poppedValue = stack.Pop();
            if (poppedValue < result)
            {
                result = poppedValue;
            }
            temporary.Push(poppedValue);
        }
        
        while (temporary.Count > 0)
        {
            var poppedValue = temporary.Pop();
            stack.Push(poppedValue);
        }
        return result;
    }
}