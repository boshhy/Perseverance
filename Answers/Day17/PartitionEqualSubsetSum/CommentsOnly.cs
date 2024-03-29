// Overview
public class Solution
{
    public bool CanPartition(int[] nums)
    {
        // It aims to determine whether it's possible to partition the array into two subsets with equal sum. 
        // It calculates the total sum of the numbers in the array and checks if it's even; if not, it returns 
        // false immediately since equal partitioning isn't possible. Then, it iterates through each number in 
        // the array and uses dynamic programming to determine whether a subset sum equal to half of the 
        // total sum is achievable. If such a sum is found, it returns true; otherwise, it returns false.
    }
}

// Comments
public class Solution
{
    public bool CanPartition(int[] nums)
    {
        // Calculate the total sum of the numbers in the array

        // Check if the total sum is odd; if it is, it's not possible to partition the array into two subsets with equal sum

        // Calculate the target amount each subset should sum up to

        // Create a boolean array to store whether a certain sum is achievable using elements from the array

        // Initialize the first element in the array, representing sum zero, as achievable (base case)

        // Iterate through each number in the array
        //     Iterate from the target amount down to the retreatAmount
        //         Update the isSumAchievable array for the currentAmount by considering whether it's achievable either with or without the current retreatAmount

        //         If the target sum is achievable, return true immediately (optimization)

        // If the loop completes without finding a valid partition, return false
    }
}

// Pseudocode
public class Solution
{
    public bool CanPartition(int[] nums)
    {
        // totalSum = sum of all elements in nums

        // if totalSum is odd:
        //     return false

        // targetAmount = totalSum / 2

        // isSumAchievable = boolean array of size targetAmount + 1
        // isSumAchievable[0] = true

        // for each retreatAmount in nums:
        //     for currentAmount from targetAmount down to retreatAmount:
        //         isSumAchievable[currentAmount] = isSumAchievable[currentAmount] OR isSumAchievable[currentAmount - retreatAmount]

        //         if isSumAchievable[targetAmount]:
        //             return true

        // return false
    }
}

