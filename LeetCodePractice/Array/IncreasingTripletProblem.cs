namespace LeetCodePractice.Recursion;

public class IncreasingTripletProblem
{
    public bool IncreasingTriplet(int[] nums)
    {
        var result = new List<int>()
        {
            int.MaxValue,
            int.MaxValue,
            int.MaxValue,
        };
        
        //[2,1,5,0,4,6]
        var j = 0;
        var hasReplaced = false;
        for (int i = 0; i < nums.Length; i++)
        {
            for (j = 0; j < result.Count(); j++)
            {
                if (nums[i] < result[j])
                {
                    hasReplaced = true;
                    result[j] = nums[i];
                    break;
                }
            }

            if (hasReplaced)
            {
                for (int k = j + 1; k < result.Count(); k++)
                {
                    result[k] = int.MaxValue;
                }
            }
            hasReplaced = false;
        }

        return result.All(x => x != int.MaxValue);
    }
}