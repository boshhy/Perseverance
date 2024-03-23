// Overview
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        // The code performs a level order traversal of a binary tree, collecting nodes at each level into separate lists. 
        // It initializes an empty list to store the traversal result and a queue to facilitate traversal. 
        // It checks if the tree is empty and returns an empty list if so. Then, it iteratively dequeues nodes from the queue, 
        // adding their values to a list representing the current level and enqueuing their children. 
        // Finally, it adds each level's list to the result list and returns it.
    }
}

// Comments
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        // Initialize a list to store lists of integers, each representing a level in the binary tree

        // Initialize a queue to perform level order traversal of the binary tree

        // Check if the root of the binary tree is null, if so, return the empty result

        // Enqueue the root node to start the traversal

        // Perform level order traversal using a queue
        //     Get the number of nodes at the current level

        //     Initialize a list to store nodes at the current level

        //     Iterate through all nodes at the current level
        //         Dequeue a node from the queue

        //         Add the value of the dequeued node to the list representing the current level

        //         Enqueue the left child of the dequeued node if it exists

        //         Enqueue the right child of the dequeued node if it exists

        //     Add the list of nodes at the current level to the result list

        // Return the result list containing lists of nodes at each level of the binary tree
    }
}

// Pseudocode
public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        // result = empty list of lists
        // queue = empty queue

        // if root is null
        //     return result

        // enqueue root into queue

        // while queue is not empty
        //     currentCount = size of queue
        //     levelNodes = empty list

        //     for i = 1 to currentCount
        //         pointer = dequeue from queue
        //         add pointer's value to levelNodes

        //         if pointer has left child
        //             enqueue left child into queue

        //         if pointer has right child
        //             enqueue right child into queue

        //     add levelNodes to result

        // return result
    }
}