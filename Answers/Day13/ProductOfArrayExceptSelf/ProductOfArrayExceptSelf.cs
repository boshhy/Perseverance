public class Solution
{
    // Method to calculate product of all elements in nums except self
    public int[] ProductExceptSelf(int[] nums)
    {
        // Initializing an array to store the results
        int[] result = new int[nums.Length];

        // Setting the first element of result array to 1
        result[0] = 1;

        // Iterating through nums array to calculate products from left to right
        for (int i = 1; i < nums.Length; i++)
        {
            // Calculating product of all elements to the left of current element
            // and storing it in result array
            result[i] = nums[i - 1] * result[i - 1];
        }

        // Using a container variable to store product of elements to the right
        int container = 1;

        // Iterating through nums array to calculate products from right to left
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            // Multiplying the product of elements to the left of current element
            // with the product of elements to the right and storing in result array
            result[i] = container * result[i];

            // Multiplying container with current element value to update it for the next iteration
            container *= nums[i];
        }

        // Returning the result array containing products except self for each element
        return result;
    }
}
