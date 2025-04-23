namespace LeetCodePractice.Recursion;

public class CombinationSumThree
{
    public CombinationSumThree()
    {
        CombinationSum3(3, 7);
    }
    public IList<IList<int>> CombinationSum3(int k, int n) {
        var input = new int[9];
        for(int i = 1; i < 10; i++){
            input[i-1] = i;
        }

        var finalList = new List<IList<int>>();

        Recursive(finalList, new List<int>(), input, k, n, 0);

        return finalList;
    }


    private void Recursive(List<IList<int>> finalList, List<int> currentList, int[] input, int maxCount, int target, int start)
    {
        if (currentList.Count == maxCount)
        {
            if(target == 0)
            {
                finalList.Add(new List<int>(currentList));
            }
            return;
        }
        

        for(int i = start; i < input.Length; i++){
            if(input[i] <= target && !currentList.Contains(input[i])){
                currentList.Add(input[i]);
                Recursive(finalList, currentList, input, maxCount, target - input[i], i);
                currentList.RemoveAt(currentList.Count - 1);
            }
        }
    }
    
}