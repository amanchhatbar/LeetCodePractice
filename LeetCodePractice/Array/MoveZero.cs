namespace LeetCodePractice.Recursion;

public class MoveZero
{
    //Using Stacks
    public void MoveZeroes(int[] nums)
    {
        var zeroStacks = new Stack<int>();
        var numberStacks = new Stack<int>();
        var result = new List<int>();

        foreach (var num in nums)
        {
            if (num == 0)
            {
                zeroStacks.Push(num);
            }
            else
            {
                numberStacks.Push(num);
            }
        }

        while (numberStacks.TryPop(out int value))
        {
            result.Add(value);
        }
        
        while (zeroStacks.TryPop(out int value))
        {
            result.Add(value);
        }

        nums = result.ToArray();
    }

    public void MoveZeroesInPlace(int[] nums)
    {
        for (int k = 0; k < nums.Length; k++)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < nums.Length - 1; j++)
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
    }
    
}