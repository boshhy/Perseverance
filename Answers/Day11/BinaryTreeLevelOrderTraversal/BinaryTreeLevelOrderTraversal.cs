/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution
{
    // This method performs a level order traversal of the binary tree and returns the result as a list of lists of integers.
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        // Initialize a list to store lists of integers, each representing a level in the binary tree
        List<IList<int>> result = new List<IList<int>>();

        // Initialize a queue to perform level order traversal of the binary tree
        Queue<TreeNode> queue = new Queue<TreeNode>();

        // Check if the root of the binary tree is null, if so, return the empty result
        if (root == null)
        {
            return result;
        }

        // Enqueue the root node to start the traversal
        queue.Enqueue(root);

        // Perform level order traversal using a queue
        while (queue.Count > 0)
        {
            // Get the number of nodes at the current level
            int currentCount = queue.Count;

            // Initialize a list to store nodes at the current level
            List<int> levelNodes = new List<int>();

            // Iterate through all nodes at the current level
            for (int i = 0; i < currentCount; i++)
            {
                // Dequeue a node from the queue
                TreeNode pointer = queue.Dequeue();

                // Add the value of the dequeued node to the list representing the current level
                levelNodes.Add(pointer.val);

                // Enqueue the left child of the dequeued node if it exists
                if (pointer.left != null)
                {
                    queue.Enqueue(pointer.left);
                }

                // Enqueue the right child of the dequeued node if it exists
                if (pointer.right != null)
                {
                    queue.Enqueue(pointer.right);
                }
            }

            // Add the list of nodes at the current level to the result list
            result.Add(levelNodes);
        }

        // Return the result list containing lists of nodes at each level of the binary tree
        return result;
    }
}