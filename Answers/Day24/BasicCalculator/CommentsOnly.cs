// Overview
public class Solution
{
    public int Calculate(string s)
    {
        // The code is a simple calculator that evaluates arithmetic expressions given as strings. 
        // It iterates through the characters of the input string, parsing numbers and operators. 
        // It uses a stack to handle parentheses, pushing intermediate results and signs onto 
        // the stack when encountering an opening parenthesis and popping them off and performing 
        // calculations when encountering a closing parenthesis. 
        // Finally, it returns the result of the evaluated expression.
    }
}

// Comments
public class Solution
{
    // This method calculates the result of a mathematical expression given as a string.
    public int Calculate(string s)
    {
        // Initialize variables to keep track of current number, result, and sign.
        // Holds the current number being parsed.
        // Holds the intermediate result of the expression.
        // Represents the sign (positive or negative) of the current expression.

        // Create a stack to handle parentheses.

        // Iterate through each character in the input string.
        //     If the character is a digit, update the current number being parsed.
        //         Convert the character to its integer value.
        //     If the character is a plus(+) or minus(-) sign, update the result and sign accordingly.
        //         Add the current number to the result with proper sign.
        //         Update the sign based on the current operator.
        //         Reset the current number.
        //     If the character is an opening parenthesis, push the current result and sign onto the stack.
        //         Push the current result onto the stack.
        //         Push the current sign onto the stack.

        //         Reset the sign to positive
        //         Reset the result for the inner expression.
        //     If the character is a closing parenthesis, evaluate the expression inside the parentheses.
        //         Add the current number to the result with proper sign.
        //         Multiply the result by the sign of the expression.
        //         Add the previous result to the current result.

        //         Reset the current number.
        // Return the final result of the expression.
    }
}

// Pseudocode
public class Solution
{
    public int Calculate(string s)
    {
        // current = 0
        // result = 0
        // sign = 1
        // stack = empty Stack

        // for each character in s:
        //     if character is a number:
        //         current = current * 10 + character - '0'
        //     else if character is '+' or '-':
        //         result = result + sign * current
        //         sign = if character is '+' then 1 else -1
        //         current = 0
        //     else if character is '(':
        //         stack.Push(result)
        //         stack.Push(sign)
        //         sign = 1
        //         result = 0
        //     else if character is ')':
        //         result = result + sign * current
        //         result = stack.Pop() * result
        //         result = stack.Pop() + result
        //         current = 0

        // return result + sign * current
    }
}


