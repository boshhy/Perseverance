// Overview
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        // It calculates this by first computing the products of elements to the left of each element and storing them in the result array. 
        // Then, it iterates backward to calculate the products of elements to the right and multiplies them with the corresponding left products. 
        // Finally, it returns the resulting array.
    }
}

// Comments
public class Solution
{
    // Method to calculate product of all elements in nums except self
    public int[] ProductExceptSelf(int[] nums)
    {
        // Initializing an array to store the results

        // Setting the first element of result array to 1

        // Iterating through nums array to calculate products from left to right
        //     Calculating product of all elements to the left of current element
        //     and storing it in result array

        // Using a container variable to store product of elements to the right

        // Iterating through nums array to calculate products from right to left
        //     Multiplying the product of elements to the left of current element
        //     with the product of elements to the right and storing in result array

        //     Multiplying container with current element value to update it for the next iteration

        // Returning the result array containing products except self for each element
    }
}

// Pseudocode
public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        // Create an array result of length nums.Length
        // Set result[0] to 1

        // For i from 1 to nums.Length - 1:
        //     Set result[i] to nums[i - 1] * result[i - 1]

        // Create a variable container and set it to 1

        // For i from nums.Length - 1 down to 0:
        //     Set result[i] to container * result[i]
        //     Multiply container by nums[i]

        // Return result
    }
}