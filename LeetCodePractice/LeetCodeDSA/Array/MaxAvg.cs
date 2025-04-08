namespace LeetCodePractice.LeetCodeDSA.Array;

public class MaxAvg
{
    public MaxAvg()
    {
        Console.WriteLine(FindMaxAverageSlidingWindow([4,0,4,3,3], 5));
    }
    public double FindMaxAverage(int[] nums, int k) {
        var left = 0;
        decimal maxAvg = Int32.MinValue;
        
        while(left <= nums.Length - k){
            decimal tempAvg = 0;
            decimal tempSum = 0;
            for(int i = left; i < left+k; i++){
                tempSum += nums[i];
            }
            tempAvg = tempSum / k;
            maxAvg = Math.Max(maxAvg, tempAvg);
            left++;
        }
        
        return (double)maxAvg;
    }

    public double FindMaxAverageSlidingWindow(int[] nums, int k)
    {
        var left = 0;
        var right = k;
        double sum = 0;
        double maxAverage = 0;
        for (int i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        maxAverage = sum / k;
        while (right < nums.Length)
        {
            sum += nums[right];
            sum -= nums[left];
            double newAvg = sum / k;
            maxAverage = Math.Max(newAvg, maxAverage);
            left++;
            right++;
        }


        return maxAverage;
    }
}