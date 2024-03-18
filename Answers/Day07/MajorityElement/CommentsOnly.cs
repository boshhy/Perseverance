// Overview
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        // Uses Boyer-Moore Majority Vote Algorithm to find the majority element in an array (efficiently uses O(1) Memory). 
        // It iterates through the array, maintaining a count of the current candidate element and its occurrences. 
        // If the count becomes zero or non-positive, it updates the candidate element. 
        // If the current element matches the candidate, the count is incremented; otherwise, it's decremented. 
        // Finally, it returns the majority element candidate found in the array.
    }
}

// Comments
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        // Initialize two variables to keep track of the current candidate and its count.

        // Iterate through each element in the array.
        //     If the current total is zero or non-positive (meaning: there is a new candidate)
        //     update the candidate to the current number.
        //     Increment the current total.
        //         update the candidate to the current number.
        //         Increment the current total.
        //     If the current number matches the candidate 
        //         increment the current total.
        //     If the current number is different from the candidate
        //         decrement the current total.

        // Return the majority element candidate.
    }
}

// Pseudocode
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        // currentTotal = 0
        // Candidate = 0

        // for num in nums:
        //     if currentTotal is less than or equal to 0:
        //         Candidate = num
        //         Increment currentTotal
        //     else if Candidate equals num:
        //         Increment currentTotal
        //     else:
        //         Decrement currentTotal

        // return Candidate
    }
}