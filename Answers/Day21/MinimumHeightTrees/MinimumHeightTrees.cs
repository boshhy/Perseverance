public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        if (n == 1) return new List<int> { 0 };

        // Build adjacency list
        Dictionary<int, HashSet<int>> d = new Dictionary<int, HashSet<int>>();

        for (int i = 0; i < n; i++)
        {
            d[i] = new HashSet<int>();
        }
        foreach (var edge in edges)
        {
            d[edge[0]].Add(edge[1]);
            d[edge[1]].Add(edge[0]);
        }

        Queue<int> leaves = new Queue<int>();

        for (int i = 0; i < n; i++)
        {
            if (d[i].Count == 1)
            {
                leaves.Enqueue(i);
            }
        }

        while (d.Count > 2)
        {
            int LeafCount = leaves.Count;

            while (LeafCount > 0)
            {
                int leaf = leaves.Dequeue();
                int neighbor = d[leaf].First();
                d.Remove(leaf);
                d[neighbor].Remove(leaf);

                if (d[neighbor].Count == 1)
                {
                    leaves.Enqueue(neighbor);
                }
                LeafCount--;
            }
        }

        return leaves.ToList();
    }
}
