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
    // Method for inverting a binary tree
    public TreeNode InvertTree(TreeNode root)
    {
        // Check if the root node is null (base case)
        if (root == null)
        {
            // If root is null, return null
            return root;
        }

        // Store the left child of the current root in a temporary variable
        TreeNode tempNode = root.left;

        // Swap the left and right children of the current root
        root.left = root.right;
        root.right = tempNode;

        // Recursively invert the left subtree
        InvertTree(root.left);

        // Recursively invert the right subtree
        InvertTree(root.right);

        // Return the inverted root node
        return root;
    }
}