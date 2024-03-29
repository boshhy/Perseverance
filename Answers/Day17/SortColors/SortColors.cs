public class Solution
{
    // Method to sort an array of colors represented by integers (0, 1, 2)
    public void SortColors(int[] nums)
    {
        // Initialize pointers for the left, right, and current positions
        int left = 0;
        int right = nums.Length - 1;
        int current = 0;

        // Loop until the current pointer surpasses the right pointer
        while (current <= right)
        {
            // If the current element is 2, swap it with the element at the right pointer
            if (nums[current] == 2)
            {
                Swap(current, right); // Call Swap method to swap elements
                right--; // Move the right pointer towards the left
            }
            // If the current element is 0, swap it with the element at the left pointer
            else if (nums[current] == 0)
            {
                Swap(left, current); // Call Swap method to swap elements
                left++; // Move the left pointer towards the right
                current++; // Move the current pointer towards the right
            }
            // If the current element is 1, no swap is needed, just move the current pointer
            else
            {
                current++; // Move the current pointer towards the right
            }
        }

        // Method to swap elements in the array
        void Swap(int x, int y)
        {
            (nums[x], nums[y]) = (nums[y], nums[x]); // Swap elements using tuple deconstruction
        }
    }
}
