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
    public int KthSmallest(TreeNode root, int k)
    {

        int currentK = 0;
        int result = 0;

        GetSmallestK(root);

        return result;

        void GetSmallestK(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            GetSmallestK(node.left);

            if (++currentK == k)
            {
                result = node.val;
            }

            GetSmallestK(node.right);

        }
    }
}