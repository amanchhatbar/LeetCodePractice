namespace LeetCodePractice.LeetCodeDSA.Array;

public class KRadiusSubArray
{
//https://leetcode.com/problems/k-radius-subarray-averages/description/
    public KRadiusSubArray()
    {
        GetAverages([1000], 100000000);
    }
    
    public int[] GetAverages(int[] nums, int k) 
    {
        var result = new int[nums.Length];
        var divisor = (k*2)+1;
        for(int i = 0; i < nums.Length; i++)
        {
            var temp = 0;
            if(i - k >= 0 && i + k < nums.Length){
                for(int j = i-k; j <= i+k; j++){
                    temp+=nums[j];
                }
                
                result[i] = (int)(temp/divisor);
                temp = 0;
            }
            else{
                result[i] = -1;
            }
        }
        return result;
    }
}