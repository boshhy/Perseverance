// Overview
public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        // The provided code constructs a binary tree using its preorder and inorder traversals. 
        // Initially, it creates a dictionary d to store the index of each value in the inorder traversal. 
        // Then, it recursively constructs the binary tree using the MakeTree function. 
        // This function divides the preorder and inorder arrays into segments corresponding to the current 
        // subtree being constructed, determining the root and its left and right subtrees recursively 
        // until the entire tree is built. Finally, it returns the root of the constructed binary tree.
    }
}

// Comments
public class Solution
{
    // Method to build a binary tree given its preorder and inorder traversals
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        // Dictionary to store the index of each value in the inorder array

        // Populating the dictionary with the indices of values in the inorder array
        //     Key: value in the inorder array
        //     Value: index of the value in the inorder array

        // Recursive method call to construct the tree

        // Returning the root of the constructed binary tree

        // Recursive helper function to construct the tree
        //     Base case: if the indices are invalid, return null

        //     Creating a new node with the value from the preorder array

        //     Finding the index of the current node's value in the inorder array

        //     Calculating the number of nodes to the left of the current node in inorder traversal

        //     Recursive calls to construct left and right subtrees

        //     Returning the constructed node
    }
}

// Pseudocode
public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        // Create dictionary d

        // For each element i in inorder:
        //     d[inorder[i]] = i

        // root = MakeTree(0, length(preorder) - 1, 0, length(inorder) - 1)

        // Return root

        // Function MakeTree(preLeft, preRight, inLeft, inRight):
        //     If preLeft > preRight OR inLeft > inRight:
        //         Return null

        //     Create node with value preorder[preLeft]

        //     mid = d[preorder[preLeft]]

        //     countTotalGoingToLeftSide = mid - inLeft

        //     node.left = MakeTree(preLeft + 1, preLeft + countTotalGoingToLeftSide, inLeft, mid - 1)
        //     node.right = MakeTree(preLeft + 1 + countTotalGoingToLeftSide, preRight, mid + 1, inRight)

        //     Return node
    }
}

