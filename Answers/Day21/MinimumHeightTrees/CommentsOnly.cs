// Overview
public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        // This code aims to find the nodes that can serve as roots for minimum height trees in an undirected graph. 
        // It first handles the special case where there's only one node. Then, it constructs an adjacency list to 
        // represent the graph, ensuring each edge is accounted for in both directions. Next, it identifies 
        // leaf nodes (nodes with only one neighbor) and enqueues them for processing. Through iterative removal of 
        // leaf nodes and their associated edges, it prunes the graph until only the root or roots remain. 
        // Finally, it returns the remaining nodes, which represent the roots of the minimum height trees.
    }
}

// Comments
public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        // If there's only one node, it's already a minimum height tree

        // Create a dictionary to represent the graph where each node points to its neighbors

        // Initialize the adjacency list for each node

        // Populate the adjacency list based on the edges
        //     Add each node to the other's adjacency list to represent an undirected edge

        // Create a queue to store leaf nodes (nodes with only one neighbor)

        // Find all initial leaf nodes and enqueue them

        // Iteratively remove leaves until only the root or roots are left
        //     Store the number of leaf nodes at the current level

        //     Process all leaf nodes at the current level
        //         Dequeue a leaf node

        //         Get its only neighbor

        //         Remove the leaf node from the graph

        //         Remove the leaf node from its neighbor's adjacency list

        //         If the neighbor becomes a leaf node after removing the current leaf node,
        //         enqueue it for further processing

        //         Decrement the leaf count for the current level

        // Convert the remaining nodes (roots) in the graph to a list and return
    }
}

// Pseudocode
public class Solution
{
    public IList<int> FindMinHeightTrees(int n, int[][] edges)
    {
        // if n equals 1:
        //     return [0]

        // d = create empty dictionary

        // for i from 0 to n - 1:
        //     d[i] = create empty set

        // for each edge in edges:
        //     d[edge[0]].add(edge[1])
        //     d[edge[1]].add(edge[0])

        // leaves = create empty queue

        // for i from 0 to n - 1:
        //     if size of d[i] equals 1:
        //         leaves.enqueue(i)

        // while size of d is greater than 2:
        //     LeafCount = size of leaves

        //     while LeafCount is greater than 0:
        //         leaf = leaves.dequeue()
        //         neighbor = d[leaf].getFirst()
        //         d.remove(leaf)
        //         d[neighbor].remove(leaf)

        //         if size of d[neighbor] equals 1:
        //             leaves.enqueue(neighbor)

        //         decrement LeafCount

        // return leaves.toList()
    }
}
