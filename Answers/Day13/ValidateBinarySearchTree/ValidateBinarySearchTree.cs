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
    // Method to check if the given binary tree is a valid binary search tree
    public bool IsValidBST(TreeNode root)
    {
        // Helper method to recursively check if a subtree rooted at the given node is a valid BST
        bool checkNode(TreeNode node, long minAllowed, long maxAllowed)
        {
            // Base case: If the current node is null, it's a valid BST
            if (node == null)
            {
                return true;
            }

            // Check if the value of the current node violates the BST property
            if (node.val <= minAllowed || node.val >= maxAllowed)
            {
                return false;
            }

            // Recursively check the left and right subtrees, updating the range of allowed values
            return checkNode(node.left, minAllowed, node.val) && checkNode(node.right, node.val, maxAllowed);
        }

        // Start the recursive check with the entire tree, allowing the full range of long integers
        return checkNode(root, long.MinValue, long.MaxValue);
    }
}
