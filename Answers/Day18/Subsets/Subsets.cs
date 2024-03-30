public class Solution
{
    // Method to generate all subsets of an array of integers
    public IList<IList<int>> Subsets(int[] nums)
    {
        // Initialize a list to store the subsets
        IList<IList<int>> result = new List<IList<int>>();

        // Initialize a list to temporarily hold elements of subsets
        List<int> currentSubset = new List<int>();

        // Start generating subsets recursively
        Backtrack(0);

        // Return the generated subsets
        return result;

        // Recursive method to generate subsets
        void Backtrack(int start)
        {
            // Add the current subset to the result list
            result.Add(new List<int>(currentSubset));

            // Iterate through the remaining elements of the array
            for (int i = start; i < nums.Length; i++)
            {
                // Add the current element to the subset
                currentSubset.Add(nums[i]);

                // Recursively generate subsets including the current element
                Backtrack(i + 1);

                // Backtrack: Remove the last element added to the subset
                currentSubset.RemoveAt(currentSubset.Count - 1);
            }
        }
    }
}