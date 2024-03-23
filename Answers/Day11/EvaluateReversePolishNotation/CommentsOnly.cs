// Overview
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        // The provided code evaluates a mathematical expression given in Reverse Polish Notation (RPN). 
        // It utilizes a stack data structure to store intermediate results while iterating through 
        // each token in the expression. When encountering operators (+, -, *, /), it performs the corresponding 
        // arithmetic operation on the top two values of the stack and pushes the result back onto the stack. 
        // If the token is a number, it's converted and pushed onto the stack. 
        // Finally, the result of the expression is retrieved from the top of the stack and returned.
    }
}

// Comments
public class Solution
{
    // This class contains a method called EvalRPN, which evaluates a given list of Reverse Polish Notation (RPN) tokens.
    public int EvalRPN(string[] tokens)
    {
        // Create a stack to hold integer values encountered during evaluation.

        // Iterate through each token in the array of tokens.
        //     Check if the token is an operator (+, -, *, /).
        //         If it's an operator, pop the top two values from the stack.

        //         Perform the operation based on the token.
        //             If token is "+", add top and bottom values and push the result onto the stack.
        //             If token is "-", subtract top from bottom and push the result onto the stack.
        //             If token is "/", divide bottom by top and push the result onto the stack.
        //             If token is "*", multiply bottom and top values and push the result onto the stack.
        //         If the token is not an operator, convert it to an integer and push it onto the stack.
        // After processing all tokens, the result will be the only value left on the stack. Pop and return it.
    }
}

// Pseudocode
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        // stack = empty Stack

        // for each token in tokens:
        //     if token is an operator:
        //         top = stack.Pop()
        //         bottom = stack.Pop()
        //         perform operation based on token:
        //             if token is "+":
        //                 stack.Push(bottom + top)
        //             else if token is "-":
        //                 stack.Push(bottom - top)
        //             else if token is "/":
        //                 stack.Push(bottom / top)
        //             else if token is "*":
        //                 stack.Push(bottom * top)
        //     else:
        //         // token is a number
        //         stack.Push(ConvertToInt(token))

        // // Result will be the only value left on the stack after processing all tokens
        // return stack.Pop()
    }
}