namespace LeetCodePractice.NeetCodePract.TwoPointer;

public class Palindrome
{
    public Palindrome()
    {
        IsPalindrome("No lemon, no melon");
    }
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        var refinedString = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        var i = 0;
        var j = refinedString.Length-1;
        var sChar = refinedString.ToCharArray();
        while (i != sChar.Length/2)
        {
            if (sChar[i] != sChar[j]) return false;
            i++;
            j--;
        }
        return true;
    }
}