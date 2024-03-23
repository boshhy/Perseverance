/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
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