public class Solution
{
    // Method to generate all permutations of an array of integers
    public IList<IList<int>> Permute(int[] nums)
    {
        // Initialize a list to store all permutations
        IList<IList<int>> result = new List<IList<int>>();
        // Initialize a list to store the current combination being constructed
        List<int> currentCombination = new List<int>();

        // Start the backtracking process to generate permutations
        Backtrack();

        // Return the list of permutations
        return result;

        // Backtracking function to generate permutations recursively
        void Backtrack()
        {
            // Check if the current combination is of the same length as the input array
            if (currentCombination.Count == nums.Length)
            {
                // If so, add the current combination to the result list
                result.Add(new List<int>(currentCombination));
                return;
            }
            // Iterate through each integer in the input array
            foreach (int num in nums)
            {
                // If the current combination already contains the integer, skip it
                if (currentCombination.Contains(num)) continue;
                // Add the integer to the current combination
                currentCombination.Add(num);
                // Recursively call the backtrack function
                Backtrack();
                // Remove the last integer added to backtrack and try other possibilities
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}
