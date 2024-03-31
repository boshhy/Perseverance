public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        IList<int> result = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        if (root == null)
        {
            return result;
        }
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelCount = queue.Count;
            while (levelCount > 0)
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }

                if (levelCount == 1)
                {
                    result.Add(node.val);
                }

                levelCount--;
            }
        }

        return result;
    }
}