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
    // Method to clone a graph starting from the given node
    public Node CloneGraph(Node node)
    {
        // Dictionary to keep track of visited nodes during the cloning process
        Dictionary<int, Node> visited = new Dictionary<int, Node>();

        // Recursive function to clone the graph from the given node
        Node CloneNode(Node originalNode)
        {
            // If the node has already been visited, return its cloned version
            if (visited.ContainsKey(originalNode.val))
            {
                return visited[originalNode.val];
            }

            // Create a new node with the same value as the original node
            Node tempNode = new Node(originalNode.val);
            // Add the new node to the visited dictionary
            visited[originalNode.val] = tempNode;

            // Iterate through each neighbor of the original node and clone them recursively
            foreach (Node neighbor in originalNode.neighbors)
            {
                // Add the cloned neighbor to the list of neighbors of the cloned node
                tempNode.neighbors.Add(CloneNode(neighbor));
            }

            // Return the cloned node
            return tempNode;
        }

        // If the input node is null, return null; otherwise, clone the graph starting from the input node
        return (node == null) ? null : CloneNode(node);
    }
}
