namespace LeetCodePractice.NeetCodePract.TwoPointer;

public class TwoIntSum
{
    public TwoIntSum()
    {
        var result = TwoSum([1, 2, 3, 4], 3);
    }
    public int[] TwoSum(int[] numbers, int target)
    {
        var result = new int[2];
        var left = 0;
        var right = numbers.Length - 1;
        while (left <= right)
        {
            var tempSum = numbers[left] + numbers[right];
            if (tempSum == target)
            {
                result[0] = left + 1;
                result[1] = right + 1;
                break;
            }
            if (target < tempSum)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return result;
    }
}