namespace LeetCodePractice.NeetCodePract.BackTracking;

public class WordExistsMatrix
{
    public WordExistsMatrix()
    {
        char[][] board =
        [
            ['A', 'B', 'C', 'D'],
            ['S', 'A', 'A', 'T'],
            ['A', 'C', 'A', 'E']
        ];
        var word = "CAT";
        Console.WriteLine(Exist(board, word));
    }
    private bool Exist(char[][] board, string word) 
    {
        
    }

    private bool Iterate(string testingWord, char[][] board, string word)
    {
        if (string.Compare(testingWord, word) == 0) return true;
        if (testingWord.Length > word.Length) return false;
        
        
    }
}