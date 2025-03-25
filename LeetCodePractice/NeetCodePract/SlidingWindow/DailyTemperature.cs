namespace LeetCodePractice.NeetCodePract.SlidingWindow;

public class DailyTemperature
{
    public DailyTemperature()
    {
        var testing = DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]);
    }

    public int[] DailyTemperatures(int[] temperatures)
    {
        var left = 0;
        var right = 1;
        var result = new int[temperatures.Length];
        var i = 0;
        while (left < temperatures.Length - 1)
        {
            if (right < temperatures.Length && temperatures[left] < temperatures[right])
            {
                var difference = right - left;
                result[i] = difference;
                i++;
                left++;
                right = left;
            }
            else if (right == temperatures.Length - 1)
            {
                result[i] = 0;
                i++;
                left++;
                right = left;
            }

            right++;
        }

        return result;
    }
}