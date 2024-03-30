public class Solution
{
    // This method converts a given string to an integer.
    public int MyAtoi(string s)
    {
        // Trim the input string to remove leading and trailing white spaces.
        s = s.Trim();

        // If the trimmed string is empty, return 0.
        if (s.Length == 0) return 0;

        // Initialize a boolean variable to keep track of the sign of the number (positive or negative).
        bool isPositive = true;

        // Initialize a variable to keep track of the number of characters to skip while parsing the string.
        int skip = 0;

        // Check if the first character of the trimmed string is a sign ('-' or '+').
        if (s[0] == '-' || s[0] == '+')
        {
            // If the first character is a sign, increment 'skip'.
            skip++;
            // If the sign is '-', set 'isPositive' to false, indicating a negative number.
            if (s[0] == '-')
            {
                isPositive = false;
            }
        }
        // If the first character is neither a sign nor a number, return 0.
        else if (!char.IsNumber(s[0]))
        {
            return 0;
        }

        // Initialize variables to store the parsed integer value and the current numeric value.
        int total = 0;
        int currentDigit;

        // Calculate the maximum value that can be represented by an integer divided by 10.
        int maxDiv10 = int.MaxValue / 10;

        // Iterate through the characters of the string starting from the position 'skip'.
        foreach (char character in s.Skip(skip))
        {
            // Check if the current character is a number.
            if (char.IsNumber(character))
            {
                // Convert the character to its corresponding numeric value.
                currentDigit = character - '0';

                // Check if adding the current digit would cause overflow.
                if (total > maxDiv10 || (total == maxDiv10 && currentDigit >= 8))
                {
                    // If overflow would occur, return the maximum or minimum integer value based on the sign.
                    return isPositive ? int.MaxValue : int.MinValue;
                }

                // Update the total by multiplying it by 10 and adding the current digit.
                total = total * 10 + currentDigit;
            }
            else
            {
                // If a non-numeric character is encountered, break the loop.
                break;
            }
        }

        // Return the parsed integer value with the appropriate sign.
        return isPositive ? total : -total;
    }
}
