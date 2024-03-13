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
    public bool IsBalanced(TreeNode root)
    {
        int howDeep(TreeNode currentNode)
        {
            if (currentNode == null)
            {
                return 0;
            }

            int left = howDeep(currentNode.left);
            int right = howDeep(currentNode.right);

            if (left == -1 || right == -1 || Math.Abs(left - right) >= 2)
            {
                return -1;
            }

            return (left > right) ? left + 1 : right + 1;

        }

        if (howDeep(root) == -1)
        {
            return false;
        }
        return true;
    }
}