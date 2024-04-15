/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Codec
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        List<string> result = new List<string>();
        void DFS(TreeNode node)
        {
            if (node == null)
            {
                result.Add("null");
                return;
            }
            result.Add(node.val.ToString());
            DFS(node.left);
            DFS(node.right);
        }

        DFS(root);
        return string.Join(",", result);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        Queue<string> queue = new Queue<string>(data.Split(","));

        TreeNode DFS()
        {
            string valueToAdd = queue.Dequeue();
            if (valueToAdd == "null")
            {
                return null;
            }

            TreeNode node = new TreeNode(Convert.ToInt32(valueToAdd));

            node.left = DFS();
            node.right = DFS();

            return node;
        }

        return DFS();
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
