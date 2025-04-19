using System.Text;

namespace LeetCodePractice.Recursion;

public class AddStrings
{
    public AddStrings()
    {
        var result = AddStringss("33", "43");
    }
    public string AddStringss(string num1, string num2)
    {
        StringBuilder sb = new StringBuilder();
        int carry = 0;
        int i = num1.Length - 1;
        int j = num2.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = i >= 0 ? num1[i] - '0' : 0;
            int digit2 = j >= 0 ? num2[j] - '0' : 0;

            int sum = digit1 + digit2 + carry;
            carry = sum / 10;
            var testing = sum % 10;
            sb.Insert(0, sum % 10);

            i--;
            j--;
        }

        return sb.ToString();
    }
}