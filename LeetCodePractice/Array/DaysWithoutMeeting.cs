namespace LeetCodePractice.Recursion;

public class DaysWithoutMeeting
{
    public DaysWithoutMeeting()
    {
        Console.WriteLine(CountDays(10, [[5,7],[1,3],[9,10]]));
    }
    
    public int CountDays(int days, int[][] meetings)
    {
        if (!meetings.Any()) return days;
        var meetingsList = new List<Tuple<int, List<int>>>();
        foreach (var meeting in meetings)
        {
            var meetingKey = new Tuple<int, List<int>>(meeting[0], meeting.ToList());
            meetingsList.Add(meetingKey);
        }

        var orderedMeetingList = meetingsList.Order().ToList();

        var left = 0;
        var right = 1;
        var resultList = new List<List<int>>();
        resultList.Add(orderedMeetingList[left].Item2);
        var resultCount = 0;
        while (right < orderedMeetingList.Count())
        {
            // compare left's 2nd element and right's 1st element, if they overlap then
            if (resultList[left][1] > orderedMeetingList[right].Item2[0])
            {
                var leftValue = resultList[left][0];
                var rightValue = orderedMeetingList[right].Item2[1];
                resultList.RemoveAt(left);
                resultList.Add(new List<int>(){leftValue, rightValue});
            }
            else
            {
                resultCount += orderedMeetingList[right].Item2[0] - resultList[left][1] - 1;
                resultList.Add(orderedMeetingList[right].Item2);
                left = right;
            }
            right++;
        }

        var lastElementValue = orderedMeetingList[orderedMeetingList.Count - 1].Item2[1];
        resultCount += days > lastElementValue ? days - lastElementValue : 0;
        return resultCount;
    }
}