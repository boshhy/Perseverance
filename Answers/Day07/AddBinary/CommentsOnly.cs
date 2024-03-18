// Overview 
public class Solution
{
    public string AddBinary(string a, string b)
    {
        // The provided code initializes variables to store the result of binary addition between two input 
        // strings a and b, accounting for carry digits. It iterates through the input strings from right to left, 
        // summing up corresponding digits along with any carry from the previous iteration. It constructs the 
        // result string by appending the least significant digit of the sum to the left side of the result string. 
        // Finally, it returns the resulting binary sum as a string.
    }
}

// Comments
public class Solution
{
    // This method takes two binary strings 'a' and 'b' as input and returns their sum as a binary string.
    public string AddBinary(string a, string b)
    {
        // Initialize an empty string to store the result.

        // Initialize indices to traverse the input strings from right to left.

        // Initialize variables to keep track of carry and sum.

        // Continue the loop until there are digits left in either input strings or there is a carry.
        //     Initialize the sum with the carry.

        //     If 'a' has more characters left.
        //         Convert character to integer andvalue (0 or 1) and add to sum, decrement the index.

        //     If 'b' has more characters left.
        //         Convert character to integer andvalue (0 or 1) and add to sum, decrement the index.

        //     Append to front of result the sum, module 2

        //     Update the carry for the next iteration, Carry will be 1 if the sum is greater than or equal to 2.

        // Return the final result.
    }
}

// Pseudocode 
public class Solution
{
    public string AddBinary(string a, string b)
    {
        // result = ""
        // aIndex = length of a - 1
        // bIndex = length of b - 1
        // carry = 0

        // while aIndex >= 0 OR bIndex >= 0 OR carry > 0:
        //     sum = carry

        //     if aIndex >= 0:
        //         sum += a[aIndex--] - '0'
        //     if bIndex >= 0:
        //         sum += b[bIndex--] - '0'

        //     Append (sum % 2) to the left of result
        //     carry = sum / 2

        // return result
    }
}