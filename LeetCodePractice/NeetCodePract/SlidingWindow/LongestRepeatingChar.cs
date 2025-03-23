namespace LeetCodePractice.NeetCodePract.SlidingWindow;

public class LongestRepeatingChar
{
    public LongestRepeatingChar()
    {
        Console.WriteLine(CharacterReplacement("XYYX", 2));
    }
    public int CharacterReplacement(string s, int k)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        var leftP = 0;
        var rightP = 1;
        
        //Count number of each character and decide which one to use as replacement.
        var sCharArray = s.ToCharArray();
        var dict = new Dictionary<char, int>();
        foreach (var sChar in sCharArray)
        {
            if(!dict.ContainsKey(sChar)) dict.Add(sChar, 0);
            dict[sChar]++;
        }
        //start comparing with left and right
        var replaceableChar = dict.OrderByDescending(x => x.Value).First().Key;
        var hashSet = new HashSet<char>();
        hashSet.Add(sCharArray[leftP]);
        var maxCount = 1;
        var tempK = k;
        while (rightP < sCharArray.Length)
        {
            if (sCharArray[rightP] == replaceableChar && tempK > 0)
            {
                maxCount++;
                tempK--;
            }
            else if (!hashSet.Contains(sCharArray[rightP]))
            {
                hashSet.Add(sCharArray[rightP]);
                if (maxCount < hashSet.Count)
                {
                    maxCount = hashSet.Count;
                }
            }
            else
            {
                hashSet = new HashSet<char>();
                leftP++;
                rightP = leftP;
                tempK = k;
            }

            rightP++;
        }

        return maxCount;

    }
}