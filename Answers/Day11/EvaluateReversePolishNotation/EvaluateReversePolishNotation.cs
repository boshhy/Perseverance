public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                int top = stack.Pop();
                int bottom = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(bottom + top);
                        break;
                    case "-":
                        stack.Push(bottom - top);
                        break;
                    case "/":
                        stack.Push(bottom / top);
                        break;
                    case "*":
                        stack.Push(bottom * top);
                        break;
                }
            }
            else
            {
                stack.Push(Convert.ToInt32(token));
            }
        }
        return stack.Pop();
    }
}