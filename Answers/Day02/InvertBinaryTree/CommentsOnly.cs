// Overview
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        // It swaps the left and right children of each node starting from the root node, 
        // then recursively applies the same inversion process to the left and right subtrees 
        // until all nodes have been processed. Finally, it returns the root of the inverted tree.
    }
}

// Comments
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        // Check if the root node is null
        //      If the root node is null, return null

        // Store the left child of the current root in a temporary variable
        // Swap the left and right children of the current root

        // Recursively invert the left subtree
        // Recursively invert the right subtree

        // Return the inverted root node
    }
}

// Pseudocode
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        // if root is null:
        //         return root

        //     tempNode = root.left
        //     root.left = root.right
        //     root.right = tempNode

        //     InvertTree(root.left)
        //     InvertTree(root.right)

        //     return root
    }
}