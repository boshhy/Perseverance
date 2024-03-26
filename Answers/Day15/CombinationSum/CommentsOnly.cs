// Overview
class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        // The code initializes an empty list to store combinations and another list for the current 
        // combination being explored. It then recursively generates unique combinations of integers 
        // from a given array that sum up to a specified target. 
        // Finally, it returns the list of unique combinations found.
    }
}

// Comments
class Solution
{
    // This method finds all unique combinations of numbers in the 'candidates' array
    // that sum up to the 'target'.
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        // Initialize a list to store the currentCombination combination being explored.

        // Call the helper method to find unique combinations recursively.

        // Return the final result after all combinations are found.

        // This is a helper method for finding unique combinations recursively.
        // It explores combinations starting from 'start' index to avoid duplicates.
        //     Base case: If target becomes non-positive, check if it's zero,
        //     indicating a valid combination. If so, add it to the result.
        //     Iterate through the candidates array starting from 'start' index.
        //         Include the currentCombination candidate in the combination.

        //         Recursively call the function with updated target and index.
        //         Subtract the current candidate from the target for the next call.
        //         Start index remains the same to avoid duplicate combinations.

        //         Backtrack: Remove the last added candidate to explore other possibilities.
    }
}

// Pseudocode
class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        // result = empty list of lists
        // currentCombination = empty list

        // GetUniqueCombinations(target, 0)

        // return result

        // function GetUniqueCombinations(target, start):
        //     if target <= 0:
        //         if target == 0:
        //             add a copy of currentCombination to result
        //         return

        //     for i from start to length of candidates - 1:
        //         add candidates[i] to currentCombination
        //         recursively call GetUniqueCombinations with updated target and i
        //         remove the last element from currentCombination
    }
}