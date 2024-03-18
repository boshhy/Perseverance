public class Solution
{
    public string AddBinary(string a, string b)
    {
        string result = "";

        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;
        int carry = 0;
        int sum = 0;

        while (aIndex >= 0 || bIndex >= 0 || carry > 0)
        {
            sum = carry;

            if (aIndex >= 0)
            {
                sum += a[aIndex--] - '0';
            }
            if (bIndex >= 0)
            {
                sum += b[bIndex--] - '0';
            }

            result = (sum % 2).ToString() + result;

            carry = sum / 2;
        }
        return result;
    }
}
