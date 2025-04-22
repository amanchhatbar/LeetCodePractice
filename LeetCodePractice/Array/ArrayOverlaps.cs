namespace LeetCodePractice.Recursion;

public class ArrayOverlaps
{
    public ArrayOverlaps()
    {
        EraseOverlapIntervals([[-52,31],[-73,-26],[82,97],[-65,-11],[-62,-49],[95,99],[58,95],[-31,49],[66,98],[-63,2],[30,47],[-40,-26]]);
    }
    public int EraseOverlapIntervals(int[][] intervals) {
        //overlapping means end time > start time
        //sort the array first then compare adjacent
        var sortedArray = intervals.OrderBy(x => x[1]).ToList();
        //have 2 pointers -> left and right
        var left = 0;
        var right = 1;
        // left = 0 and right = 1
        // compare left and right and keep incrementing right if there is an overlap
        var result = 0;
        while (left < intervals.Length && right < intervals.Length)
        {

            if (sortedArray[left][1] > sortedArray[right][0])
            {
                var leftva = sortedArray[left][1];
                var rightVa = sortedArray[right][0];
                result++;
            }
            else
            {
                left = right;
            }

            right++;
        }
        // else make left = right
        return result;
    }
}