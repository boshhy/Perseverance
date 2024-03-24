// Overview
public class Solution
{
    // Method to check if the given binary tree is a valid binary search tree
    public bool IsValidBST(TreeNode root)
    {
        // It initializes the range boundaries (minAllowed and maxAllowed) to the minimum and maximum possible values 
        // for a long integer, respectively. If any node's value violates the BST property by being outside of this range, 
        // the function returns false; otherwise, it returns true upon completing the traversal without violations.
    }
}

// Comments
public class Solution
{
    // Method to check if the given binary tree is a valid binary search tree
    public bool IsValidBST(TreeNode root)
    {
        // Helper method to recursively check if a subtree rooted at the given node is a valid BST
        //     Base case: If the current node is null, it's a valid BST

        //     Check if the value of the current node violates the BST property

        //     Recursively check the left and right subtrees, updating the range of allowed values

        // Start the recursive check with the entire tree, allowing the full range of long integers
    }
}

// Pseudocode
public class Solution
{
    // Method to check if the given binary tree is a valid binary search tree
    public bool IsValidBST(TreeNode root)
    {
        // function checkNode(node, minAllowed, maxAllowed):
        //     if node is null:
        //         return true

        //     if node.val <= minAllowed OR node.val >= maxAllowed:
        //         return false

        //     return checkNode(node.left, minAllowed, node.val) AND checkNode(node.right, node.val, maxAllowed)

        // return checkNode(root, -INFINITY, +INFINITY)
    }
}