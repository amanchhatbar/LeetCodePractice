namespace LeetCodePractice.DP;

public class GridTraveller
{
    public long GridTravellerRecurssion(int x, int y, Dictionary<(int, int), long> xyDict)
    {
        if (xyDict.ContainsKey((x,y))) return xyDict[(x, y)];
        if (x == 1 && y == 1) return 1;
        if (x == 0 || y == 0) return 0;
        var value = GridTravellerRecurssion(x - 1, y, xyDict) + GridTravellerRecurssion(x, y - 1, xyDict);
        xyDict.TryAdd((x, y), value);
        return value;
    }
}