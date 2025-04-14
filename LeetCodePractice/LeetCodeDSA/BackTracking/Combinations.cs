namespace LeetCodePractice.LeetCodeDSA.BackTracking;

public class Combinations
{
    public Combinations()
    {
        var result = Combine(4, 2);
    }
    
    public IList<IList<int>> Combine(int n, int k)
    {
        var nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = i + 1;
        }

        var finalList = new List<IList<int>>();
        Recursion(0, finalList, new List<int>(), nums, k);
        return finalList;
    }

    public void Recursion(int start, List<IList<int>> finalList, List<int> current, int[] nums, int k){
        if(current.Count == k) {
            finalList.Add(new List<int>(current));
            return;
        }
        
        for(int i = start; i < nums.Length; i++)
        {
            if (!current.Contains(nums[i]))
            {
                current.Add(nums[i]);
                Recursion(i, finalList, current, nums, k);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}