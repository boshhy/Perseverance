// Overview
public class Solution
{
    // public class DisjointSet
    // {
    //     The provided code defines a Disjoint Set data structure, supporting operations like initialization, 
    //     finding the representative element of a set, and union of two sets. It utilizes the union-find algorithm 
    //     to efficiently maintain disjoint sets with path compression and union by size. The DisjointSet class initializes 
    //     a set of given size, assigns each element to its own disjoint set, 
    //     and allows merging two sets while ensuring their disjointness.
    // }

    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        // The provided code performs a merging operation on a list of accounts by utilizing a disjoint set data structure. 
        // It iterates over each account, associating emails with their respective account indices in a dictionary. 
        // Then, it merges accounts if they share common emails using the disjoint set's union operation. 
        // After that, it organizes the merged accounts by their root indices, sorts the emails within each merged account, 
        // adds the account names, and returns the resulting list.
    }
}

// Comments
public class Solution
{
    // Inner class representing a Disjoint Set data structure
    //     Array to store the parent of each element
    //     Array to store the size of each disjoint set

    //     Constructor to initialize the Disjoint Set with 'n' elements
    //         Initialize the parent array
    //         Initialize the size array

    //         Initialize each element as its own parent and set size to 1

    //     Method to find the root parent of a given element 'v'
    //         If 'v' is not the root, recursively find and update its parent

    //         Return the root parent of 'v'

    //     Method to perform union of two elements 'a' and 'b'
    //         Find the root parent of 'a'
    //         Find the root parent of 'b'

    //         If the root parents are not the same, merge the smaller set into the larger set
    //                 Merge 'b' into 'a' and update size accordingly
    //                 Merge 'a' into 'b' and update size accordingly

    // Method to merge accounts using Disjoint Set data structure
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        // Dictionary to store email and its corresponding account index
        // Create a Disjoint Set instance with the number of accounts
        // Dictionary to map parent index to list of emails
        // List to store the final merged accounts

        // Iterate through each account
        //     Skip the first element (name) and iterate through emails
        //         If email is already encountered
        //             Merge the accounts containing the same email
        //             Store the email with its corresponding account index

        // Iterate through the emailSet to group emails by their parent index
        //     Find the root parent index of the current account

        //     If parent index not present in indexToEmails, initialize it
        //     Add the email to the corresponding parent index

        // Iterate through indexToEmails to generate final merged accounts

        //     Sort emails lexicographically
        //     Insert account name at the beginning
        //     Add the merged account to the final result list

        // Return the final merged accounts
    }
}

// Pseudocode
public class Solution
{
    // class DisjointSet {
    //     int[] parent;
    //     int[] size;

    //     DisjointSet(int n) {
    //         parent = new int[n];
    //         size = new int[n];
    //         for (int i = 0; i < n; i++) {
    //             parent[i] = i;
    //             size[i] = 1;
    //         }
    //     }

    //     int Find(int v) {
    //         if (v != parent[v]) {
    //             parent[v] = Find(parent[v]);
    //         }
    //         return parent[v];
    //     }

    //     void Union(int a, int b) {
    //         int parentOfA = Find(a);
    //         int parentOfB = Find(b);
    //         if (parentOfA != parentOfB) {
    //             if (size[parentOfA] > size[parentOfB]) {
    //                 parent[parentOfB] = parentOfA;
    //                 size[parentOfA] += size[parentOfB];
    //             } else {
    //                 parent[parentOfA] = parentOfB;
    //                 size[parentOfB] += size[parentOfA];
    //             }
    //         }
    //     }
    // }

    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        // var emailSet = new Dictionary<string, int>();
        // var ds = new DisjointSet(accounts.Count);
        // var indexToEmails = new Dictionary<int, List<string>>();
        // var results = new List<IList<string>>();

        // for (int i = 0; i < accounts.Count; i++) {
        //     var account = accounts[i];
        //     foreach (string email in account.Skip(1)) {
        //         if (emailSet.ContainsKey(email)) {
        //             ds.Union(emailSet[email], i);
        //         } else {
        //             emailSet[email] = i;
        //         }
        //     }
        // }

        // foreach (var emailAndIndex in emailSet) {
        //     var email = emailAndIndex.Key;
        //     var index = emailAndIndex.Value;
        //     var parentIndex = ds.Find(index);

        //     if (!indexToEmails.ContainsKey(parentIndex)) {
        //         indexToEmails.Add(parentIndex, new List<string>());
        //     }
        //     indexToEmails[parentIndex].Add(email);
        // }

        // foreach (var indexAndEmails in indexToEmails) {
        //     var index = indexAndEmails.Key;
        //     var emailList = indexAndEmails.Value;

        //     emailList.Sort(StringComparer.Ordinal);
        //     emailList.Insert(0, accounts[index][0]);

        //     results.Add(emailList);
        // }

        // return results;
    }
}