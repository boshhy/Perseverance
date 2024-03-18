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
    public int DiameterOfBinaryTree(TreeNode root)
    {
        int maxWide = 0;

        int GoDeep(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftDeep = GoDeep(node.left);
            int rightDeep = GoDeep(node.right);

            maxWide = Math.Max(leftDeep + rightDeep, maxWide);

            return Math.Max(leftDeep, rightDeep) + 1;
        }

        GoDeep(root);
        return maxWide;
    }
}