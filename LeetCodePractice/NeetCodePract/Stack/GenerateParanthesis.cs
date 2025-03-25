namespace LeetCodePractice.Stack;

public class GenerateParanthesis
{
    public GenerateParanthesis()
    {
        GenerateParenthesis(3);
    }
    public List<string> GenerateParenthesis(int n) 
    {
        List<string> res = new List<string>();
        string stack = ""; 
        CreateParenthesisBT(0, 0, n, res, stack);
        return res;  
    }

    private void CreateParenthesisBT(int leftN, int rightN, int n, List<string> result, string temp)
    {
        
        if(leftN == rightN && leftN == n && rightN == n){
            result.Add(temp);
            return;
        }
        
        if(leftN < n){
            CreateParenthesisBT(leftN+1, rightN, n, result, temp+"(");
        }
        
        
        if(leftN > rightN){
            CreateParenthesisBT(leftN, rightN+1, n, result, temp+")");
        }        
    }
}