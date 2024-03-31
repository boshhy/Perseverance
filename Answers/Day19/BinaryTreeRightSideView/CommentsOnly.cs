// Overview
public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        // This code implements a function RightSideView that takes a binary tree's root node as input and returns a 
        // list containing the values of nodes visible from the right side of the tree. It initializes an empty list 
        // result and a queue queue for performing level order traversal. If the tree is empty, it returns the empty 
        // result list. Otherwise, it enqueues the root node. Then it proceeds with a while loop until the queue is 
        // empty, where it iterates through each level of the tree. At each level, it dequeues nodes, enqueues their 
        // children if present, and adds the value of the last node in each level (rightmost) to the result list. 
        // Finally, it returns the constructed result list.
    }
}

// Comments
public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        // Create a list to store the right side view values
        // Create a queue to perform level order traversal
        // If the tree is empty, return the empty result

        // Enqueue the root node to start the traversal

        // Perform level order traversal
        //     Get the number of nodes at the current level

        //     Traverse all nodes at the current level
        //         Dequeue the current node

        //         Enqueue the left child if exists

        //         Enqueue the right child if exists

        //         If it's the last node at the current level, add its value to the result

        //         Decrement the count of nodes at the current level

        // Return the list containing the right side view values
    }
}

// Pseudocode
public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        // result = empty list
        // queue = empty queue
        // if root is null:
        //     return result
        // queue.enqueue(root)

        // while queue is not empty:
        //     levelCount = queue.size()
        //     while levelCount > 0:
        //         node = queue.dequeue()

        //         if node has left child:
        //             queue.enqueue(node.left)
        //         if node has right child:
        //             queue.enqueue(node.right)

        //         if levelCount is 1:
        //             result.add(node.val)

        //         levelCount--

        // return result
    }
}


