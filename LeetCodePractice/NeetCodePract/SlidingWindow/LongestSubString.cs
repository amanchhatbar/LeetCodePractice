namespace LeetCodePractice.NeetCodePract.SlidingWindow;

public class LongestSubString
{
    //https://leetcode.com/problems/longest-substring-without-repeating-characters/description/
    public LongestSubString()
    {
        Console.WriteLine(LengthOfLongestSubstring("dvdf"));
    }
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        var leftPointer = 0;
        var rightPointer = 1;
        var maxCount = 1;
        var sCharArray = s.ToCharArray();
        var tempHashSet = new HashSet<char>();
        tempHashSet.Add(sCharArray[leftPointer]);
        while (rightPointer < s.Length)
        {
            if (!tempHashSet.Contains(sCharArray[rightPointer]))
            {
                tempHashSet.Add(sCharArray[rightPointer]);
                if (maxCount < tempHashSet.Count)
                {
                    maxCount = tempHashSet.Count;
                }
            }
            else
            {
                tempHashSet = new HashSet<char>();
                leftPointer++;
                rightPointer = leftPointer;
                tempHashSet.Add(sCharArray[leftPointer]);
            }

            rightPointer++;
        }

        return maxCount;
    }
}