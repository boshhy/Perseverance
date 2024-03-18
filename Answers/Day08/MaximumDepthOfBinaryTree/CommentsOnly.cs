// Overview
public class Solution
{
    // Define a public method (used recursively) named MaxDepth
    public int MaxDepth(TreeNode root)
    {
        // It utilizes a recursive approach where it traverses through the tree, 
        // calculating the depth of the left and right subtrees. The depth of each subtree is 
        // determined by recursively calling MaxDepth on its children. 
        // Finally, it returns the maximum depth among the left and right subtrees plus 1.
    }
}

// Comments
public class Solution
{
    // Define a public method (used recursively) named MaxDepth which calculates the maximum depth of a binary tree
    public int MaxDepth(TreeNode root)
    {
        // Check if the root node is null, indicating an empty tree

        // Recursively calculate the maximum depth of the left subtree
        // Recursively calculate the maximum depth of the right subtree

        // Return the maximum depth among the left and right subtrees, plus 1 for the current node
    }
}

// Pseudocode
public class Solution
{
    // Define a public method (used recursively) named MaxDepth
    public int MaxDepth(TreeNode root)
    {
        // if root is null:
        //     return 0

        // leftDepth = MaxDepth(root.left)
        // rightDepth = MaxDepth(root.right)

        // return max(leftDepth, rightDepth) + 1
    }
}