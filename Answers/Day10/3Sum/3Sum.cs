public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // Creates a list to store lists of integers, which will contain the result
        List<IList<int>> result = new List<IList<int>>();

        // Sorts the input array of integers in ascending order
        Array.Sort(nums);

        // Declares variables to keep track of indices and values
        int left;
        int right;
        int needed;
        int total;

        // Iterates through the sorted array to find triplets that sum up to zero
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // If the current number is greater than 0, there won't be any triplets that sum to zero, so break the loop
            if (nums[i] > 0)
            {
                break;
            }
            // Skips to the next iteration if the current number is equal to the previous number, to avoid duplicates
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            // Initializes pointers for two numbers to search for the third number that sums up to zero
            left = i + 1;
            right = nums.Length - 1;

            // Calculates the value needed to make the current number and the two numbers pointed by left and right to sum up to zero
            needed = -nums[i];

            // Loops until the left pointer crosses the right pointer
            while (left < right)
            {
                // Calculates the total sum of the numbers pointed by left and right pointers
                total = nums[left] + nums[right];

                // If the total sum is less than the needed value, move the left pointer to the right to increase the sum
                if (total < needed)
                {
                    left++;
                }
                // If the total sum is greater than the needed value, move the right pointer to the left to decrease the sum
                else if (total > needed)
                {
                    right--;
                }
                // If the total sum is equal to the needed value, a triplet is found
                else
                {
                    // Adds the triplet [nums[i], nums[left], nums[right]] to the result list
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Moves both pointers inward and skips duplicate numbers
                    left++;
                    right--;

                    // Skips over duplicate numbers to avoid duplicate triplets
                    while (nums[left] == nums[left - 1] && left < right)
                    {
                        left++;
                    }

                    // Skips over duplicate numbers to avoid duplicate triplets
                    while (nums[right] == nums[right + 1] && left < right)
                    {
                        right--;
                    }
                }
            }
        }

        // Returns the list of triplets that sum up to zero
        return result;
    }
}