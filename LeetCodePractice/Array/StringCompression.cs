namespace LeetCodePractice.Recursion;

public class StringCompression
{
    //TODO: Need to come back to solve this.
    public int Compress(char[] chars)
    {
        int j = 0;
        for (int i = 1; i < chars.Length; i++)
        {
            if (chars[i] == chars[j])
            {
                if (int.TryParse(chars[j+1].ToString(), out int res))
                {
                    var temp = res + 1;
                    chars[j + 1] = Convert.ToChar(temp);
                    // chars[i] = ' ';
                }
                else
                {
                    chars[i] = '2';
                }
            }
            else
            {
                j = i;
                chars[j] = chars[i];
            }
        }

        var tempCounter = 0;
        foreach (var character in chars)
        {
            if (character != ' ')
            {
                
            }
        }
        return 1;
    }
}