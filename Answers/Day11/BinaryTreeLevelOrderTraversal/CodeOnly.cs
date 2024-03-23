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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();

        if (root == null)
        {
            return result;
        }
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int currentCount = queue.Count;
            List<int> levelNodes = new List<int>();

            for (int i = 0; i < currentCount; i++)
            {
                TreeNode pointer = queue.Dequeue();
                levelNodes.Add(pointer.val);

                if (pointer.left != null)
                {
                    queue.Enqueue(pointer.left);
                }
                if (pointer.right != null)
                {
                    queue.Enqueue(pointer.right);
                }
            }
            result.Add(levelNodes);
        }
        return result;
    }
}