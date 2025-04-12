namespace LeetCodePractice.Recursion;

public class MaxNumbKPairs
{
    public MaxNumbKPairs()
    {
        Console.WriteLine(MaxOperations([1,4,4,3,2,5], 5));
    }

    public int MaxOperations(int[] nums, int k)
    {
        if (nums.Length == 0) return 0;
        var result = 0;
        // sort the array
        var numsList = nums.ToList();
        numsList.Sort();
        var left = 0;
        var right = numsList.Count - 1;
        while (left < right)
        {
            // add 0th and last element
            var sum = numsList[left] + numsList[right];
            // if sum < k left++
            if (sum < k)
            {
                left++;
            }
            // else if sum > k right --
            else if (sum > k) right--;
            // else counter++ left++ r ight--
            else
            {
                result++;
                left++;
                right--;
            }
        }
        

        return result;
    }
    
    public int MaxOperationss(int[] nums, int k)
    {
        var flagger = new int[nums.Length];
        Array.Fill(flagger, 0);
        var result = 0;
        var left = 0;
        var right = left + 1;

        while (left < nums.Length - 1 && left + right < nums.Length + 1)
        {
            if (flagger[left] == 0 && flagger[right] == 0)
            {
                if (nums[left] + nums[right] == k)
                {
                    result++;
                    flagger[left] = 1;
                    flagger[right] = 1;
                    left++;
                    right = left;
                }
            }
            else
            {
                right = left;
            }

            right++;
            if (right == nums.Length)
            {
                left++;
                right = left + 1;
            }
        }

        return result;
    }
}