namespace LeetCodePractice.StringManipulations;

public class StringCompression
{
    //TODO: come back to this later.
    public StringCompression()
    {
        Console.WriteLine(Compress(['a','b','b','b','b','b','b','b','b','b','b','b','b']));
    }
    
    public int Compress(char[] chars)
    {
        var result = new List<string>();
        var left = 0;
        var right = 1;
        var temporaryCounter = 1;
        while (right <= chars.Length)
        {
            if (right == chars.Length)
            {
                result.Add(chars[left].ToString());
                result.Add(temporaryCounter.ToString());
                break;
            }
            if (chars[left] == chars[right])
            {
                temporaryCounter++;
            }
            else
            {
                result.Add(chars[left].ToString());
                if (temporaryCounter != 1)
                {
                    result.Add(temporaryCounter.ToString());
                }
                
                left = right;
                temporaryCounter = 1;
            }

            right++;
        }
        var resultString = string.Join("", result);
        var length = resultString.Length;
        chars = resultString.ToCharArray();
        
        return length;
    }
}