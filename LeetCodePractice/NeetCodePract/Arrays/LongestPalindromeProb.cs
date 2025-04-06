namespace LeetCodePractice.NeetCodePract;

public class LongestPalindromeProb
{
    public LongestPalindromeProb()
    {
        var result = LongestPalindrome("abbc");
    }
    public string LongestPalindrome(string s) 
    {
        //for loops n^2
        var maxSubArray = string.Empty;
        for(int i = 0; i < s.Length; i++){
            for(int j = 1; j <= s.Length - i; j++){
                var subStringS = s.Substring(i, j);
                if(IsPalindrome(subStringS) && maxSubArray.Length < subStringS.Length){
                    maxSubArray = subStringS;
                }
            }
        }  

        return maxSubArray;      
    }

    private bool IsPalindrome(string input)
    {        
        var inputCharArray = input.ToCharArray();
        var left = 0;
        var right = input.Length - 1;
        while(left < right){
            if(inputCharArray[left] != inputCharArray[right]) return false;
            left++;
            right--;
        }

        return true;

    }
}