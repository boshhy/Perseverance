// Overview
public class Solution
{
    public void SortColors(int[] nums)
    {
        // The code implements the Dutch National Flag algorithm to sort an array containing 
        // 0s, 1s, and 2s in ascending order, where 0s come first, followed by 1s, and then 2s. 
        // It uses three pointers to partition the array and swaps elements accordingly until 
        // the array is sorted.
    }
}

// Comments
public class Solution
{
    // Method to sort an array of colors represented by integers (0, 1, 2)
    public void SortColors(int[] nums)
    {
        // Initialize pointers for the left, right, and current positions

        // Loop until the current pointer surpasses the right pointer
        //     If the current element is 2, swap it with the element at the right pointer
        //         Call Swap method to swap elements
        //         Move the right pointer towards the left
        //     If the current element is 0, swap it with the element at the left pointer
        //         Call Swap method to swap elements
        //         Move the left pointer towards the right
        //         Move the current pointer towards the right
        //     If the current element is 1, no swap is needed, just move the current pointer
        //         Move the current pointer towards the right

        // Method to swap elements in the array
        //     Swap elements using tuple deconstruction
    }
}

// Pseudocode
public class Solution
{
    public void SortColors(int[] nums)
    {
        // left = 0
        // right = len(nums) - 1
        // current = 0

        // while current <= right:
        //     if nums[current] == 2:
        //         self.swap(nums, current, right)
        //         right -= 1
        //     elif nums[current] == 0:
        //         self.swap(nums, current, left)
        //         left += 1
        //         current += 1
        //     else:
        //         current += 1

        // def swap(self, nums: List[int], x: int, y: int) -> None:
        //     nums[x], nums[y] = nums[y], nums[x]
    }
}


