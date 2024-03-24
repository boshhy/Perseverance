public class MinStack
{
    // Declare two stacks to store integers: one for the main stack and one for tracking the minimum values.
    Stack<int> stack;
    Stack<int> minStack;

    // Constructor to initialize both stacks.
    public MinStack()
    {
        stack = new Stack<int>(); // Initialize the main stack.
        minStack = new Stack<int>(); // Initialize the minimum value stack.
    }

    // Method to push a value onto the main stack and update the minimum value stack if necessary.
    public void Push(int val)
    {
        stack.Push(val); // Push the value onto the main stack.

        // If the minimum value stack is empty or the new value is less than or equal to the current minimum, push the new value onto the minimum value stack.
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }

    // Method to pop the top element from the main stack and update the minimum value stack if necessary.
    public int Pop()
    {
        int val = stack.Pop(); // Pop the top element from the main stack.

        // If the popped value from the main stack is equal to the top element of the minimum value stack, pop the top element from the minimum value stack.
        if (val == minStack.Peek())
        {
            minStack.Pop();
        }
        return val; // Return the popped value.
    }

    // Method to return the top element of the main stack without removing it.
    public int Top()
    {
        return stack.Peek(); // Return the top element of the main stack.
    }

    // Method to return the minimum value currently in the stack.
    public int GetMin()
    {
        return minStack.Peek(); // Return the top element of the minimum value stack.
    }
}
