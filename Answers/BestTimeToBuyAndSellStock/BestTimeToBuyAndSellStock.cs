public class Solution
{
    public int MaxProfit(int[] prices)
    {
        // Initialize variables to keep track of maximum profit and current lowest price
        int maxProfit = 0; // Maximum profit obtained so far
        int curerntLowestPrice = int.MaxValue; // Current lowest price observed so far

        // Iterate through each price in the prices array
        foreach (int dayPrice in prices)
        {
            // If the current day's price is lower than the current lowest price
            if (dayPrice < curerntLowestPrice)
            {
                // Update the current lowest price
                curerntLowestPrice = dayPrice;
            }
            // Else if the difference between the current day's price and the current lowest price
            // is greater than the current maximum profit
            else if (dayPrice - curerntLowestPrice > maxProfit)
            {
                // Update the maximum profit
                maxProfit = dayPrice - curerntLowestPrice;
            }
        }
        // Return the maximum profit obtained
        return maxProfit;
    }
}
