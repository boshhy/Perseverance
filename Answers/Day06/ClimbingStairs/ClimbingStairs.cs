public class Solution
{
    // Define a public method named ClimbStairs that takes an integer parameter 'n' and returns an integer.
    public int ClimbStairs(int n)
    {
        // If 'n' is less than or equal to 2, return 'n'.
        if (n <= 2)
        {
            return n;
        }

        // Initialize 'last' to 2, as this represents the number of ways to climb 2 stairs.
        int last = 2;

        // Initialize 'two_last' to 1, as this represents the number of ways to climb 1 stair.
        int two_last = 1;

        // Declare a temporary variable 'temp'.
        int temp;

        // Iterate through the range starting from 3 up to 'n - 1'.
        for (int i = 3; i < n; i++)
        {
            // Calculate the number of ways to climb 'i' stairs and assign it to 'temp'.
            temp = last + two_last;

            // Update 'two_last' to hold the number of ways to climb 'i-1' stairs.
            two_last = last;

            // Update 'last' to hold the number of ways to climb 'i' stairs.
            last = temp;
        }

        // Return the total number of ways to climb 'n' stairs, which is the sum of the last two iterations.
        return last + two_last;
    }
}
