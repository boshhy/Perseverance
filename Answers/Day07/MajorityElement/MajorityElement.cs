public class Solution
{
    // Method to find the majority element in an array using Boyer-Moore Majority Vote Algorithm.
    public int MajorityElement(int[] nums)
    {
        // Initialize variables to keep track of the current candidate and its count.
        int currentTotal = 0;
        int Candidate = 0;

        // Iterate through each element in the array.
        foreach (int num in nums)
        {
            // If the current total is zero or non-positive (meaning: there is a new candidate)
            // update the candidate to the current number.
            // Increment the current total.
            if (currentTotal <= 0)
            {
                Candidate = num;
                currentTotal++;
            }
            // If the current number matches the candidate, increment the current total.
            else if (Candidate == num)
            {
                currentTotal++;
            }
            // If the current number is different from the candidate, decrement the current total.
            else
            {
                currentTotal--;
            }
        }

        // Return the majority element candidate.
        return Candidate;
    }
}
