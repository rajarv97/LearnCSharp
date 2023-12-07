public class Solution
{
    public string LargestOddNumber(string num)
    {
        for (var n = num.Length - 1; n >= 0; n--)
        {
            var digit = num[n] - '0';
            if (digit % 2 != 0)
                return num.Substring(0, n + 1);
        }

        return string.Empty;
    }
}