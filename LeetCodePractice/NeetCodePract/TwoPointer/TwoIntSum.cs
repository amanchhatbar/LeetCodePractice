namespace LeetCodePractice.NeetCodePract.TwoPointer;

public class TwoIntSum
{
    public TwoIntSum()
    {
        var result = TwoSum([1, 2, 3, 4], 3);
    }
    public int[] TwoSum(int[] numbers, int target)
    {
        var numDictionary = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            var difference = target - numbers[i];
            if (numDictionary.ContainsKey(difference)) return new[] { numbers[i], difference };
            numDictionary[numbers[i]] = i;
        }

        return new int[2];
    }
}