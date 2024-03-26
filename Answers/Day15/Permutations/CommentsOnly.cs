// Overview
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        // The code generates all possible permutations of a given array of integers. It initializes a 
        // list to store permutations and another list to store the current combination being constructed. 
        // Then, it calls the Backtrack function to start generating permutations recursively. Within the 
        // Backtrack function, it checks if the current combination is complete, and if so, adds it to the 
        // result list. It iterates through each integer in the input array, avoiding duplicates, and recursively 
        // calls itself to explore different combinations. 
        // Finally, it removes the last added integer to backtrack and try other possibilities.
    }
}

// Comments
public class Solution
{
    // Method to generate all permutations of an array of integers
    public IList<IList<int>> Permute(int[] nums)
    {
        // Initialize a list to store all permutations
        // Initialize a list to store the current combination being constructed

        // Start the backtracking process to generate permutations

        // Return the list of permutations

        // Backtracking function to generate permutations recursively
        //     Check if the current combination is of the same length as the input array
        //         If so, add the current combination to the result list
        //     Iterate through each integer in the input array
        //         If the current combination already contains the integer, skip it
        //         Add the integer to the current combination
        //         Recursively call the backtrack function
        //         Remove the last integer added to backtrack and try other possibilities
    }
}

// Pseudocode
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        // result = Empty list of lists
        // currentCombination = Empty list

        // Call Backtrack()

        // Return result

        // Function Backtrack():
        //     If length of currentCombination is equal to length of nums:
        //         Add a copy of currentCombination to result
        //         Return

        //     For each num in nums:
        //         If num is already in currentCombination:
        //             Continue to the next iteration
        //         Add num to currentCombination
        //         Call Backtrack() recursively
        //         Remove the last element from currentCombination
    }
}
