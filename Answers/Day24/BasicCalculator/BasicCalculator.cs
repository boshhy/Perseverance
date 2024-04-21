public class Solution
{
    // This method calculates the result of a mathematical expression given as a string.
    public int Calculate(string s)
    {
        // Initialize variables to keep track of current number, result, and sign.
        int current = 0; // Holds the current number being parsed.
        int result = 0; // Holds the intermediate result of the expression.
        int sign = 1; // Represents the sign (positive or negative) of the current expression.

        // Create a stack to handle parentheses.
        Stack<int> stack = new Stack<int>();

        // Iterate through each character in the input string.
        foreach (char character in s)
        {
            // If the character is a digit, update the current number being parsed.
            if (char.IsNumber(character))
            {
                current = current * 10 + character - '0'; // Convert the character to its integer value.
            }
            // If the character is a plus(+) or minus(-) sign, update the result and sign accordingly.
            else if (character == '+' || character == '-')
            {
                result = result + sign * current; // Add the current number to the result with proper sign.
                sign = (character == '+') ? 1 : -1; // Update the sign based on the current operator.
                current = 0; // Reset the current number.
            }
            // If the character is an opening parenthesis, push the current result and sign onto the stack.
            else if (character == '(')
            {
                stack.Push(result); // Push the current result onto the stack.
                stack.Push(sign); // Push the current sign onto the stack.

                sign = 1; // Reset the sign to positive
                result = 0; // Reset the result for the inner expression.
            }
            // If the character is a closing parenthesis, evaluate the expression inside the parentheses.
            else if (character == ')')
            {
                result = result + sign * current; // Add the current number to the result with proper sign.
                result = stack.Pop() * result; // Multiply the result by the sign of the expression.
                result = stack.Pop() + result; // Add the previous result to the current result.

                current = 0; // Reset the current number.
            }
        }
        // Return the final result of the expression.
        return result + sign * current;
    }
}
