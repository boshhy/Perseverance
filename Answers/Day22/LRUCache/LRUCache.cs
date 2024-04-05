public class LRUCache
{
    // Inner class representing a node in the doubly linked list
    class Node
    {
        public int key;  // Key of the cache item
        public int value; // Value of the cache item
        public Node next = null; // Reference to the next node
        public Node previous = null; // Reference to the previous node

        // Constructor to initialize a node with key and value
        public Node(int k, int v)
        {
            key = k;
            value = v;
        }
    }

    // Maximum allowed capacity of the cache
    int maxAllowed;
    // Dictionary to store key-value pairs with key mapped to corresponding node
    Dictionary<int, Node> d;
    // Reference to the tail sentinel node of the doubly linked list
    Node tail;
    // Reference to the head sentinel node of the doubly linked list
    Node head;

    // Constructor to initialize LRUCache with a given capacity
    public LRUCache(int capacity)
    {
        maxAllowed = capacity; // Initialize maximum allowed capacity
        d = new Dictionary<int, Node>(); // Initialize dictionary to store key-value pairs
        tail = new Node(0, 0); // Initialize tail sentinel node with key and value 0
        head = new Node(0, 0); // Initialize head sentinel node with key and value 0
        tail.next = head; // Set tail's next reference to head
        head.previous = tail; // Set head's previous reference to tail
    }

    // Method to retrieve value from cache given a key
    public int Get(int key)
    {
        if (d.ContainsKey(key)) // Check if key exists in the cache
        {
            RemoveFromDoubly(d[key]); // Remove the corresponding node from the doubly linked list
            AddToHeadOfDoubly(d[key]); // Move the node to the head of the doubly linked list
            return d[key].value; // Return the value associated with the key
        }

        return -1; // Return -1 if key does not exist in the cache
    }

    // Method to insert or update a key-value pair in the cache
    public void Put(int key, int value)
    {
        if (d.ContainsKey(key)) // Check if key already exists in the cache
        {
            RemoveFromDoubly(d[key]); // Remove the corresponding node from the doubly linked list
        }

        d[key] = new Node(key, value); // Create a new node with the given key and value
        AddToHeadOfDoubly(d[key]); // Add the new node to the head of the doubly linked list

        if (d.Count > maxAllowed) // Check if the cache size exceeds the maximum allowed capacity
        {
            d.Remove(tail.next.key); // Remove the least recently used node from the dictionary
            RemoveFromDoubly(tail.next); // Remove the least recently used node from the doubly linked list
        }
    }

    // Method to remove a node from the doubly linked list
    void RemoveFromDoubly(Node node)
    {
        Node left = node.previous; // Get the previous node
        Node right = node.next; // Get the next node
        left.next = right; // Set the next reference of the previous node to the next node
        right.previous = left; // Set the previous reference of the next node to the previous node
    }

    // Method to add a node to the head of the doubly linked list
    void AddToHeadOfDoubly(Node node)
    {
        Node left = head.previous; // Get the node before the head (last node)
        left.next = node; // Set the next reference of the last node to the new node
        head.previous = node; // Set the previous reference of the head to the new node
        node.previous = left; // Set the previous reference of the new node to the last node
        node.next = head; // Set the next reference of the new node to the head
    }
}
