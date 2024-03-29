/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl
{
    public int FirstBadVersion(int n)
    {
        int left = 1;
        int right = n;

        int middle = n / 2;
        while (left <= right)
        {
            if (IsBadVersion(middle))
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
            middle = left + (right - left) / 2;
        }

        return left;
    }
}