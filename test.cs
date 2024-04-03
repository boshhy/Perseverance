public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1) return new List<int> { 0 };

        // Build adjacency list
        Dictionary<int, HashSet<int>> d = new Dictionary<int, HashSet<int>>();
        int[] counts = new int[n];

        for (int i = 0; i < n; i++)
        {
            d[i] = new HashSet<int>();
        }
        foreach (var edge in edges)
        {
            d[edge[0]].Add(edge[1]);
            d[edge[1]].Add(edge[0]);
            counts[edge[0]]++;
            counts[edge[1]]++;
        }

        // Find leaves (nodes with only one edge)
        Queue<int> leaves = new Queue<int>();
        for (int i = 0; i < n; i++)
        {
            if (counts[i] == 1)
            {
                leaves.Enqueue(i);
            }
        }

        while (n > 2)
        {
            int LeafCount = leaves.Count;
            n -= LeafCount;

            while (LeafCount > 0)
            {
                int leaf = leaves.Dequeue();
                int neighbor = d[leaf].First();
                //d.Remove(leaf);
                counts[neighbor]--;
                //counts[left] = 0;

                if (counts[neighbor] == 1)
                {
                    leaves.Enqueue(neighbor);
                }
                LeafCount--;
            }
        }

        return leaves.ToList();
    }
}
