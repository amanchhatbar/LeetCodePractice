namespace LeetCodePractice.Stack;

public class ReversePolish
{
    public ReversePolish()
    {
        Console.WriteLine(EvalRPN(["10","6","9","3","+","-11","*","/","*","17","+","5","+"]));
    }
    public int EvalRPN(string[] tokens)
    {
        var stackData = new Stack<int>();
        
        foreach (var token in tokens)
        {
            if (Int32.TryParse(token, out var result))
            {
                stackData.Push(result);
            }
            else
            {
                if (stackData.TryPop(out var val2) && stackData.TryPop(out var val1))
                {
                    var operationResult = 0;
                    switch (token)
                    {
                        case "+" : operationResult = val1 + val2;
                            break;
                        case "-": operationResult = val1 - val2;
                            break;
                        case "*" : operationResult = val1 * val2;
                            break;
                        case "/": operationResult = val1 / val2;
                            break;
                    }
                    stackData.Push(operationResult);
                } 
            }
        }

        return stackData.Pop();
    }
}