public class Solution
{
    public bool IsValid(string s)
    {
        // Create a dictionary to map closing brackets to their corresponding opening brackets.
        Dictionary<char, char> my_map = new Dictionary<char, char>{
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
        // Create a set containing all opening brackets for quick lookup.
        HashSet<char> opening = new HashSet<char> { '(', '[', '{' };
        // Create a stack to store encountered opening brackets.
        Stack<char> stack = new Stack<char>();

        // Iterate through each character in the input string.
        foreach (char starter in s)
        {
            // Check if the character is an opening bracket. 
            if (opening.Contains(starter))
            {
                // If it is, push it onto the stack.
                stack.Push(starter);
            }
            else
            {
                // If it's not an opening bracket, it must be a closing bracket.
                // Check if the stack is empty or if the top of the stack's corresponding opening bracket
                // does not match the current closing bracket.
                if (stack.Count <= 0 || stack.Pop() != my_map[starter])
                    // Return false if the brackets are not balanced.
                    return false;
            }
        }
        // Return true if the stack is empty, meaning all opening brackets have been matched.
        return stack.Count <= 0;
    }
}