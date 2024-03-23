public class Node
{
    public Dictionary<char, Node> values { get; set; } = new Dictionary<char, Node>();
    public bool isEndOfWord { get; set; } = false;
}

public class Trie
{
    Node root;

    public Trie()
    {
        root = new Node();
    }

    public void Insert(string word)
    {
        Node currentNode = root;

        foreach (char letter in word)
        {
            if (!currentNode.values.ContainsKey(letter))
            {
                currentNode.values[letter] = new Node();
            }

            currentNode = currentNode.values[letter];
        }
        currentNode.isEndOfWord = true;
    }

    public bool Search(string word)
    {
        Node currentNode = root;
        foreach (char letter in word)
        {
            if (!currentNode.values.ContainsKey(letter))
            {
                return false;
            }
            currentNode = currentNode.values[letter];
        }

        return currentNode.isEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        Node currentNode = root;
        foreach (char letter in prefix)
        {
            if (!currentNode.values.ContainsKey(letter))
            {
                return false;
            }
            currentNode = currentNode.values[letter];
        }

        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */