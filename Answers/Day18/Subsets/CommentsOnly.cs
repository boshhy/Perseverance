// Overview
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        // This code generates all possible subsets of an array of integers using a backtracking approach. 
        // It initializes an empty list to store subsets and another list to store the current subset being 
        // constructed. The Backtrack function is recursively called to explore including or excluding each 
        // element in the subset. When the end of the input array is reached, the current subset is added 
        // to the result list. 
        // Finally, the list of subsets is returned.
    }
}

// Comments
public class Solution
{
    // Method to find all subsets of an array of integers
    public IList<IList<int>> Subsets(int[] nums)
    {
        // Initialize a list to store all subsets
        // Initialize a list to store the current subset being constructed
        // Start backtracking from the first element of the input array
        // Return the list of subsets

        // Backtracking method to construct subsets
        //     Base case: if the index is equal to or greater than the length of the input array,
        //     the current subset is complete, so add it to the result list
        //     Include the current element in the current subset
        //     Recursively call backtrack to include next element in the subset
        //     Remove the last added element to backtrack and explore other possibilities
        //     Continue exploring subsets without including the current element
    }
}


// Pseudocode
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        // result = empty list of lists
        // currentSubset = empty list of integers
        // Backtrack(0)
        // return result

        // function Backtrack(index):
        //     if index >= length of nums:
        //         add a copy of currentSubset to result
        //         return
        //     add nums[index] to currentSubset
        //     Backtrack(index + 1)
        //     remove the last element from currentSubset
        //     Backtrack(index + 1)
    }
}
