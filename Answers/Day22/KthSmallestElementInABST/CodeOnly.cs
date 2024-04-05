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