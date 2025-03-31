namespace LeetCodePractice.NeetCodePract;

public class TwoSumProblem
{
    public TwoSumProblem()
    {
        var result = TwoSumHashMap([5,5], 10);
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


    private int[] TwoSumHashMap(int[] nums, int target)
    {
        var dictionaryData = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            var difference = target-nums[i];
            if(dictionaryData.TryGetValue(difference, out var value)) {
                return new int[] {value, i};
            }
            dictionaryData[nums[i]] = i;
        }

        return new int[2];
    }
}