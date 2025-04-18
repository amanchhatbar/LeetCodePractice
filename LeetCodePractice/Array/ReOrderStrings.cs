namespace LeetCodePractice.Recursion;

public class ReOrderStrings
{
    public ReOrderStrings()
    {
        ReorderLogFiles([
            "6p tzwmh ige mc", "ns 566543603829", "ubd cujg j d yf", "ha6 1 938 376 5", "3yx 97 666 56 5",
            "d 84 34353 2249", "0 tllgmf qp znc", "s 1088746413789", "ys0 splqqxoflgx", "uhb rfrwt qzx r",
            "u lrvmdt ykmox", "ah4 4209164350", "rap 7729 8 125", "4 nivgc qo z i", "apx 814023338 8"
        ]);
    }
    public string[] ReorderLogFiles(string[] logs) {
        //The letter-logs come before all digit-logs.
        //The letter-logs are sorted lexicographically by their contents. If their contents are the same, then sort them    
        //lexicographically by their identifiers.
        //The digit-logs maintain their relative ordering.
        var wordList = new List<string>();
        var numbQueue = new Queue<string>();
        foreach(var log in logs)
        {
            var split = log.Split(' ');
            if(split[1].All(char.IsDigit)){
                numbQueue.Enqueue(log);
            }
            else{
                wordList.Add(log);
            }
        }

        var orderWords = wordList
            .OrderBy(s =>
            {
                var parts = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return string.Join(" ", parts.Skip(1)); // sort by rest of the words
            })
            .ThenBy(s =>
            {
                var parts = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return parts[0]; // tiebreaker: sort by first word
            }).ToList();

        while (numbQueue.Count > 0)
        {
            orderWords.Add(numbQueue.Dequeue());
        }


        return orderWords.ToArray();
    }
}