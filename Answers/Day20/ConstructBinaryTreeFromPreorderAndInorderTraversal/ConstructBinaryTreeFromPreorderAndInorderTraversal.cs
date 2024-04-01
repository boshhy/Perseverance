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
    // Method to build a binary tree given its preorder and inorder traversals
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        // Dictionary to store the index of each value in the inorder array
        Dictionary<int, int> d = new Dictionary<int, int>();

        // Populating the dictionary with the indices of values in the inorder array
        for (int i = 0; i < inorder.Length; i++)
        {
            // Key: value in the inorder array
            // Value: index of the value in the inorder array
            d[inorder[i]] = i;
        }

        // Recursive method call to construct the tree
        TreeNode root = MakeTree(0, preorder.Length - 1, 0, inorder.Length - 1);

        // Returning the root of the constructed binary tree
        return root;

        // Recursive helper function to construct the tree
        TreeNode MakeTree(int preLeft, int preRight, int inLeft, int inRight)
        {
            // Base case: if the indices are invalid, return null
            if (preLeft > preRight || inLeft > inRight)
                return null;

            // Creating a new node with the value from the preorder array
            TreeNode node = new TreeNode(preorder[preLeft]);

            // Finding the index of the current node's value in the inorder array
            int mid = d[preorder[preLeft]];

            // Calculating the number of nodes to the left of the current node in inorder traversal
            int countTotalGoingToLeftSide = mid - inLeft;

            // Recursive calls to construct left and right subtrees
            node.left = MakeTree(preLeft + 1, preLeft + countTotalGoingToLeftSide, inLeft, mid - 1);
            node.right = MakeTree(preLeft + 1 + countTotalGoingToLeftSide, preRight, mid + 1, inRight);

            // Returning the constructed node
            return node;
        }
    }
}
