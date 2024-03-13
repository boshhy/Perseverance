// Overview
public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // This code implements a method to find the lowest common ancestor of two nodes in a binary search tree.

        // It traverses the tree recursively, comparing the values of the nodes to determine whether to search in 
        // the left or right subtree. When both nodes are on opposite sides of the current node, 
        // it returns the current node as the lowest common ancestor.
    }
}

// Comments
public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // If both p and q are less than the current root's value,
        // then the LCA must be in the left subtree.
        //     Recursively search the left subtree.
        // If both p and q are greater than the current root's value,
        // then the LCA must be in the right subtree.
        //     Recursively search the right subtree.
        // If the above conditions are not met, it means that the LCA is the current root.
    }
}

// Pseudocode
public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // if p.value < root.value and q.value < root.value:
        //     return LowestCommonAncestor(root.left, p, q)
        // else if p.value > root.value and q.value > root.value:
        //     return LowestCommonAncestor(root.right, p, q)
        // return root
    }
}