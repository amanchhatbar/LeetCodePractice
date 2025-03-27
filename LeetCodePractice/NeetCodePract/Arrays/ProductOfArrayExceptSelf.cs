namespace LeetCodePractice.NeetCodePract;

public class ProductOfArrayExceptSelf
{
    public ProductOfArrayExceptSelf()
    {
        ProductExceptSelf([1, 2, 4, 6]);
    }
    
    public int[] ProductExceptSelf(int[] nums)
    {
        var leftArray = new int[nums.Length];
        leftArray[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            var temp = leftArray[i - 1] * nums[i - 1];
            leftArray[i] = temp;
        }
        
        var rightArray = new int[nums.Length];
        rightArray[nums.Length - 1] = 1;
        for (int i = nums.Length-2; i >=0 ; i--)
        {
            var temp = rightArray[i + 1] * nums[i + 1];
            rightArray[i] = temp;
        }

        var result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = leftArray[i] * rightArray[i];
        }

        return result;
    }
}