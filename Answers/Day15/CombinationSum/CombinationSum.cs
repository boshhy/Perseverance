class Solution
{
    // This method finds all unique combinations of numbers in the 'candidates' array
    // that sum up to the 'target'.
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        // Initialize a list to store the result, which contains lists of integers.
        IList<IList<int>> result = new List<IList<int>>();

        // Initialize a list to store the currentCombination combination being explored.
        List<int> currentCombination = new List<int>();

        // Call the helper method to find unique combinations recursively.
        GetUniqueCombinations(target, 0);

        // Return the final result after all combinations are found.
        return result;

        // This is a helper method for finding unique combinations recursively.
        // It explores combinations starting from 'start' index to avoid duplicates.
        void GetUniqueCombinations(int target, int start)
        {
            // Base case: If target becomes non-positive, check if it's zero,
            // indicating a valid combination. If so, add it to the result.
            if (target <= 0)
            {
                if (target == 0)
                {
                    result.Add(new List<int>(currentCombination));
                }
                return;
            }

            // Iterate through the candidates array starting from 'start' index.
            for (int i = start; i < candidates.Length; i++)
            {
                // Include the currentCombination candidate in the combination.
                currentCombination.Add(candidates[i]);

                // Recursively call the function with updated target and index.
                // Subtract the current candidate from the target for the next call.
                // Start index remains the same to avoid duplicate combinations.
                GetUniqueCombinations(target - candidates[i], i);

                // Backtrack: Remove the last added candidate to explore other possibilities.
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
}
