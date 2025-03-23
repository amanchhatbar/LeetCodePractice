namespace LeetCodePractice.NeetCodePract.SlidingWindow;

public class PermutationString
{
    public PermutationString()
    {
        Console.WriteLine(CheckInclusion("adc", "dcda"));
    }
    private bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;
        var alphabetCharArray = Enumerable.Repeat('0', 26).ToArray();
        var s1MarkedOnes = MarkOnes(alphabetCharArray, s1);
        var windowLength = s1.Length;
        var left = 0;
        while (left <= s2.Length - windowLength)
        {
            alphabetCharArray = Enumerable.Repeat('0', 26).ToArray();
            var subString = s2.Substring(left, windowLength);
            var s2MarkedOnes = MarkOnes(alphabetCharArray, subString);
            if (string.Compare(s1MarkedOnes, s2MarkedOnes) == 0)
            {
                return true;
            }
            left++;
        }
        return false;
    }


    private string MarkOnes(char[] alphabetArray, string stringArray)
    {
        foreach (var input in stringArray)
        {
            var index = input - 'a';
            alphabetArray[index] = '1';
        }

        return (new string(alphabetArray));
    }
}