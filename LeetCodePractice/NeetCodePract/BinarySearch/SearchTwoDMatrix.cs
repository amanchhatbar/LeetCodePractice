namespace LeetCodePractice.NeetCodePract.BinarySearch;

public class SearchTwoDMatrix
{
    public SearchTwoDMatrix()
    {
        int[][] matrix = [[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]];
        var target = 10;
        var result = SearchMatrix(matrix, target);
        Console.WriteLine(result);
    }

    public bool SearchMatrix(int[][] matrix, int target)
    {
        var rows = matrix.Length;
        var columns = matrix[0].Length;
        var l = 0;
        var r = (rows * columns) - 1;
        while (l <= r)
        {
            var m = l + (r - l) / 2;
            var row = m / columns;
            var col = m % columns;
            if (target > matrix[row][col]) 
            {
                l = m + 1;
            } 
            else if (target < matrix[row][col]) 
            {
                r = m - 1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}