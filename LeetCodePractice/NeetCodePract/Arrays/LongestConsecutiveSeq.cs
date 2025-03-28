namespace LeetCodePractice.NeetCodePract;

public class LongestConsecutiveSeq
{
    public LongestConsecutiveSeq()
    {
        Console.WriteLine(LongestConsecutive([2, 20, 4, 10, 3, 4, 5]));
    }
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in numSet) {
            if (!numSet.Contains(num - 1)) {
                int length = 1;
                while (numSet.Contains(num + length)) {
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;     
    }
}