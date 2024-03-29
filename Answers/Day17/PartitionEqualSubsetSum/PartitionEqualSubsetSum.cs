public class Solution
{
    // Method to check if the input array can be partitioned into two subsets with equal sum
    public bool CanPartition(int[] nums)
    {
        // Calculate the total sum of the numbers in the array
        int totalSum = nums.Sum();

        // Check if the total sum is odd; if it is, it's not possible to partition the array into two subsets with equal sum
        if (totalSum % 2 != 0)
        {
            return false;
        }

        // Calculate the target amount each subset should sum up to
        int targetAmount = totalSum / 2;

        // Create a boolean array to store whether a certain sum is achievable using elements from the array
        bool[] isSumAchievable = new bool[targetAmount + 1];

        // Initialize the first element in the array, representing sum zero, as achievable (base case)
        isSumAchievable[0] = true;

        // Iterate through each number in the array
        foreach (int retreatAmount in nums)
        {
            // Iterate from the target amount down to the retreatAmount
            for (int currentAmount = targetAmount; currentAmount >= retreatAmount; currentAmount--)
            {
                // Update the isSumAchievable array for the currentAmount by considering whether it's achievable either with or without the current retreatAmount
                isSumAchievable[currentAmount] = isSumAchievable[currentAmount] || isSumAchievable[currentAmount - retreatAmount];

                // If the target sum is achievable, return true immediately (optimization)
                if (isSumAchievable[targetAmount])
                {
                    return true;
                }
            }
        }

        // If the loop completes without finding a valid partition, return false
        return false;
    }
}
