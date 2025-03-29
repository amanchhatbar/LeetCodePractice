namespace LeetCodePractice.NeetCodePract.BinarySearch;

public class BinarySearchProgram
{
    public BinarySearchProgram()
    {
        Search([-1, 0, 2, 4, 6, 8], 6);
    }
    public int Search(int[] nums, int target)
    {
        var result = BinarySearch(0, nums.Length - 1, nums, target);
        return result;
    }
    
    private int BinarySearch(int l, int r, int[] nums, int target)
    {
        if(l < 0 || r < 0) return -1;
        if(l > nums.Length || r > nums.Length) return -1;
        if(nums[l] == target || nums[r] == target) {
            if(nums[l] == target) {
                return l; 
            }
            else{
                return r;
            }
        }
        if(r - l == 1) return -1;
        var m = l + (r-l)/2;    
        return nums[m] > target ?  BinarySearch(l, m, nums, target) :  BinarySearch(m, r, nums, target);
    }
}