// Overview
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        // It initializes pointers to the first and last versions, then iteratively narrows down 
        // the search range until finding the first bad version. This is achieved by continuously 
        // adjusting the pointers based on whether the middle version is considered bad or not 
        // The method returns the version number of the first detected bad version.
    }
}

// Comments
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        // Initialize left pointer to the first version and right pointer to the last version.

        // Initialize middle as the middle version.

        // Perform binary search to find the first bad version.
        //     If the middle version is bad, move the right pointer to the middle - 1.
        //     If the middle version is not bad, move the left pointer to the middle + 1.
        //     Update the middle version.

        // Return the left pointer which points to the first bad version.
    }
}

// Pseudocode
public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        // Initialize left pointer to 1 and right pointer to n.
        // Initialize middle as n divided by 2.
        // Perform binary search while left pointer is less than or equal to right pointer:
        //     If middle version is bad:
        //         Move the right pointer to middle - 1.
        //     Else:
        //         Move the left pointer to middle + 1.
        //     Update the middle version.
        // Return the left pointer pointing to the first bad version.
    }
}