// This class represents a queue implemented using two stacks.
public class MyQueue
{
    // Stack to store elements in first-in-last-out (FILO) order.
    Stack<int> stack;
    // Stack to store elements in first-in-first-out (FIFO) order, mimicking a queue.
    Stack<int> queue;

    // Constructor to initialize the two stacks.
    public MyQueue()
    {
        // Initialize the stack and queue.
        stack = new Stack<int>();
        queue = new Stack<int>();
    }

    // Method to add an element to the queue.
    public void Push(int x)
    {
        // Add the element to the stack.
        stack.Push(x);
    }

    // Method to remove and return the oldest element from the queue.
    public int Pop()
    {
        // If the queue stack is empty, transfer elements from the stack to the queue.
        if (queue.Count == 0)
        {
            // Transfer elements from the stack to the queue until the stack is empty.
            while (stack.Count > 0)
            {
                queue.Push(stack.Pop());
            }
        }
        // Return and remove the oldest element from the queue.
        return queue.Pop();
    }

    // Method to return the oldest element from the queue without removing it.
    public int Peek()
    {
        // If the queue stack is empty, transfer elements from the stack to the queue.
        if (queue.Count == 0)
        {
            // Transfer elements from the stack to the queue until the stack is empty.
            while (stack.Count > 0)
            {
                queue.Push(stack.Pop());
            }
        }
        // Return the oldest element from the queue without removing it.
        return queue.Peek();
    }

    // Method to check if the queue is empty.
    public bool Empty()
    {
        // The queue is empty if both the stack and queue stacks are empty.
        return stack.Count <= 0 && queue.Count <= 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
