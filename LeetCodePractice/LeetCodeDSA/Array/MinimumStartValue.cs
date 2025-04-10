namespace LeetCodePractice.LeetCodeDSA.Array;

public class MinimumStartValue
{

    public MinimumStartValue()
    {
        Console.WriteLine(MinStartValue([1,-2,-3]));
    }
    public int MinStartValue(int[] nums)
    {
        if (nums.Length == 0) return 0;
        var counter = 1;
        var belowOne = false;
        var finalLength = 0;
        while (true)
        {
            var temp = counter;
            for (int i = 0; i < nums.Length; i++)
            {
                finalLength++;
                temp += nums[i];
                if (temp < 1)
                {
                    belowOne = true;
                }
            }

            if (!belowOne && finalLength == nums.Length)
            {
                return counter;
            }
            counter++;
            belowOne = false;
            finalLength = 0;
        }
    }
}