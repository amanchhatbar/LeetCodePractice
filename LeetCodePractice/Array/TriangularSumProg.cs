namespace LeetCodePractice.Recursion;

public class TriangularSumProg
{
    public TriangularSumProg()
    {
        Console.WriteLine(TriangularSum([1, 2, 3, 4, 5]));
    }
    
    public int TriangularSum(int[] nums)
    {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        var result = nums.ToList();
        while (result.Count != 1)
        {
            var temp = new List<int>();
            for (int i = 0; i < result.Count - 1; i++)
            {
                temp.Add((result[i] + result[i + 1]) % 10);
            }

            result = temp;
        }


        return result[0];
    }
}