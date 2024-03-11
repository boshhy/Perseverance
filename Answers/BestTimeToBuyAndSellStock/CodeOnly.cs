public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int curerntLowestPrice = int.MaxValue;

        foreach (int dayPrice in prices)
        {
            if (dayPrice < curerntLowestPrice)
            {
                curerntLowestPrice = dayPrice;
            }
            else if (dayPrice - curerntLowestPrice > maxProfit)
            {
                maxProfit = dayPrice - curerntLowestPrice;
            }
        }
        return maxProfit;
    }
}
