public class LRUCache
{
    class Node
    {
        public int key;
        public int value;
        public Node next = null;
        public Node previous = null;

        public Node(int k, int v)
        {
            key = k;
            value = v;
        }
    }

    int maxAllowed;
    Dictionary<int, Node> d;
    Node tail;
    Node head;


    public LRUCache(int capacity)
    {
        maxAllowed = capacity;
        d = new Dictionary<int, Node>();
        tail = new Node(0, 0);
        head = new Node(0, 0);
        tail.next = head;
        head.previous = tail;
    }

    public int Get(int key)
    {
        if (d.ContainsKey(key))
        {
            RemoveFromDoubly(d[key]);
            AddToHeadOfDoubly(d[key]);
            return d[key].value;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (d.ContainsKey(key))
        {
            RemoveFromDoubly(d[key]);
        }

        d[key] = new Node(key, value);
        AddToHeadOfDoubly(d[key]);

        if (d.Count > maxAllowed)
        {
            d.Remove(tail.next.key);
            RemoveFromDoubly(tail.next);
        }
    }

    void RemoveFromDoubly(Node node)
    {
        Node left = node.previous;
        Node right = node.next;
        left.next = right;
        right.previous = left;
    }

    void AddToHeadOfDoubly(Node node)
    {
        Node left = head.previous;
        left.next = node;
        head.previous = node;
        node.previous = left;
        node.next = head;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */