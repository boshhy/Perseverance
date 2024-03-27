public class Solution
{
    public class DisjointSet
    {
        int[] parent;
        int[] size;

        public DisjointSet(int n)
        {
            parent = new int[n];
            size = new int[n];

            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
        }

        public int Find(int v)
        {
            if (v != parent[v])
            {
                parent[v] = Find(parent[v]);
            }

            return parent[v];
        }

        public void Union(int a, int b)
        {
            int parentOfA = Find(a);
            int parentOfB = Find(b);

            if (parentOfA != parentOfB)
            {
                if (size[parentOfA] > size[parentOfB])
                {
                    parent[parentOfB] = parentOfA;
                    size[parentOfA] += size[parentOfB];
                }
                else
                {
                    parent[parentOfA] = parentOfB;
                    size[parentOfB] += size[parentOfA];
                }
            }
        }
    }

    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        var emailSet = new Dictionary<string, int>();
        var ds = new DisjointSet(accounts.Count);
        var indexToEmails = new Dictionary<int, List<string>>();
        var results = new List<IList<string>>();

        for (int i = 0; i < accounts.Count; i++)
        {
            var account = accounts[i];
            foreach (string email in account.Skip(1))
            {
                if (emailSet.ContainsKey(email))
                {
                    ds.Union(emailSet[email], i);
                }
                else
                {
                    emailSet[email] = i;
                }
            }
        }

        foreach (var emailAndIndex in emailSet)
        {
            var email = emailAndIndex.Key;
            var index = emailAndIndex.Value;
            var parentIndex = ds.Find(index);

            if (!indexToEmails.ContainsKey(parentIndex))
            {
                indexToEmails.Add(parentIndex, new List<string>());
            }
            indexToEmails[parentIndex].Add(email);
        }

        foreach (var indexAndEmails in indexToEmails)
        {
            var index = indexAndEmails.Key;
            var emailList = indexAndEmails.Value;

            emailList.Sort(StringComparer.Ordinal);
            emailList.Insert(0, accounts[index][0]);

            results.Add(emailList);
        }

        return results;
    }
}