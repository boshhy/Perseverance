public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2)
        {
            return n;
        }

        int last = 2;
        int two_last = 1;
        int temp;

        for (int i = 3; i < n; i++)
        {
            temp = last + two_last;
            two_last = last;
            last = temp;
        }
        return last + two_last;
    }
}