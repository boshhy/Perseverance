public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        // Create a list to store the right side view values
        IList<int> result = new List<int>();

        // Create a queue to perform level order traversal
        Queue<TreeNode> queue = new Queue<TreeNode>();

        // If the tree is empty, return the empty result
        if (root == null)
        {
            return result;
        }

        // Enqueue the root node to start the traversal
        queue.Enqueue(root);

        // Perform level order traversal
        while (queue.Count > 0)
        {
            // Get the number of nodes at the current level
            int levelCount = queue.Count;

            // Traverse all nodes at the current level
            while (levelCount > 0)
            {
                // Dequeue the current node
                TreeNode node = queue.Dequeue();

                // Enqueue the left child if exists
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                // Enqueue the right child if exists
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                // If it's the last node at the current level, add its value to the result
                if (levelCount == 1)
                {
                    result.Add(node.val);
                }

                // Decrement the count of nodes at the current level
                levelCount--;
            }
        }

        // Return the list containing the right side view values
        return result;
    }
}
