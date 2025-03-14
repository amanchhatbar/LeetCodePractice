namespace LeetCodePractice.Recursion;

public class ProductOfArraySelf
{
    public int[] ProductExceptSelf(int[] nums) 
    {
        // Sliding window
        //left product
        var leftArray = new int[nums.Length];
        leftArray[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            var tempProduct = leftArray[i - 1] * nums[i - 1];
            leftArray[i] = tempProduct;
        }
        //right product
        var rightArray = new int[nums.Length];
        rightArray[nums.Length - 1] = 1;
        for (int i = nums.Length - 2; i >= 0 ; i--)
        {
            var tempProduct = rightArray[i + 1] * nums[i + 1];
            rightArray[i] = tempProduct;
        }

        var result = new int[nums.Length];
        
        for (int i = 0; i < rightArray.Length; i++)
        {
            result[i] = leftArray[i] * rightArray[i];
        }
        return result;
    }
}