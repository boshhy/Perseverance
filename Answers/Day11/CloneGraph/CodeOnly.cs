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
    public Node CloneGraph(Node node)
    {
        Dictionary<int, Node> visited = new Dictionary<int, Node>();

        Node CloneNode(Node originalNode)
        {
            if (visited.ContainsKey(originalNode.val))
            {
                return visited[originalNode.val];
            }

            Node tempNode = new Node(originalNode.val);
            visited[originalNode.val] = tempNode;

            foreach (Node neighbor in originalNode.neighbors)
            {
                tempNode.neighbors.Add(CloneNode(neighbor));
            }

            return tempNode;
        }

        return (node == null) ? null : CloneNode(node);
    }
}