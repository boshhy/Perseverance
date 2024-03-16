// Overview
public class Solution
{
    public int ClimbStairs(int n)
    {
        // This code calculates the number of distinct ways to climb a staircase with 'n' steps by taking 1 or 2 steps at a time. 
        // It utilizes a dynamic programming approach, storing the number of ways to climb the last two steps 
        // and iteratively updating them until reaching the desired step. 
        // Finally, it returns the sum of the stored values.
    }
}

// Comments
public class Solution
{
    // Define a public method named ClimbStairs that takes an integer parameter 'n' and returns an integer.
    public int ClimbStairs(int n)
    {
        // If 'n' is less than or equal to 2, return 'n'.
        // Initialize 'last' to 2, as this represents the number of ways to climb 2 stairs.
        // Initialize 'two_last' to 1, as this represents the number of ways to climb 1 stair.
        // Declare a temporary variable 'temp'.
        // Iterate through the range starting from 3 up to 'n - 1'.
        //     Calculate the number of ways to climb 'i' stairs and assign it to 'temp'.
        //     Update 'two_last' to hold the number of ways to climb 'i-1' stairs.
        //     Update 'last' to hold the number of ways to climb 'i' stairs.
        // Return the total number of ways to climb 'n' stairs, which is the sum of the last two iterations.
    }
}

// Pseudocode
public class Solution
{
    public int ClimbStairs(int n)
    {
        // If n is less than or equal to 2, return n.
        // Set last to 2.
        // Set two_last to 1.
        // For each integer i from 3 to n-1:
        //     Set temp to the sum of last and two_last.
        //     Set two_last to the value of last.
        //     Set last to the value of temp.
        // Return the sum of last and two_last.
    }
}