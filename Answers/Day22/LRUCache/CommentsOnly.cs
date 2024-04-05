// Overview
public class LRUCache
{
    // Define a doubly linked list node structure named Node, each containing integer key-value pairs. 
    // Additionally, declare variables maxAllowed, a dictionary d mapping integer keys to Node objects, 
    // and tail and head nodes to manage a doubly linked list structure.

    public LRUCache(int capacity)
    {
        // This code initializes the maximum allowed capacity of a cache, creates an empty dictionary to store 
        // key-node pairs, and sets up sentinel nodes tail and head for a doubly linked list representing the 
        // cache structure. The tail node points to head as its next node, and head points to tail as its previous node.
    }

    public int Get(int key)
    {
        // This code checks if a key exists in the cache dictionary. If it does, it removes the corresponding node from the 
        // doubly linked list, adds it to the head of the list, and returns the associated value. 
        // Otherwise, it returns -1 indicating that the key is not present in the cache.
    }

    public void Put(int key, int value)
    {
        // This code updates the cache with a new key-value pair. If the key already exists, it removes the corresponding node 
        // from the doubly linked list. It then adds the new key-value pair to the cache and moves the node to the head of the 
        // doubly linked list. If the cache size exceeds the maximum allowed capacity, it removes the least recently used node 
        // from both the cache and the doubly linked list
    }

    // void RemoveFromDoubly(Node node)
    // {
    //     This code removes a node from a doubly linked list by updating the references of the adjacent nodes. It sets the next 
    //     reference of the left node to the right node and the previous reference of the right node to the left node, 
    //     effectively disconnecting the node from the list.
    // }

    // void AddToHeadOfDoubly(Node node)
    // {
    //     This code inserts a node at the head of a doubly linked list. It updates the references of the existing nodes to include 
    //     the new node, making it the new head of the list while maintaining the connectivity of the previous nodes.
    // }
}

// Comments
public class LRUCache
{
    // Inner class representing a node in the doubly linked list
    //     Key of the cache item
    //     Value of the cache item
    //     Reference to the next node
    //     Reference to the previous node

    //     Constructor to initialize a node with key and value

    // Maximum allowed capacity of the cache
    // Dictionary to store key-value pairs with key mapped to corresponding node
    // Reference to the tail sentinel node of the doubly linked list
    // Reference to the head sentinel node of the doubly linked list

    // Constructor to initialize LRUCache with a given capacity
    public LRUCache(int capacity)
    {
        // Initialize maximum allowed capacity
        // Initialize dictionary to store key-value pairs
        // Initialize tail sentinel node with key and value 0
        // Initialize head sentinel node with key and value 0
        // Set tail's next reference to head
        // Set head's previous reference to tail
    }

    // Method to retrieve value from cache given a key
    public int Get(int key)
    {
        // Check if key exists in the cache
        //     Remove the corresponding node from the doubly linked list
        //     Move the node to the head of the doubly linked list
        //     Return the value associated with the key

        // Return -1 if key does not exist in the cache
    }

    // Method to insert or update a key-value pair in the cache
    public void Put(int key, int value)
    {
        // Check if key already exists in the cache
        //     Remove the corresponding node from the doubly linked list

        // Create a new node with the given key and value
        // Add the new node to the head of the doubly linked list

        // Check if the cache size exceeds the maximum allowed capacity
        //     Remove the least recently used node from the dictionary
        //     Remove the least recently used node from the doubly linked list
    }

    // Method to remove a node from the doubly linked list
    // void RemoveFromDoubly(Node node)
    // {
    //     Get the previous node
    //     Get the next node
    //     Set the next reference of the previous node to the next node
    //     Set the previous reference of the next node to the previous node
    // }

    // Method to add a node to the head of the doubly linked list
    // void AddToHeadOfDoubly(Node node)
    // {
    //     Get the node before the head (last node)
    //     Set the next reference of the last node to the new node
    //     Set the previous reference of the head to the new node
    //     Set the previous reference of the new node to the last node
    //     Set the next reference of the new node to the head
    // }
}

// Pseudocode
public class LRUCache
{
    // Define class Node
    //     Define public integer key
    //     Define public integer value
    //     Define public Node next and initialize to null
    //     Define public Node previous and initialize to null
    //     Define constructor Node with parameters k and v
    //         Set key to k
    //         Set value to v

    // Define integer maxAllowed
    // Define Dictionary d of integer keys mapped to Node values
    // Define Node tail
    // Define Node head

    public LRUCache(int capacity)
    {
        // Set maxAllowed to capacity
        // Initialize dictionary d
        // Create new Node tail with key 0 and value 0
        // Create new Node head with key 0 and value 0
        // Set tail's next reference to head
        // Set head's previous reference to tail
    }

    public int Get(int key)
    {
        // If d contains key
        //     Call RemoveFromDoubly with argument d[key]
        //     Call AddToHeadOfDoubly with argument d[key]
        //     Return d[key].value
        // Return -1
    }

    public void Put(int key, int value)
    {
        // If d contains key
        //     Call RemoveFromDoubly with argument d[key]
        // Set d[key] to new Node with key and value
        // Call AddToHeadOfDoubly with argument d[key]
        // If d's count is greater than maxAllowed
        //     Remove key tail.next.key from d
        //     Call RemoveFromDoubly with argument tail.next
    }

    // void RemoveFromDoubly(Node node)
    // {
    //     Set left to node's previous
    //     Set right to node's next
    //     Set left's next to right
    //     Set right's previous to left
    // }

    // void AddToHeadOfDoubly(Node node)
    // {
    //     Set left to head's previous
    //     Set left's next to node
    //     Set head's previous to node
    //     Set node's previous to left
    //     Set node's next to head
    // }
}

