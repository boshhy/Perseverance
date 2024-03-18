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
    // Method to calculate the diameter of the binary tree.
    public int DiameterOfBinaryTree(TreeNode root)
    {
        // Initialize a variable to store the maximum diameter.
        int maxWide = 0;

        // Recursive function to traverse the tree and calculate the depth of each node.
        int GoDeep(TreeNode node)
        {
            // Base case: If the node is null, return 0.
            if (node == null)
            {
                return 0;
            }

            // Recursively calculate the depth of the left subtree.
            int leftDeep = GoDeep(node.left);

            // Recursively calculate the depth of the right subtree.
            int rightDeep = GoDeep(node.right);

            // Update the maximum diameter encountered so far.
            maxWide = Math.Max(leftDeep + rightDeep, maxWide);

            // Return the maximum depth of the current subtree adding one for the edge.
            return Math.Max(leftDeep, rightDeep) + 1;
        }

        // Call the recursive function to traverse the tree and update the maxWide variable.
        GoDeep(root);

        // Return the maximum diameter of the binary tree.
        return maxWide;
    }
}
