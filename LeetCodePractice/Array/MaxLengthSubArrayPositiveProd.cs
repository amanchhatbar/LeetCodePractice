namespace LeetCodePractice.Recursion;

public class MaxLengthSubArrayPositiveProd
{
    public MaxLengthSubArrayPositiveProd()
    {
        Console.Write(GetMaxLen([-1,-2,-3,0,1]));
    }
    public int GetMaxLen(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var maxProduct = nums[0];
        var minProduct = nums[0];
        var result = nums[0];
        var counter = 0;
        var tempMax = 0;
        foreach (var num in nums)
        {
            if (num < 0)
            {
                (maxProduct, minProduct) = (minProduct, maxProduct);
            }

            maxProduct = Math.Max(num, maxProduct * num);
            minProduct = Math.Max(num, minProduct * num);
            if (result < maxProduct)
            {
                result = maxProduct;
                counter++;
            }
        }

        return result;
    }
}