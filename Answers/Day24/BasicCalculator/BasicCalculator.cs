public class Solution
{
    public int Calculate(string s)
    {
        int current = 0;
        int result = 0;
        int sign = 1;

        Stack<int> stack = new Stack<int>();

        foreach (char character in s)
        {
            if (char.IsNumber(character))
            {
                current = current * 10 + character - '0';
            }
            else if (character == '+' || character == '-')
            {
                result = result + sign * current;

                sign = (character == '+') ? 1 : -1;

                current = 0;
            }
            else if (character == '(')
            {
                stack.Push(result);
                stack.Push(sign);

                sign = 1;
                result = 0;
            }
            else if (character == ')')
            {
                result = result + sign * current;
                result = stack.Pop() * result;
                result = stack.Pop() + result;

                current = 0;
            }
        }
        return result + sign * current;
    }
}