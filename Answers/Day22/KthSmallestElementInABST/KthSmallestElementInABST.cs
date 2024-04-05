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
    // Method to find the kth smallest element in a BST
    public int KthSmallest(TreeNode root, int k)
    {
        // Initialize variables to keep track of current k value and the result
        int currentK = 0;
        int result = 0;

        // Traverse the tree to find the kth smallest element
        GetSmallestK(root);

        // Return the kth smallest element
        return result;

        // Helper method to traverse the tree and find the kth smallest element
        void GetSmallestK(TreeNode node)
        {
            // If the current node is null, return
            if (node == null)
            {
                return;
            }

            // Traverse left subtree
            GetSmallestK(node.left);

            // Increment the counter for current k value and check if it equals k
            if (++currentK == k)
            {
                // If the current k value equals k, set the result to the value of the current node
                result = node.val;
            }

            // Traverse right subtree
            GetSmallestK(node.right);
        }
    }
}
