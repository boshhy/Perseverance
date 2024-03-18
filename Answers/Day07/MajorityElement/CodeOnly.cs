public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int currentTotal = 0;
        int Canidate = 0;

        foreach (int num in nums)
        {
            if (currentTotal <= 0)
            {
                Canidate = num;
                currentTotal++;
            }
            else if (Canidate == num)
            {
                currentTotal++;
            }
            else
            {
                currentTotal--;
            }
        }
        return Canidate;
    }
}