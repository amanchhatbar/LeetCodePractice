namespace LeetCodePractice.Recursion;

public class Container
{
    public int MaxArea(int[] height)
    {
        var area = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i + 1; j < height.Length; j++)
            {
                var minHeight = Math.Min(height[i], height[j]);
                var breadth = j - i;
                var tempArea = minHeight * breadth;
                if (tempArea > area)
                {
                    area = tempArea;
                }
            }
        }

        return area;
    }
}