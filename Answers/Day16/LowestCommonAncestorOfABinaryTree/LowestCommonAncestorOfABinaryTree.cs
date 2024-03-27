public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null)
            return null;
        if (root.val == p.val || root.val == q.val)
            return root;

        TreeNode leftNode = LowestCommonAncestor(root.left, p, q);
        TreeNode rightNode = LowestCommonAncestor(root.right, p, q);

        if (leftNode != null && rightNode != null)
            return root;

        return leftNode ?? rightNode;
    }
}