/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        // Initialize left pointer to the first version and right pointer to the last version.
        int left = 1;
        int right = n;

        // Initialize middle as the middle version.
        int middle = n / 2;

        // Perform binary search to find the first bad version.
        while (left <= right)
        {
            // If the middle version is bad, move the right pointer to the middle - 1.
            if (IsBadVersion(middle))
            {
                right = middle - 1;
            }
            // If the middle version is not bad, move the left pointer to the middle + 1.
            else
            {
                left = middle + 1;
            }
            // Update the middle version.
            middle = left + (right - left) / 2;
        }

        // Return the left pointer which points to the first bad version.
        return left;
    }
}
