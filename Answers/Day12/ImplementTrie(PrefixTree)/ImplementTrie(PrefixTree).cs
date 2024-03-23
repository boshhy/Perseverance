public class Node
{
    // Dictionary to hold the child nodes, keyed by characters
    public Dictionary<char, Node> values { get; set; } = new Dictionary<char, Node>();
    // Flag to indicate if the node represents the end of a word
    public bool isEndOfWord { get; set; } = false;
}

public class Trie
{
    Node root;  // Root node of the trie

    // Constructor initializes the trie with a root node
    public Trie()
    {
        root = new Node();
    }

    // Method to insert a word into the trie
    public void Insert(string word)
    {
        Node currentNode = root;  // Start from the root

        // Traverse through each character of the word
        foreach (char letter in word)
        {
            // If the current node doesn't have a child with the current letter, create one
            if (!currentNode.values.ContainsKey(letter))
            {
                currentNode.values[letter] = new Node();
            }

            // Move to the child node corresponding to the current letter
            currentNode = currentNode.values[letter];
        }

        // Mark the last node as the end of the inserted word
        currentNode.isEndOfWord = true;
    }

    // Method to search for a word in the trie
    public bool Search(string word)
    {
        Node currentNode = root;  // Start from the root
        foreach (char letter in word)
        {
            // If the current node doesn't have a child with the current letter, the word doesn't exist
            if (!currentNode.values.ContainsKey(letter))
            {
                return false;
            }
            // Move to the child node corresponding to the current letter
            currentNode = currentNode.values[letter];
        }

        // Check if the last node of the word is marked as the end of a word
        return currentNode.isEndOfWord;
    }

    // Method to check if there are words in the trie that start with a given prefix
    public bool StartsWith(string prefix)
    {
        Node currentNode = root;  // Start from the root
        foreach (char letter in prefix)
        {
            // If the current node doesn't have a child with the current letter, no word starts with this prefix
            if (!currentNode.values.ContainsKey(letter))
            {
                return false;
            }
            // Move to the child node corresponding to the current letter
            currentNode = currentNode.values[letter];
        }

        // There are words in the trie that start with the given prefix
        return true;
    }
}
