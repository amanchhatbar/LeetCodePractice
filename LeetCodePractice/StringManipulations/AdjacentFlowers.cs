namespace LeetCodePractice.StringManipulations;

public class AdjacentFlowers
{
    public bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        if (flowerbed.Length == 1)
        {
            return flowerbed[0] == 0 && n <= 1;
        }
        var openSlots = 0;
        var temp = flowerbed;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (i == 0 || i == flowerbed.Length - 1)
            {
                var isSlotOpen = i == 0 ? temp[i + 1] : temp[i - 1];
                if (temp[i] == 0 && isSlotOpen == 0)
                {
                    openSlots++;
                    temp[i] = 1;
                }
            }
            else if (temp[i] == 0)
            {
                if (temp[i - 1] == 0 && temp[i + 1] == 0)
                {
                    openSlots++;
                    temp[i] = 1;
                }
            }
        }

        return openSlots >= n;
    }
}