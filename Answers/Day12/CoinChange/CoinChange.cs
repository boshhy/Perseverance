public class Solution
{
    // Method to find the minimum number of coins needed to make up a given amount using a given set of coin denominations.
    public int CoinChange(int[] coins, int amount)
    {
        // Create an array 'total' with a length of 'amount + 1' to store the minimum number of coins needed for each amount from 0 to 'amount'.
        int[] total = new int[amount + 1];

        // Iterate over each element in the 'total' array.
        for (int i = 0; i < total.Length; i++)
        {
            // Initialize each element in the 'total' array to 'amount + 1'.
            // This represents an impossible value initially, as the maximum number of coins needed for any amount is 'amount'.
            total[i] = amount + 1;
        }

        // Set the value at index 0 of the 'total' array to 0, as 0 coins are needed for an amount of 0.
        total[0] = 0;

        // Iterate through each amount from 1 to 'amount'.
        for (int currentAmount = 1; currentAmount < total.Length; currentAmount++)
        {
            // Iterate through each coin denomination in the 'coins' array.
            foreach (int coin in coins)
            {
                // Check if the current amount minus the coin denomination is greater than or equal to 0.
                if (currentAmount - coin >= 0)
                {
                    // Update the value at index 'currentAmount' in the 'total' array to the minimum of its current value
                    // and the value at index 'currentAmount - coin' plus 1 (representing the number of coins used for the remainder).
                    total[currentAmount] = Math.Min(total[currentAmount], total[currentAmount - coin] + 1);
                }
            }
        }

        // Return -1 if the value at index 'amount' in the 'total' array is 'amount + 1' (impossible value), otherwise, return the value at index 'amount'.
        return (total[amount] == amount + 1) ? -1 : total[amount];
    }
}
