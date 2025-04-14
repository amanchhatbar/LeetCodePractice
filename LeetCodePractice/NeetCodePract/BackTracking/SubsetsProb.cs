namespace LeetCodePractice.NeetCodePract.BackTracking;

public class SubsetsProb
{
    public SubsetsProb()
    {
        var result = new List<List<int>>();
        SubsetsRecursive(result, 0, [1, 2, 3], new List<int>());
    }
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        res.Add(new List<int>());
        foreach (int num in nums) {
            int size = res.Count;
            for (int i = 0; i < size; i++) {
                List<int> subset = new List<int>(res[i]);
                subset.Add(num);
                res.Add(subset);
            }
        }
        return res;
    }

    public void SubsetsRecursive(List<List<int>> answer, int i, int[] nums, List<int> current)
    {
        if (i > nums.Length) return;

        answer.Add(new List<int>(current));
        for (int j = i; j < nums.Length; j++)
        {
            current.Add(nums[j]);
            SubsetsRecursive(answer, j+1, nums, current);
            current.RemoveAt(current.Count - 1);
        }

    }
}