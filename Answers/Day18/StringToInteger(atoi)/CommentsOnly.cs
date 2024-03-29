// Overview
public class Solution
{
    public int MyAtoi(string s)
    {
        // It trims leading and trailing whitespace from the string, handles sign symbols ('+' and '-') correctly, 
        // and ignores non-numeric characters after the initial sign. Inside the foreach loop, it iterates through 
        // the string, converting each character to its numeric value and accumulating them to form the integer. 
        // The if condition inside the loop ensures that the accumulated value does not exceed the maximum or minimum 
        // value for an integer, considering overflow scenarios. 
        // Finally, it returns the parsed integer with the appropriate sign.
    }
}

public class Solution
{
    // This method converts a given string to an integer.
    public int MyAtoi(string s)
    {
        // Trim the input string to remove leading and trailing white spaces.

        // If the trimmed string is empty, return 0.

        // Initialize a boolean variable to keep track of the sign of the number (positive or negative).

        // Initialize a variable to keep track of the number of characters to skip while parsing the string.

        // Check if the first character of the trimmed string is a sign ('-' or '+').
        //     If the first character is a sign, increment 'skip'.
        //     If the sign is '-', set 'isPositive' to false, indicating a negative number.
        // If the first character is neither a sign nor a number, return 0.

        // Initialize variables to store the parsed integer value and the current numeric value.

        // Calculate the maximum value that can be represented by an integer divided by 10.

        // Iterate through the characters of the string starting from the position 'skip'.
        //     Check if the current character is a number.
        //         Convert the character to its corresponding numeric value.

        //         Check if adding the current digit would cause overflow.
        //             If overflow would occur, return the maximum or minimum integer value based on the sign.

        //         Update the total by multiplying it by 10 and adding the current digit.
        //         If a non-numeric character is encountered, break the loop.

        // Return the parsed integer value with the appropriate sign.
    }
}

// Pseudocode
public class Solution
{
    public int MyAtoi(string s)
    {
        // s = Trim(s)

        // if Length(s) == 0:
        //     return 0

        // isPositive = true
        // skip = 0

        // if s[0] == '-' OR s[0] == '+':
        //     skip++
        //     if s[0] == '-':
        //         isPositive = false
        // else if NOT IsNumber(s[0]):
        //     return 0

        // total = 0
        // maxDiv10 = MaxValue(int) / 10

        // foreach character in s.Skip(skip):
        //     if IsNumber(character):
        //         currentDigit = character - '0'

        //         if total > maxDiv10 OR (total == maxDiv10 AND currentDigit >= 8):
        //             return isPositive ? MaxValue(int) : MinValue(int)

        //         total = total * 10 + currentDigit
        //     else:
        //         break

        // return isPositive ? total : -total
    }
}
