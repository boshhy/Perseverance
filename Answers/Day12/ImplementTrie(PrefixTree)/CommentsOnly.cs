// Overview
public class Node
{
    // Represents a node in a Trie data structure. It contains a dictionary mapping characters to child nodes 
    // and a boolean flag indicating whether the node marks the end of a word.
}

public class Trie
{
    // Root node of the trie
    public Trie()
    {
        // Initializes a Trie data structure by creating a new instance and setting its root node.
    }

    public void Insert(string word)
    {
        // Inserts a word into the Trie by traversing the tree, creating nodes for each character if necessary, 
        // and marking the last node as the end of the word
    }

    public bool Search(string word)
    {
        // Searches for a specific word in the Trie by traversing the tree, 
        // returning true if the word exists in the Trie and false otherwise.
    }

    public bool StartsWith(string prefix)
    {
        // Checks if any word in the Trie starts with a given prefix by traversing the tree 
        // based on the prefix characters, returning true if such a prefix exists in the Trie and false otherwise.
    }
}

// Comments
public class Node
{
    // Dictionary to hold the child nodes, keyed by characters
    // Flag to indicate if the node represents the end of a word
}

public class Trie
{
    // Root node of the trie

    // Constructor initializes the trie with a root node
    public Trie()
    {
        // Initialize the root node of the trie
    }

    // Method to insert a word into the trie
    public void Insert(string word)
    {
        // Start from the root

        // Traverse through each character of the word
        //     If the current node doesn't have a child with the current letter, create one

        //     Move to the child node corresponding to the current letter

        // Mark the last node as the end of the inserted word
    }

    // Method to search for a word in the trie
    public bool Search(string word)
    {
        // Start from the root
        //     If the current node doesn't have a child with the current letter, the word doesn't exist
        //     Move to the child node corresponding to the current letter

        // Check if the last node of the word is marked as the end of a word
    }

    // Method to check if there are words in the trie that start with a given prefix
    public bool StartsWith(string prefix)
    {
        // Start from the root
        //     If the current node doesn't have a child with the current letter, no word starts with this prefix
        //     Move to the child node corresponding to the current letter

        // There are words in the trie that start with the given prefix
    }
}



// Pseudocode
public class Node
{
    // Define a property named 'values' which is a Dictionary:
    //     Key: character
    //     Value: Node
    //     Initialize it with an empty Dictionary
    // Define a property named 'isEndOfWord' which is a boolean:
    //     Initialize it to false
}

public class Trie
{
    // Define a property named 'root' which is a Node
    public Trie()
    {
        // nitialize 'root' by creating a new Node object
    }

    public void Insert(string word)
    {
        //  Set 'currentNode' to 'root'
        //     For each character 'letter' in 'word':
        //         If 'values' of 'currentNode' does not contain 'letter':
        //             Create a new Node and assign it to 'values' with key 'letter'
        //         Set 'currentNode' to 'values[letter]'
        //     Mark 'currentNode' as the end of the inserted word
    }

    public bool Search(string word)
    {
        // Set 'currentNode' to 'root'
        //     For each character 'letter' in 'word':
        //         If 'values' of 'currentNode' does not contain 'letter':
        //             Return false
        //         Set 'currentNode' to 'values[letter]'
        //     Return 'isEndOfWord' of 'currentNode'
    }

    public bool StartsWith(string prefix)
    {
        // Set 'currentNode' to 'root'
        //     For each character 'letter' in 'prefix':
        //         If 'values' of 'currentNode' does not contain 'letter':
        //             Return false
        //         Set 'currentNode' to 'values[letter]'
        //     Return true
    }
}
