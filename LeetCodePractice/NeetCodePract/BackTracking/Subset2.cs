namespace LeetCodePractice.NeetCodePract.BackTracking;

public class Subset2
{
    public Subset2()
    {
        var testing = SubsetsWithDup([1, 2, 1]);
        
    }
    
    public List<List<int>> SubsetsWithDup(int[] nums)
    {
        nums.ToList().Sort();
        var hashsetString = new HashSet<string>();
        var result = new List<List<int>>();
        result.Add(new List<int>());
        for (int i = 0; i < nums.Length; i++)
        {
            int size = result.Count;
            for (int j = 0; j < size; j++)
            {
                List<int> subset = new List<int>(result[j]);
                subset.Add(nums[i]);
                subset.Sort();
                var hashStringValue = new string(subset.Select(x => (char)x).ToArray());
                if (!hashsetString.Contains(hashStringValue))
                {
                    hashsetString.Add(hashStringValue);
                    result.Add(subset);
                }
               
            }
        }

        return result;
    }
}