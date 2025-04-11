namespace LeetCodePractice.Recursion;

public class MaxLengthSubArrayPositiveProd
{
    public MaxLengthSubArrayPositiveProd()
    {
        Console.Write(GetMaxLen([1,-2,-3,4]));
    }
    public int GetMaxLen(int[] nums)
    {
        var maxValue = 0;
        var positive = 0;
        var negative = 0;

        for(int i = 0; i < nums.Length; i++){
            if(nums[i] > 0){
                positive+=1;
                negative = negative > 0 ? negative+1 : 0;
            }
            else if(nums[i] < 0){
                var temp = positive;
                positive = negative > 0 ? negative+1 : 0;
                negative = temp > 0 ? temp+1 : 1;
            }
            else{
                positive = 0;
                negative = 0;
            }
            maxValue = Math.Max(maxValue, positive);
        }

        return maxValue;
    }
}