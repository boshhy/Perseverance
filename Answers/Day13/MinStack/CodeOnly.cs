public class MinStack
{
    Stack<int> stack;
    Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);
        if (minStack.Count == 0 || val <= minStack.Peek())
        {
            minStack.Push(val);
        }
    }

    public int Pop()
    {
        int val = stack.Pop();

        if (val == minStack.Peek())
        {
            minStack.Pop();
        }
        return val;
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
