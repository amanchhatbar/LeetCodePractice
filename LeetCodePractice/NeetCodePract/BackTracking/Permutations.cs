namespace LeetCodePractice.NeetCodePract.BackTracking;

public class Permutations
{

    public Permutations()
    {
        Permute([1, 2, 3]);
    }
    public List<List<int>> Permute(int[] nums)
    {
        var finalList = new List<List<int>>();
        
        CreatePermutation(nums[0], nums, finalList, new List<int>());
        return finalList.ToList();
    }

    private void CreatePermutation(int num, int[] nums, List<List<int>> finalList, List<int> current)
    {
        if (current.Count == nums.Length)
        {
            //Check if there are dups
            finalList.Add(new List<int>(current));
            return;
        }

        foreach (var number in nums)
        {
            if (!current.Contains(number))
            {
                current.Add(number);
                CreatePermutation(number, nums, finalList, current);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}