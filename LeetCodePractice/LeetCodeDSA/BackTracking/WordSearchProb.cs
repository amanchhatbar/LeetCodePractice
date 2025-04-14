namespace LeetCodePractice.LeetCodeDSA.BackTracking;

public class WordSearchProb
{
    public WordSearchProb()
    {
        Console.WriteLine(Exist([['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']], "ABCCED"));
    }
    public bool Exist(char[][] board, string word)
    {
        var directions = new List<(int x, int y)>() { (-1, 0), (0, 1), (0, -1), (1, 0) };
        var wordCharArray = word.ToCharArray();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                var current = new List<string>() { board[i][j].ToString() };
                // var hashSet = new HashSet<(int, int)>() { (i, j) };
                var currentIJ = new List<(int, int)>();
                currentIJ.Add((i, j));
                if (Explore(i, j, board, word, directions, current, currentIJ))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private bool Explore(int i, int j, char[][] board, string word, List<(int x, int y)> directions, List<string> current, List<(int,int)> currentIJ)
    {
        if (word == string.Join("", current))
        {
            return true;
        }

        if (current.Count >= word.Length) return false;
        var result = false;
        foreach (var direction in directions)
        {
            var nx = i + direction.x;
            var ny = j + direction.y;
            if (nx < 0 || ny < 0) continue;
            if(nx >= board.Length || ny >= board[0].Length) continue;
            if (!currentIJ.Contains((nx, ny)))
            {
                current.Add(board[nx][ny].ToString());
                currentIJ.Add((nx, ny));
                result = Explore(nx, ny, board, word, directions, current, currentIJ);
                current.RemoveAt(current.Count - 1);
                currentIJ.RemoveAt(currentIJ.Count - 1);
            }
        }

        return result;
    }
}