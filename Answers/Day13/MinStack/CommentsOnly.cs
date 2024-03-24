// Overview
public class MinStack
{

    public MinStack()
    {
        // Initializes two stacks, one for the main stack and the other to keep track of the minimum values.
    }

    public void Push(int val)
    {
        // Pushes a value onto the main stack 
        // and updates the minimum value stack if the value is smaller than or equal to the current minimum.
    }

    public int Pop()
    {
        // Pops the top element from the main stack and removes it from the minimum value stack if it's the current minimum.
    }


    public int Top()
    {
        // Returns the top element of the main stack without removing it.
    }

    public int GetMin()
    {
        // Returns the minimum value currently stored in the stack without removing it.
    }
}

// Comments
public class MinStack
{
    // Declare two stacks to store integers: one for the main stack and one for tracking the minimum values.

    // Constructor to initialize both stacks.
    public MinStack()
    {
        // Initialize the main stack.
        // Initialize the minimum value stack.
    }

    // Method to push a value onto the main stack and update the minimum value stack if necessary.
    public void Push(int val)
    {
        // Push the value onto the main stack.

        // If the minimum value stack is empty or the new value is less than or equal to the current minimum, 
        //     push the new value onto the minimum value stack.
    }

    // Method to pop the top element from the main stack and update the minimum value stack if necessary.
    public int Pop()
    {
        // Pop the top element from the main stack.

        // If the popped value from the main stack is equal to the top element of the minimum value stack, 
        //     pop the top element from the minimum value stack.
        // Return the popped value.
    }

    // Method to return the top element of the main stack without removing it.
    public int Top()
    {
        // Return the top element of the main stack.
    }

    // Method to return the minimum value currently in the stack.
    public int GetMin()
    {
        // Return the top element of the minimum value stack.
    }
}

// Pseudocode
public class MinStack
{
    // Stack<int> stack;
    // Stack<int> minStack;
    public MinStack()
    {
        // stack = new Stack<int>();
        // minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        // stack.Push(val);
        // if (minStack.Count == 0 OR val <= minStack.Peek())
        //     minStack.Push(val);
    }

    public int Pop()
    {
        // int val = stack.Pop();
        // if (val == minStack.Peek()) 
        //     minStack.Pop();

        // return val;
    }


    public int Top()
    {
        // return stack.Peek();
    }

    public int GetMin()
    {
        // return minStack.Peek();
    }
}