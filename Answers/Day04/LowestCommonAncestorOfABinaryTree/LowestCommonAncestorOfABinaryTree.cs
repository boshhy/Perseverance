/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */


public class Solution
{
    // This method finds the lowest common ancestor (LCA) of two nodes in a binary search tree.
    // It takes the root of the binary search tree and two nodes p and q as inputs.
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // If both p and q are less than the current root's value,
        // then the LCA must be in the left subtree.
        if (p.val < root.val && q.val < root.val)
        {
            // Recursively search the left subtree.
            return LowestCommonAncestor(root.left, p, q);
        }
        // If both p and q are greater than the current root's value,
        // then the LCA must be in the right subtree.
        else if (p.val > root.val && q.val > root.val)
        {
            // Recursively search the right subtree.
            return LowestCommonAncestor(root.right, p, q);
        }
        // If the above conditions are not met, it means that the LCA is the current root.
        return root;
    }
}