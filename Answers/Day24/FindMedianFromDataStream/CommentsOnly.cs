// Overview
public class MedianFinder
{
    // Uses two priority queues
    public MedianFinder()
    {
        // The code initializes two priority queues, leftHeap and rightHeap, with integer elements and their priorities
    }

    public void AddNum(int num)
    {
        // The code maintains two priority queues (leftHeap and rightHeap) to efficiently find the median of a stream of numbers. 
        // It adds each number to leftHeap with its negation as priority, ensuring the smaller half is in leftHeap. Then, it 
        // checks if the heaps are unbalanced and balances them by transferring elements between them to ensure the difference 
        // in count is at most one.
    }

    public double FindMedian()
    {
        // The code calculates the median of a stream of numbers by comparing the sizes of two heaps storing the numbers. If the sizes 
        // of the heaps are equal, it returns the average of the top elements of both heaps. If the left heap has more elements, 
        // it returns the top element of the left heap as the median; otherwise, it returns the top element of the right heap.
    }
}

// Comments
public class MedianFinder
{
    // Two priority queues to store elements, leftHeap for smaller half and rightHeap for larger half

    // Constructor initializes the two heaps
    public MedianFinder()
    {
        // initialize the two heaps
    }

    // Adds a number to the appropriate heap and balances the heaps
    public void AddNum(int num)
    {
        // Add the number to the leftHeap with its negation as priority

        // If rightHeap is not empty and the top element of leftHeap is greater than top element of rightHeap
        //     Move the maximum element from leftHeap to rightHeap

        // If leftHeap has more than one element than rightHeap
        //     Move the maximum element from leftHeap to rightHeap
        // If rightHeap has more than one element than leftHeap
        //     Move the minimum element from rightHeap to leftHeap
    }

    // Finds the median of the current elements
    public double FindMedian()
    {
        // If both heaps have equal number of elements
        //     Median is the average of top elements of both heaps

        // If leftHeap has more elements
        //     Median is the top element of leftHeap
        // If rightHeap has more elements
        // Median is the top element of rightHeap
    }
}

// Pseudocode
public class MedianFinder
{
    // PriorityQueue leftHeap
    // PriorityQueue rightHeap
    public MedianFinder()
    {
        // leftHeap = new PriorityQueue()
        // rightHeap = new PriorityQueue()
    }

    public void AddNum(int num)
    {
        // leftHeap.Enqueue(num, -num)

        // if (rightHeap.Count > 0 && leftHeap.Peek() > rightHeap.Peek()) {
        //     max = leftHeap.Dequeue()
        //     rightHeap.Enqueue(max, max)
        // }

        // if (leftHeap.Count > rightHeap.Count + 1) 
        // {
        //     max = leftHeap.Dequeue()
        //     rightHeap.Enqueue(max, max)
        // } 
        // else if (rightHeap.Count > leftHeap.Count + 1) {
        //     min = rightHeap.Dequeue()
        //     leftHeap.Enqueue(min, -min)
        // }
    }

    public double FindMedian()
    {
        // if (leftHeap.Count == rightHeap.Count) {
        //     return (leftHeap.Peek() + rightHeap.Peek()) / 2.0
        // }

        // if (leftHeap.Count > rightHeap.Count) {
        //     return leftHeap.Peek()
        // }
        // return rightHeap.Peek()
    }
}
