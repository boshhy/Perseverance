// Overview
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        // This code generates all possible subsets of an input array of integers using a backtracking approach. 
        // It initializes an empty list to store subsets and a temporary list to build subsets iteratively. 
        // The Backtrack method recursively generates subsets by including or excluding elements at each step, 
        // ensuring all combinations are explored. At each level of recursion, it adds the current subset to the 
        // result list, explores including the next element in the subset, and then removes the last element to 
        // backtrack and explore other possibilities. 
        // Finally, it returns the list of generated subsets.
    }
}

// Comments
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        // Initialize a list to store the subsets
        // Initialize a list to temporarily hold elements of subsets
        // Start generating subsets recursively
        // Return the generated subsets

        // Recursive method to generate subsets
        //     Add the current subset to the result list

        //     Iterate through the remaining elements of the array
        //         Add the current element to the subset

        //         Recursively generate subsets including the current element

        //         Backtrack: Remove the last element added to the subset
    }
}

// Pseudocode
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        // result = Empty list of lists
        // currentSubset = Empty list
        // Call Backtrack(0)
        // Return result

        // Function Backtrack(start):
        //     Add a copy of currentSubset to result
        //     For i from start to length of nums:
        //         Add nums[i] to currentSubset
        //         Call Backtrack(i + 1)
        //         Remove the last element from currentSubset

    }
}
