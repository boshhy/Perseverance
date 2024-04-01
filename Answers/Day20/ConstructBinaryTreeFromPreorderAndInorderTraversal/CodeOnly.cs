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
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();

        for (int i = 0; i < inorder.Length; i++)
        {
            d[inorder[i]] = i;
        }

        TreeNode root = MakeTree(0, preorder.Length - 1, 0, inorder.Length - 1);

        return root;

        TreeNode MakeTree(int preLeft, int preRight, int inLeft, int inRight)
        {
            if (preLeft > preRight || inLeft > inRight)
                return null;

            TreeNode node = new TreeNode(preorder[preLeft]);

            int mid = d[preorder[preLeft]];

            int countTotalGoingToLeftSide = mid - inLeft;

            node.left = MakeTree(preLeft + 1, preLeft + countTotalGoingToLeftSide, inLeft, mid - 1);
            node.right = MakeTree(preLeft + 1 + countTotalGoingToLeftSide, preRight, mid + 1, inRight);

            return node;
        }
    }
}