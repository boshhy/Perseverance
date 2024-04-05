public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        // If there's only one node, it's already a minimum height tree
        if (n == 1) return new List<int> { 0 };

        // Create a dictionary to represent the graph where each node points to its neighbors
        Dictionary<int, HashSet<int>> d = new Dictionary<int, HashSet<int>>();

        // Initialize the adjacency list for each node
        for (int i = 0; i < n; i++)
        {
            d[i] = new HashSet<int>();
        }

        // Populate the adjacency list based on the edges
        foreach (var edge in edges)
        {
            // Add each node to the other's adjacency list to represent an undirected edge
            d[edge[0]].Add(edge[1]);
            d[edge[1]].Add(edge[0]);
        }

        // Create a queue to store leaf nodes (nodes with only one neighbor)
        Queue<int> leaves = new Queue<int>();

        // Find all initial leaf nodes and enqueue them
        for (int i = 0; i < n; i++)
        {
            if (d[i].Count == 1)
            {
                leaves.Enqueue(i);
            }
        }

        // Iteratively remove leaves until only the root or roots are left
        while (d.Count > 2)
        {
            // Store the number of leaf nodes at the current level
            int LeafCount = leaves.Count;

            // Process all leaf nodes at the current level
            while (LeafCount > 0)
            {
                // Dequeue a leaf node
                int leaf = leaves.Dequeue();

                // Get its only neighbor
                int neighbor = d[leaf].First();

                // Remove the leaf node from the graph
                d.Remove(leaf);

                // Remove the leaf node from its neighbor's adjacency list
                d[neighbor].Remove(leaf);

                // If the neighbor becomes a leaf node after removing the current leaf node,
                // enqueue it for further processing
                if (d[neighbor].Count == 1)
                {
                    leaves.Enqueue(neighbor);
                }

                // Decrement the leaf count for the current level
                LeafCount--;
            }
        }

        // Convert the remaining nodes (roots) in the graph to a list and return
        return leaves.ToList();
    }
}
