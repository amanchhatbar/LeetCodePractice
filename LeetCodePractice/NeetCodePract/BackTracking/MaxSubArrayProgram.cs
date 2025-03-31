namespace LeetCodePractice.NeetCodePract.BackTracking;

public class MaxSubArrayProgram
{
    public MaxSubArrayProgram()
    {
        Console.WriteLine(MaxSubArray([2, -3, 4, -2, 2, 1, -1, 4]));
    }
    public static int MaxSubArray(int[] nums)
    {
        int maxSoFar = nums[0]; // Stores the maximum sum found so far
        int maxEndingHere = nums[0]; // Stores the sum including the current element

        for (int i = 1; i < nums.Length; i++)
        {
            maxEndingHere = Math.Max(nums[i], maxEndingHere + nums[i]); //Important logic.
            maxSoFar = Math.Max(maxSoFar, maxEndingHere);
        }

        return maxSoFar;
    }
}