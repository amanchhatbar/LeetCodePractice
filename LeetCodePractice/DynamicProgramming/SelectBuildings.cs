namespace LeetCodePractice.DP;

public class SelectBuildings
{
    public SelectBuildings()
    {
        NumberOfWays("001101");
    }
    public long NumberOfWays(string s)
    {
        long count0 = 0, count1 = 0; 
        long count01 = 0, count10 = 0; 
        long result = 0;

        foreach (char c in s) {
            if (c == '0') {
                result += count10;  // Form "010"
                count01 += count1;  // New "01" pairs
                count0++;
            } else { // c == '1'
                result += count01;  // Form "101"
                count10 += count0;  // New "10" pairs
                count1++;
            }
        }
        return result;
    }
}