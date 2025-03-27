namespace LeetCodePractice.NeetCodePract.TwoPointer;

public class ThreeSumProblem
{
    public ThreeSumProblem()
    {
        var result = ThreeSum([0,0,0]);
    }
    public List<List<int>> ThreeSum(int[] nums)
    {
        var result = new List<List<int>>();
        var numsList = nums.ToList();
        numsList.Sort();
        var alreadyProcessedList = new HashSet<int>();
        var hashSetStringify = new HashSet<string>();
        
        //go through each input and use 2 sum later.
        var left = 0;
        var right = numsList.Count - 1;
        for (int i = 0; i < numsList.Count; i++)
        {
            left = i + 1;
            right = numsList.Count - 1;
            if (alreadyProcessedList.Contains(numsList[i])) continue;
            while (left <= right)
            {
                if (numsList[i] + numsList[left] + numsList[right] == 0 && !hashSetStringify.Contains(numsList[i].ToString()+numsList[left].ToString()+numsList[right].ToString()))
                {
                    result.Add(new List<int>() { numsList[i], numsList[left], numsList[right] });
                    hashSetStringify.Add(numsList[i].ToString() + numsList[left].ToString() + numsList[right].ToString());
                }

                if (numsList[left] + numsList[right] > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            alreadyProcessedList.Add(numsList[i]);
        }
        return result;
    }
}