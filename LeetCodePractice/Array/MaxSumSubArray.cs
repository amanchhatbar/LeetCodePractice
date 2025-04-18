namespace LeetCodePractice.Recursion;

//https://leetcode.com/problems/sum-of-subarray-ranges/?envType=problem-list-v2&envId=7p5x763
public class MaxSumSubArray
{
    public MaxSumSubArray()
    {
        SubArrayRanges([1, 2, 3]);
    }
    public long SubArrayRanges(int[] nums) {
        var result = Subsets(nums);
        return 0;
    }

    public int Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        var finalResult = 0;
        res.Add(new List<int>());
        foreach (int num in nums) {
            int size = res.Count;
            for (int i = 0; i < size; i++) {
                List<int> subset = new List<int>(res[i]);
                subset.Add(num);
                var max = subset.OrderDescending().First();
                var min = subset.OrderBy(x => x).First();
                res.Add(subset);
                finalResult += (max - min);
            }
        }
        return finalResult;
    }
}