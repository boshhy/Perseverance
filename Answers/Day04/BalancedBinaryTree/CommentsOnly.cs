// Overview
public class Solution
{
    // This class defines a solution for determining whether a binary tree is balanced or not.
    // A binary tree is balanced if the heights of the two subtrees of any node never differ by more than one.
    public bool IsBalanced(TreeNode root)
    {
        // It recursively calculates the depth of each subtree, ensuring that the difference in height 
        // between any two subtrees is no more than 1. The function uses a nested helper function, howDeep, 
        // to traverse the tree and compute subtree depths. It returns -1 to signify an unbalanced subtree 
        // and the height of the subtree otherwise.

        // If any subtree is unbalanced, it returns false; 
        // otherwise, it returns true. 
    }
}

// Comments
public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        // Inner method to calculate the depth of the tree.
        //     If the current node is null, return 0 as its depth.

        //     Recursively calculate the depth of the left and right subtrees.

        //     If either subtree is unbalanced or if the difference in heights between left and right subtrees is more than 1,
        //     return -1 to indicate the tree is unbalanced.

        //     Otherwise, return the height of the current node by adding 1 to the maximum depth of its subtrees.

        // Call the inner method to calculate the depth of the root.
        // If the returned value is -1, the tree is unbalanced; otherwise, it's balanced.
    }
}

// Pseudocode
public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        // function howDeep(currentNode):
        //     if currentNode is null:
        //                 return 0
        //     left = howDeep(currentNode.left)
        //     right = howDeep(currentNode.right)
        //     if left is -1 OR right is -1 OR AbsoluteValue(left - right) is greater than or equal to 2:
        //         return -1
        //     return (left > right) ? left + 1 : right + 1

        // if howDeep(root) is -1:
        //     return false
        // return true
    }
}