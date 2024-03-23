// Overview
public class Solution
{
    // Method to find the minimum number of coins needed to make up a given amount using a given set of coin denominations.
    public int CoinChange(int[] coins, int amount)
    {
        // It initializes an array 'total' to store the minimum number of coins 
        // needed for each amount from 0 to the target amount.Then, it iteratively updates the 'total' array to find 
        // the minimum number of coins required for each amount using dynamic programming principles.
        // Finally, it returns either the minimum number of coins needed for the target amount 
        // or - 1 if it's impossible to make the amount with the given coins.
    }
}

// Comments
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        // Create an array 'total' with a length of 'amount + 1' to store the minimum number of coins needed for each amount from 0 to 'amount'.

        // Iterate over each element in the 'total' array.
        //     Initialize each element in the 'total' array to 'amount + 1'.
        //     This represents an impossible value initially, as the maximum number of coins needed for any amount is 'amount'.

        // Set the value at index 0 of the 'total' array to 0, as 0 coins are needed for an amount of 0.

        // Iterate through each amount from 1 to 'amount'.
        //     Iterate through each coin denomination in the 'coins' array.
        //         Check if the current amount minus the coin denomination is greater than or equal to 0.
        //             Update the value at index 'currentAmount' in the 'total' array to the minimum of its current value
        //             and the value at index 'currentAmount - coin' plus 1 (representing the number of coins used for the remainder).

        // Return -1 if the value at index 'amount' in the 'total' array is 'amount + 1' (impossible value), otherwise, return the value at index 'amount'.
    }
}


// Pseudocode
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        // total = array of length (amount + 1)

        // for i from 0 to length of total - 1:
        //     total[i] = amount + 1

        // total[0] = 0

        // for currentAmount from 1 to length of total - 1:
        //     for each coin in coins:
        //         if currentAmount - coin >= 0:
        //             total[currentAmount] = minimum of (total[currentAmount], total[currentAmount - coin] + 1)

        // if total[amount] equals (amount + 1):
        //     return -1
        // else:
        //     return total[amount]
    }
}