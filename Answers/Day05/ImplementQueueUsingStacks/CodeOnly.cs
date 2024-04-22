public class MyQueue
{
    Stack<int> stack;
    Stack<int> queue;

    public MyQueue()
    {
        stack = new Stack<int>();
        queue = new Stack<int>();
    }

    public void Push(int x)
    {
        stack.Push(x);
    }

    public int Pop()
    {
        if (queue.Count == 0)
        {
            while (stack.Count > 0)
            {
                queue.Push(stack.Pop());
            }
        }
        return queue.Pop();
    }

    public int Peek()
    {
        if (queue.Count == 0)
        {
            while (stack.Count > 0)
            {
                queue.Push(stack.Pop());
            }
        }
        return queue.Peek();
    }

    public bool Empty()
    {
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