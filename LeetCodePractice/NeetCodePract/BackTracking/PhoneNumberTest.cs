namespace LeetCodePractice.NeetCodePract.BackTracking;

public class PhoneNumberTest
{
    private List<string> res = new List<string>();
    private Dictionary<char, string> digitToChar = new Dictionary<char, string> {
        {'2', "abc"}, {'3', "def"}, {'4', "ghi"}, {'5', "jkl"},
        {'6', "mno"}, {'7', "qprs"}, {'8', "tuv"}, {'9', "wxyz"}
    };
    public PhoneNumberTest()
    {
        LetterCombinations("34");
    }
    public List<string> LetterCombinations(string digits) 
    {
        if (digits.Length == 0) return new List<string>();
        
        List<string> res = new List<string> { "" };
        Dictionary<char, string> digitToChar = new Dictionary<char, string> {
            { '2', "abc" }, { '3', "def" }, { '4', "ghi" }, { '5', "jkl" },
            { '6', "mno" }, { '7', "qprs" }, { '8', "tuv" }, { '9', "wxyz" }
        };

        foreach (char digit in digits) {
            List<string> tmp = new List<string>();
            foreach (string curStr in res) {
                foreach (char c in digitToChar[digit]) {
                    tmp.Add(curStr + c);
                }
            }
            res = tmp;
        }
        return res;
    }
    
    public List<string> LetterCombinationsFix(string digits) {
        if (digits.Length == 0) return res;
        Backtrack(0, "", digits);
        return res;
    }

    private void Backtrack(int i, string curStr, string digits) {
        if (curStr.Length == digits.Length) {
            res.Add(curStr);
            return;
        }
        foreach (char c in digitToChar[digits[i]]) {
            Backtrack(i + 1, curStr + c, digits);
        }
    }
}