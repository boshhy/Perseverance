public class Solution
{
    public bool IsValid(string s)
    {
        Dictionary<char, char> my_map = new Dictionary<char, char>{
            { ')', '(' },
            { '}', '{' },
            { ']', '[' }
        };
        HashSet<char> opening = new HashSet<char> { '(', '[', '{' };
        Stack<char> stack = new Stack<char>();

        foreach (char starter in s)
        {
            if (opening.Contains(starter))
            {
                stack.Push(starter);
            }
            else
            {
                if (stack.Count <= 0 || stack.Pop() != my_map[starter])
                    return false;
            }
        }
        return stack.Count <= 0;
    }
}
