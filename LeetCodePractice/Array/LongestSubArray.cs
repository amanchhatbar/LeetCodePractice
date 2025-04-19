namespace LeetCodePractice.Recursion;

public class LongestSubArray
{
    public LongestSubArray()
    {
        LongestSubarray([1, 1, 0, 1]);
    }
    public int LongestSubarray(int[] nums) {
        // keep track of the left to be the first replacement or 1
        // right will loop through until it finds the next 0
        var left = 0;
        var right = 0;
        var maxLength = 0;
        var tempMax = 0;
        var numberOf0s = 0;
        while(left < nums.Length && right < nums.Length){
            if(numberOf0s < 1 || nums[right] == 1){
                if(nums[right]== 0) numberOf0s++;
                tempMax++;
            }
            else{
                left++;
                right = left;
                tempMax = 0;
            }
            maxLength = Math.Max(maxLength, tempMax);
            right++;
        }

        return maxLength - numberOf0s;
    }
}