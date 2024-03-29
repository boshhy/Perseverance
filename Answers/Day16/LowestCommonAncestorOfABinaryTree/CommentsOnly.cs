// Overview
public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // This code defines a method to find the lowest common ancestor of two nodes p and q within a binary tree rooted at root. 
        // It traverses the tree recursively, checking if the current node is either p or q. If so, it returns the current node. 
        // Then, it searches for the nodes p and q in the left and right subtrees recursively. If both leftNode and rightNode 
        // are not null, it means that p and q are found in different subtrees, so the current node is their lowest common ancestor. 
        // Otherwise, it returns whichever subtree contains p or q, or null if neither is found.
    }
}

// Comments
public class Solution
{
    // This method finds the lowest common ancestor of two nodes 'p' and 'q' in a binary tree with 'root' as its root node.
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // If the root is null, it means the tree is empty, so there's no common ancestor.

        // If the current node's value equals either 'p' or 'q', it means this node itself is the common ancestor.
        // Recursively find the lowest common ancestor in the left subtree.

        // Recursively find the lowest common ancestor in the right subtree.

        // If both 'leftNode' and 'rightNode' are not null, it means 'p' and 'q' are found in separate subtrees,
        // hence 'root' is the lowest common ancestor.

        // If either 'leftNode' or 'rightNode' is not null, it means either 'p' or 'q' is found in one of the subtrees.
        // In this case, return the non-null node (the common ancestor), if one exists.
        // If both are null, it means neither 'p' nor 'q' is found in the current subtree, so return null.
    }
}

// Pseudocode
public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // if root is null:
        //     return null
        // if root.val is equal to p.val or root.val is equal to q.val:
        //     return root

        // leftNode = LowestCommonAncestor(root.left, p, q)
        // rightNode = LowestCommonAncestor(root.right, p, q)

        // if leftNode is not null and rightNode is not null:
        //     return root

        // if leftNode is not null:
        //     return leftNode
        // else:
        //     return rightNode
    }
}

