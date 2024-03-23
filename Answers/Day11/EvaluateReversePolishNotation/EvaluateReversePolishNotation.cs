public class Solution
{
    // This class contains a method called EvalRPN, which evaluates a given list of Reverse Polish Notation (RPN) tokens.
    public int EvalRPN(string[] tokens)
    {
        // Create a stack to hold integer values encountered during evaluation.
        Stack<int> stack = new Stack<int>();

        // Iterate through each token in the array of tokens.
        foreach (string token in tokens)
        {
            // Check if the token is an operator (+, -, *, /).
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                // If it's an operator, pop the top two values from the stack.
                int top = stack.Pop();
                int bottom = stack.Pop();

                // Perform the operation based on the token.
                switch (token)
                {
                    // If token is "+", add top and bottom values and push the result onto the stack.
                    case "+":
                        stack.Push(bottom + top);
                        break;
                    // If token is "-", subtract top from bottom and push the result onto the stack.
                    case "-":
                        stack.Push(bottom - top);
                        break;
                    // If token is "/", divide bottom by top and push the result onto the stack.
                    case "/":
                        stack.Push(bottom / top);
                        break;
                    // If token is "*", multiply bottom and top values and push the result onto the stack.
                    case "*":
                        stack.Push(bottom * top);
                        break;
                }
            }
            else
            {
                // If the token is not an operator, convert it to an integer and push it onto the stack.
                stack.Push(Convert.ToInt32(token));
            }
        }
        // After processing all tokens, the result will be the only value left on the stack. Pop and return it.
        return stack.Pop();
    }
}
