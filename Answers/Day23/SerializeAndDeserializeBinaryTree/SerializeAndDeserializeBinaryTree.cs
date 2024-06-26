/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Codec
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        // Initialize a list to store serialized nodes
        List<string> result = new List<string>();

        // Define a Depth First Search (DFS) function to traverse the tree
        void DFS(TreeNode node)
        {
            // If the node is null, add "null" to the result and return
            if (node == null)
            {
                result.Add("null");
                return;
            }

            // Add the node's value to the result
            result.Add(node.val.ToString());

            // Recursively traverse the left subtree
            DFS(node.left);

            // Recursively traverse the right subtree
            DFS(node.right);
        }

        // Start DFS traversal from the root
        DFS(root);

        // Join the elements of the result list into a single string separated by commas
        return string.Join(",", result);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        // Initialize a queue to store split string elements
        Queue<string> queue = new Queue<string>(data.Split(","));

        // Define a Depth First Search (DFS) function to build the tree
        TreeNode DFS()
        {
            // Dequeue a string from the queue
            string valueToAdd = queue.Dequeue();

            // If the dequeued value is "null", return null
            if (valueToAdd == "null")
            {
                return null;
            }

            // Create a new TreeNode with the integer value of the dequeued string
            TreeNode node = new TreeNode(Convert.ToInt32(valueToAdd));

            // Recursively build the left subtree
            node.left = DFS();

            // Recursively build the right subtree
            node.right = DFS();

            // Return the constructed node
            return node;
        }

        // Start building the tree by calling the DFS function
        return DFS();
    }
}
