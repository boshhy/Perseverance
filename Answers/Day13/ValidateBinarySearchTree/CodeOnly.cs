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
    public bool IsValidBST(TreeNode root)
    {
        bool checkNode(TreeNode node, long minAllowed, long maxallowed)
        {
            if (node == null)
            {
                return true;
            }

            if (node.val <= minAllowed || node.val >= maxallowed)
            {
                return false;
            }

            return checkNode(node.left, minAllowed, node.val) && checkNode(node.right, node.val, maxallowed);
        }

        return checkNode(root, long.MinValue, long.MaxValue);
    }
}