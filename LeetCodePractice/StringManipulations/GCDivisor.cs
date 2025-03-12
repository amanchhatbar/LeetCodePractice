namespace LeetCodePractice.StringManipulations;

public class GCDivisor
{
    public bool GcdOfStrings(string str1, string str2) {
        
        if (string.IsNullOrEmpty(str1) 
            || string.IsNullOrEmpty(str2) 
            || str1.Length % str2.Length != 0)
        {
            return false;
        }

        var str1Str2 = str1 + str2;
        var str2Str1 = str2 + str1;

        return str1Str2 != str2Str1;
    }
}