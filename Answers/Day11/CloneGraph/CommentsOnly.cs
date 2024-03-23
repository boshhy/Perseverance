// Overview
public class Solution
{
    // Method to clone a graph starting from the given node
    public Node CloneGraph(Node node)
    {
        // It recursively clones the graph starting from the given node, ensuring that no nodes are duplicated. 
        // It maintains a dictionary called visited to keep track of visited nodes, and it creates new nodes 
        // with the same values as the original nodes while also copying their neighbors. 
        // Finally, it returns the cloned node corresponding to the input node, or null if the input node is null.
    }
}

// Comments
public class Solution
{
    // Method to clone a graph starting from the given node
    public Node CloneGraph(Node node)
    {
        // Dictionary to keep track of visited nodes during the cloning process

        // Recursive function to clone the graph from the given node
        //     If the node has already been visited, return its cloned version

        //     Create a new node with the same value as the original node
        //     Add the new node to the visited dictionary

        //     Iterate through each neighbor of the original node and clone them recursively
        //         Add the cloned neighbor to the list of neighbors of the cloned node

        //     Return the cloned node

        // If the input node is null, return null; otherwise, clone the graph starting from the input node
    }
}

// Pseudocode
public class Solution
{
    // Method to clone a graph starting from the given node
    public Node CloneGraph(Node node)
    {
        // visited = empty dictionary

        // function CloneNode(originalNode):
        //     if visited contains key originalNode.val:
        //         return visited[originalNode.val]

        //     tempNode = create new Node with originalNode.val
        //     visited[originalNode.val] = tempNode

        //     for each neighbor in originalNode.neighbors:
        //         add CloneNode(neighbor) to tempNode.neighbors

        //     return tempNode

        // return CloneNode(node) if node is not null, otherwise return null
    }
}