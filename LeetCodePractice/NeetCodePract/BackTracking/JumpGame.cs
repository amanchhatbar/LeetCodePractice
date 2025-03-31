namespace LeetCodePractice.NeetCodePract.BackTracking;

public class JumpGame
{
    public JumpGame()
    {
        Console.WriteLine(CanJump([1,2,1,0,1]));
    }
    
    public bool CanJump(int[] nums)
    {
        int i = 0;
        while (i <= nums.Length-1)
        {
            if (i == nums.Length-1) return true;
            if (nums[i] == 0) return false;
            var temp = nums[i];
            i += temp;
        }

        return false;
    }
}