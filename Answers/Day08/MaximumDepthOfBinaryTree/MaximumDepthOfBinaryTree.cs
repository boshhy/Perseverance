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
    // Define a public method named MaxDepth which calculates the maximum depth of a binary tree
    public int MaxDepth(TreeNode root)
    {
        // Check if the root node is null, indicating an empty tree
        if (root == null)
        {
            return 0; // Return 0 as the depth of an empty tree
        }

        // Recursively calculate the maximum depth of the left subtree
        int left = MaxDepth(root.left);
        // Recursively calculate the maximum depth of the right subtree
        int right = MaxDepth(root.right);

        // Return the maximum depth among the left and right subtrees, plus 1 for the current node
        return Math.Max(left, right) + 1;
    }
}
