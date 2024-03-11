class IsValidSolution
{

    static bool IsValid(string s)
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
        return !(stack.Count > 0);
    }

    static void Main(string[] args)
    {
        // Test cases to verify the IsValid function

        // Test case 1: Valid parentheses
        string s1 = "()";
        bool result1 = IsValid(s1);
        Console.WriteLine("Test case 1:");
        Console.WriteLine($"Input: s = \"{s1}\"");
        Console.WriteLine($"Output: {result1}");
        Console.WriteLine("Expected output: true");
        Console.ForegroundColor = result1 == true ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Test result: {(result1 == true ? "Passed" : "Failed")}");
        Console.ResetColor();

        // Test case 2: Valid parentheses
        string s2 = "()[]{}";
        bool result2 = IsValid(s2);
        Console.WriteLine("\nTest case 2:");
        Console.WriteLine($"Input: s = \"{s2}\"");
        Console.WriteLine($"Output: {result2}");
        Console.WriteLine("Expected output: true");
        Console.ForegroundColor = result2 == true ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Test result: {(result2 == true ? "Passed" : "Failed")}");
        Console.ResetColor();

        // Test case 3: Invalid parentheses
        string s3 = "(]";
        bool result3 = IsValid(s3);
        Console.WriteLine("\nTest case 3:");
        Console.WriteLine($"Input: s = \"{s3}\"");
        Console.WriteLine($"Output: {result3}");
        Console.WriteLine("Expected output: false");
        Console.ForegroundColor = result3 == false ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Test result: {(result3 == false ? "Passed" : "Failed")}");
        Console.ResetColor();
    }
}