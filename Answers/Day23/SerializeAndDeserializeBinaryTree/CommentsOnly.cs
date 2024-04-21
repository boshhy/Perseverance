// Overview
public class Codec
{
    public string serialize(TreeNode root)
    {
        // The provided code serializes a binary tree into a string representation using Depth First Search (DFS). 
        // It initializes an empty list to store the serialized nodes. The DFS function recursively traverses the tree, 
        // adding each node's value to the list. If a node is null, it adds "null" to the list. After traversing the 
        // entire tree, it joins the elements of the list into a single string separated by commas and returns it.
    }

    public TreeNode deserialize(string data)
    {
        // The provided code deserializes a string representation of a binary tree into an actual binary tree using 
        // Depth First Search (DFS) and a queue. It initializes a queue with the split string elements. 
        // The DFS function dequeues elements from the queue, constructs tree nodes, and recursively builds the 
        // left and right subtrees. If the dequeued value is "null", it returns null. 
        // Finally, it returns the root node of the constructed binary tree.
    }
}

// Comments
public class Codec
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        // Initialize a list to store serialized nodes

        // Define a Depth First Search (DFS) function to traverse the tree
        //     If the node is null, add "null" to the result and return

        //     Add the node's value to the result

        //     Recursively traverse the left subtree

        //     Recursively traverse the right subtree

        // Start DFS traversal from the root

        // Join the elements of the result list into a single string separated by commas
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        // Initialize a queue to store split string elements

        // Define a Depth First Search (DFS) function to build the tree
        //     Dequeue a string from the queue

        //     If the dequeued value is "null", return null

        //     Create a new TreeNode with the integer value of the dequeued string

        //     Recursively build the left subtree

        //     Recursively build the right subtree

        //     Return the constructed node

        // Start building the tree by calling the DFS function
    }
}

// Pseudocode
public class Codec
{
    public string serialize(TreeNode root)
    {
        // result = empty list
        // DFS(node):
        //     if node is null:
        //         add "null" to result
        //         return
        //     add node.val as string to result
        //     DFS(node.left)
        //     DFS(node.right)

        // call DFS with root
        // return result joined by ","
    }

    public TreeNode deserialize(string data)
    {
        // queue = new Queue initialized with split data by ","

        // DFS():
        //     valueToAdd = dequeue from queue
        //     if valueToAdd is "null":
        //         return null

        //     node = new TreeNode with value Convert.ToInt32(valueToAdd)
        //     node.left = call DFS recursively
        //     node.right = call DFS recursively

        //     return node

        // return call DFS
    }
}
