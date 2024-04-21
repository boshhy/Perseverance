public class MedianFinder
{
    PriorityQueue<int, int> leftHeap;
    PriorityQueue<int, int> rightHeap;

    public MedianFinder()
    {
        leftHeap = new PriorityQueue<int, int>();
        rightHeap = new PriorityQueue<int, int>();
    }

    public void AddNum(int num)
    {
        leftHeap.Enqueue(num, -num);

        if (rightHeap.Count > 0 && leftHeap.Peek() > rightHeap.Peek())
        {
            int max = leftHeap.Dequeue();
            rightHeap.Enqueue(max, max);
        }

        if (leftHeap.Count > rightHeap.Count + 1)
        {
            int max = leftHeap.Dequeue();
            rightHeap.Enqueue(max, max);
        }
        else if (rightHeap.Count > leftHeap.Count + 1)
        {
            int min = rightHeap.Dequeue();
            leftHeap.Enqueue(min, -min);
        }
    }

    public double FindMedian()
    {
        if (leftHeap.Count == rightHeap.Count)
        {
            return (leftHeap.Peek() + rightHeap.Peek()) / 2.0;
        }

        if (leftHeap.Count > rightHeap.Count)
        {
            return leftHeap.Peek();
        }
        return rightHeap.Peek();
    }
}
