namespace LeetCodePractice.NeetCodePract.BackTracking;

public class WordExistsMatrix
{
    public WordExistsMatrix()
    {
        char[][] board =
        [
            ['A']
        ];
        var word = "A";
        Console.WriteLine(Exist(board, word));
    }
    private bool Exist(char[][] board, string word)
    {
        bool[,] visited = new bool[board.Length, board[0].Length];
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (Iterate(i, j, word, board, "", visited))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool Iterate(int i, int j, string word, char[][] board, string testWord, bool[,] hashSet)
    {
        if (string.Compare(word, testWord) == 0)
        {
            return true;
        }
        if (i < 0 || j < 0) return false;
        if (i >= board.Length || j >= board[0].Length) return false;
        if (hashSet[i, j]) return false;
        
        if (testWord.Length >= word.Length) return false;

        hashSet[i, j] = true;
        testWord += board[i][j];
        var result = Iterate(i + 1, j, word, board, testWord,hashSet) || Iterate(i - 1, j, word, board, testWord,hashSet) || Iterate(i, j + 1, word, board, testWord,hashSet) || Iterate(i, j - 1, word, board, testWord,hashSet);
        hashSet[i, j] = false;
        return result;
    }
}