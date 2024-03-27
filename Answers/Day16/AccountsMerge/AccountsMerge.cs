public class Solution
{
    // Inner class representing a Disjoint Set data structure
    public class DisjointSet
    {
        int[] parent; // Array to store the parent of each element
        int[] size;   // Array to store the size of each disjoint set

        // Constructor to initialize the Disjoint Set with 'n' elements
        public DisjointSet(int n)
        {
            parent = new int[n]; // Initialize the parent array
            size = new int[n];   // Initialize the size array

            // Initialize each element as its own parent and set size to 1
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
        }

        // Method to find the root parent of a given element 'v'
        public int Find(int v)
        {
            // If 'v' is not the root, recursively find and update its parent
            if (v != parent[v])
            {
                parent[v] = Find(parent[v]);
            }

            return parent[v]; // Return the root parent of 'v'
        }

        // Method to perform union of two elements 'a' and 'b'
        public void Union(int a, int b)
        {
            int parentOfA = Find(a); // Find the root parent of 'a'
            int parentOfB = Find(b); // Find the root parent of 'b'

            // If the root parents are not the same, merge the smaller set into the larger set
            if (parentOfA != parentOfB)
            {
                if (size[parentOfA] > size[parentOfB])
                {
                    // Merge 'b' into 'a' and update size accordingly
                    parent[parentOfB] = parentOfA;
                    size[parentOfA] += size[parentOfB];
                }
                else
                {
                    // Merge 'a' into 'b' and update size accordingly
                    parent[parentOfA] = parentOfB;
                    size[parentOfB] += size[parentOfA];
                }
            }
        }
    }

    // Method to merge accounts using Disjoint Set data structure
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        var emailSet = new Dictionary<string, int>();   // Dictionary to store email and its corresponding account index
        var ds = new DisjointSet(accounts.Count);       // Create a Disjoint Set instance with the number of accounts
        var indexToEmails = new Dictionary<int, List<string>>(); // Dictionary to map parent index to list of emails
        var results = new List<IList<string>>();        // List to store the final merged accounts

        // Iterate through each account
        for (int i = 0; i < accounts.Count; i++)
        {
            var account = accounts[i];
            foreach (string email in account.Skip(1)) // Skip the first element (name) and iterate through emails
            {
                if (emailSet.ContainsKey(email)) // If email is already encountered
                {
                    ds.Union(emailSet[email], i); // Merge the accounts containing the same email
                }
                else
                {
                    emailSet[email] = i; // Store the email with its corresponding account index
                }
            }
        }

        // Iterate through the emailSet to group emails by their parent index
        foreach (var emailAndIndex in emailSet)
        {
            var email = emailAndIndex.Key;
            var index = emailAndIndex.Value;
            var parentIndex = ds.Find(index); // Find the root parent index of the current account

            // If parent index not present in indexToEmails, initialize it
            if (!indexToEmails.ContainsKey(parentIndex))
            {
                indexToEmails.Add(parentIndex, new List<string>());
            }
            // Add the email to the corresponding parent index
            indexToEmails[parentIndex].Add(email);
        }

        // Iterate through indexToEmails to generate final merged accounts
        foreach (var indexAndEmails in indexToEmails)
        {
            var index = indexAndEmails.Key;
            var emailList = indexAndEmails.Value;

            emailList.Sort(StringComparer.Ordinal); // Sort emails lexicographically
            emailList.Insert(0, accounts[index][0]); // Insert account name at the beginning
            results.Add(emailList); // Add the merged account to the final result list
        }

        return results; // Return the final merged accounts
    }
}
