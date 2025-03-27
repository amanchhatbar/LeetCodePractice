namespace LeetCodePractice.NeetCodePract;

public class TwoSumProblem
{
    public TwoSumProblem()
    {
        var result = TwoSum([5,5], 10);
    }

    public int[] TwoSum(int[] nums, int target)
    {
        var found = false;
        var result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1  ; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    found = true;
                    result[0] = i;
                    result[1] = j;
                    break;
                }
            }

            if (found) break;
        }

        return result;
    }
}