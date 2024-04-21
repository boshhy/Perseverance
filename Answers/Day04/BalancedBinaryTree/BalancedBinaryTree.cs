public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    /*
     * This method checks if a given binary tree is balanced or not.
     * It recursively calculates the depth of each subtree and returns -1 if any subtree is unbalanced, 
     * otherwise, it returns the height of the tree.
     */
    public bool IsBalanced(TreeNode root)
    {
        // Inner method to calculate the depth of the tree.
        int howDeep(TreeNode currentNode)
        {
            // If the current node is null, return 0 as its depth.
            if (currentNode == null)
            {
                return 0;
            }

            // Recursively calculate the depth of the left and right subtrees.
            int left = howDeep(currentNode.left);
            int right = howDeep(currentNode.right);

            // If either subtree is unbalanced or if the difference in heights between left and right subtrees is more than 1,
            // return -1 to indicate the tree is unbalanced.
            if (left == -1 || right == -1 || Math.Abs(left - right) >= 2)
            {
                return -1;
            }

            // Otherwise, return the height of the current node by adding 1 to the maximum depth of its subtrees.
            return (left > right) ? left + 1 : right + 1;
        }

        // Call the inner method to calculate the depth of the root.
        // If the returned value is -1, the tree is unbalanced; otherwise, it's balanced.
        if (howDeep(root) == -1)
        {
            return false; // Tree is unbalanced
        }
        return true; // Tree is balanced
    }
}