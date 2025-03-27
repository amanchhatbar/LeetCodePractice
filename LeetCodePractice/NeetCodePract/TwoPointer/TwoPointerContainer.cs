namespace LeetCodePractice.NeetCodePract.TwoPointer;

public class TwoPointerContainer
{
    public TwoPointerContainer()
    {
        Console.WriteLine(MaxArea([1, 7, 2, 5, 4, 7, 3, 6]));
    }

    public int MaxArea(int[] heights)
    {
        var maxArea = Int32.MinValue;
        for (int i = 0; i < heights.Length; i++)
        {
            for (int j = i + 1; j < heights.Length; j++)
            {
                var tempLimit = heights[i] > heights[j] ? heights[j] : heights[i];
                var tempArea = tempLimit * (j - i);
                if (tempArea > maxArea)
                {
                    maxArea = tempArea;
                }
            }
        }

        return maxArea;
    }
}