public class Solution
{
    // This method takes two binary strings 'a' and 'b' as input and returns their sum as a binary string.
    public string AddBinary(string a, string b)
    {
        // Initialize an empty string to store the result.
        string result = "";

        // Initialize indices to traverse the input strings from right to left.
        // Note: (aIndex and bIndex, both starting at end of length - 1 respectively)
        int aIndex = a.Length - 1;
        int bIndex = b.Length - 1;

        // Initialize variables to keep track of carry and sum.
        int carry = 0;
        int sum = 0;

        // Continue the loop until there are digits left in either input strings or there is a carry.
        while (aIndex >= 0 || bIndex >= 0 || carry > 0)
        {
            // Initialize the sum with the carry.
            sum = carry;

            // Add the current digit of 'a' to the sum if 'a' has more digits.
            if (aIndex >= 0)
            {
                sum += a[aIndex--] - '0'; // Convert character to integer value (0 or 1) and decrement the index.
            }

            // Add the current digit of 'b' to the sum if 'b' has more digits.
            if (bIndex >= 0)
            {
                sum += b[bIndex--] - '0'; // Convert character to integer value (0 or 1) and decrement the index.
            }

            // Append the least significant digit of the sum to the result string.
            result = (sum % 2).ToString() + result;

            // Update the carry for the next iteration.
            carry = sum / 2; // Carry will be 1 if the sum is greater than or equal to 2.
        }

        // Return the final result.
        return result;
    }
}
