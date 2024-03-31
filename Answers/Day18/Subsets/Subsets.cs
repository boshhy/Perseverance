public class Solution
{
    // Method to find all subsets of an array of integers
    public IList<IList<int>> Subsets(int[] nums)
    {
        // Initialize a list to store all subsets
        IList<IList<int>> result = new List<IList<int>>();
        // Initialize a list to store the current subset being constructed
        List<int> currentSubset = new List<int>();
        // Start backtracking from the first element of the input array
        Backtrack(0);
        // Return the list of subsets
        return result;

        // Backtracking method to construct subsets
        void Backtrack(int index)
        {
            // Base case: if the index is equal to or greater than the length of the input array,
            // the current subset is complete, so add it to the result list
            if (index >= nums.Length)
            {
                result.Add(new List<int>(currentSubset));
                return;
            }
            // Include the current element in the current subset
            currentSubset.Add(nums[index]);
            // Recursively call backtrack to include next element in the subset
            Backtrack(index + 1);
            // Remove the last added element to backtrack and explore other possibilities
            currentSubset.RemoveAt(currentSubset.Count - 1);
            // Continue exploring subsets without including the current element
            Backtrack(index + 1);
        }
    }
}
