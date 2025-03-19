namespace LeetCodePractice.Recursion;

public class ArrayZeroMinOperations
{
    public int MinimumOperations(int[] nums)
    {
        var allZeroes = false;
        var counter = 0;
        while (!allZeroes)
        {
            var smallestValue = int.MaxValue;
            var numberofZeroes = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    if (smallestValue > nums[i])
                    {
                        smallestValue = nums[i];
                    }
                }
                else
                {
                    numberofZeroes++;
                }
            }

            if (numberofZeroes == nums.Length)
            {
                break;
            }

            counter++;
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != 0)
                {
                    nums[j] = nums[j] - smallestValue > 0 ? nums[j] - smallestValue : 0;
                }
            }
        }

        return counter;
    }
}