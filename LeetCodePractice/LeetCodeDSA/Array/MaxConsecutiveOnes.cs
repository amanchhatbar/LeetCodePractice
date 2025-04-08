namespace LeetCodePractice.LeetCodeDSA.Array;

public class MaxConsecutiveOnes
{
    public MaxConsecutiveOnes()
    {
        Console.WriteLine(LongestOnes([0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1], 3));
    }
    public int LongestOnes(int[] nums, int k)
    {
        var left = 0;
        var flipsLeft = k;
        int right = 0;
        for (; right < nums.Length; right++)
        {
            if (nums[right] == 0) flipsLeft--;
            if (flipsLeft < 0)
            {
                left++;
                flipsLeft += 1 - nums[left];
            }
        }

        return right - left;
    }
}