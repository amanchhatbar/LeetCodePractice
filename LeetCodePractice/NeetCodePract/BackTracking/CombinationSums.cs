namespace LeetCodePractice.NeetCodePract.BackTracking;

public class CombinationSums
{
    public CombinationSums()
    {
        CombinationSum([2, 5, 6, 9], 9);
    }
    public List<List<int>> CombinationSum(int[] candidates, int target) {
        var finalResult = new List<List<int>>();
        FindCombinations(candidates, target, new List<int>(), finalResult, 0);
        return finalResult;
    }

    private void FindCombinations(int[] candidates, int target, List<int> current, List<List<int>> finalResult, int start) {
        if (target == 0) {
            finalResult.Add(new List<int>(current)); // Store a copy of current combination
            return;
        }

        for (int i = start; i < candidates.Length; i++) {
            if (candidates[i] <= target) { 
                current.Add(candidates[i]); // Choose
                FindCombinations(candidates, target - candidates[i], current, finalResult, i); // Explore
                current.RemoveAt(current.Count - 1); // Undo choice (backtrack)
            }
        }
    }
}