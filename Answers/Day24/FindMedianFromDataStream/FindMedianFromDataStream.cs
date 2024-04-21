public class MedianFinder
{
    // Two priority queues to store elements, leftHeap for smaller half and rightHeap for larger half
    PriorityQueue<int, int> leftHeap;
    PriorityQueue<int, int> rightHeap;

    // Constructor initializes the two heaps
    public MedianFinder()
    {
        leftHeap = new PriorityQueue<int, int>();
        rightHeap = new PriorityQueue<int, int>();
    }

    // Adds a number to the appropriate heap and balances the heaps
    public void AddNum(int num)
    {
        // Add the number to the leftHeap with its negation as priority
        leftHeap.Enqueue(num, -num);

        // If rightHeap is not empty and the top element of leftHeap is greater than top element of rightHeap
        if (rightHeap.Count > 0 && leftHeap.Peek() > rightHeap.Peek())
        {
            // Move the maximum element from leftHeap to rightHeap
            int max = leftHeap.Dequeue();
            rightHeap.Enqueue(max, max);
        }

        // If leftHeap has more than one element than rightHeap
        if (leftHeap.Count > rightHeap.Count + 1)
        {
            // Move the maximum element from leftHeap to rightHeap
            int max = leftHeap.Dequeue();
            rightHeap.Enqueue(max, max);
        }
        // If rightHeap has more than one element than leftHeap
        else if (rightHeap.Count > leftHeap.Count + 1)
        {
            // Move the minimum element from rightHeap to leftHeap
            int min = rightHeap.Dequeue();
            leftHeap.Enqueue(min, -min);
        }
    }

    // Finds the median of the current elements
    public double FindMedian()
    {
        // If both heaps have equal number of elements
        if (leftHeap.Count == rightHeap.Count)
        {
            // Median is the average of top elements of both heaps
            return (leftHeap.Peek() + rightHeap.Peek()) / 2.0;
        }

        // If leftHeap has more elements
        if (leftHeap.Count > rightHeap.Count)
        {
            // Median is the top element of leftHeap
            return leftHeap.Peek();
        }
        // If rightHeap has more elements
        return rightHeap.Peek(); // Median is the top element of rightHeap
    }
}
