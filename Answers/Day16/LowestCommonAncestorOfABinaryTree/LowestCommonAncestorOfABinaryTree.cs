public class Solution
{
    // This method finds the lowest common ancestor of two nodes 'p' and 'q' in a binary tree with 'root' as its root node.
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        // If the root is null, it means the tree is empty, so there's no common ancestor.
        if (root == null)
            return null;

        // If the current node's value equals either 'p' or 'q', it means this node itself is the common ancestor.
        if (root.val == p.val || root.val == q.val)
            return root;

        // Recursively find the lowest common ancestor in the left subtree.
        TreeNode leftNode = LowestCommonAncestor(root.left, p, q);

        // Recursively find the lowest common ancestor in the right subtree.
        TreeNode rightNode = LowestCommonAncestor(root.right, p, q);

        // If both 'leftNode' and 'rightNode' are not null, it means 'p' and 'q' are found in separate subtrees,
        // hence 'root' is the lowest common ancestor.
        if (leftNode != null && rightNode != null)
            return root;

        // If either 'leftNode' or 'rightNode' is not null, it means either 'p' or 'q' is found in one of the subtrees.
        // In this case, return the non-null node (the common ancestor), if one exists.
        // If both are null, it means neither 'p' nor 'q' is found in the current subtree, so return null.
        return leftNode ?? rightNode;
    }
}
