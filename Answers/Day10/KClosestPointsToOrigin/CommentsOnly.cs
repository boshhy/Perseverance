// Overview
public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        // The given code implements a method KClosest that returns the k closest points to the origin from an input array of points. 
        // It first initializes a result array to store the k closest points, then constructs a min-heap from the input points based 
        // on their distances to the origin. It then extracts the top k elements from the heap, which are the k closest points, 
        // and returns them. 

        // The code defines helper methods:
        // Heapify to maintain the heap property, 
        // Pop to extract the top element from the heap, 
        // Distance to calculate the distance of a point from the origin 
        // Swap to swap elements in the array.
    }
}

// Comments
public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        // Declare a 2D array 'result' with 'k' rows, each row being an integer array(to hold x and y points).

        // Calculate the index of the last element in the 'points' array.

        // Heapify the elements starting from the last element going backwards to the first.

        // Populate the 'result' array by extracting 'k' elements from the heap.

        // Return the 'result' array containing the 'k' smallest elements.

        // Method to heapify the subtree rooted at index 'x' in the 'points' array.
        //     Initialize variables for the parent, left child, and right child indices.
        //     Initialize the node to swap: Assume the LeftChild needs to be swaped

        //     Check if the left child is within the bounds of the array. (if its not, then nothing to swap ie. no nodes)
        //         If the right child exists and is smaller than the left child, update the node to swap.

        //         If the node to swap is smaller than the parent, swap them and recursively heapify the affected subtree.

        // Method to extract the top element from the heap (minimum element).
        //     Store the top element (minimum) of the heap.

        //     Replace the top element with the last element in the heap and decrement the endElement pointer.

        //     Restore the heap property by heapifying the root element.

        //     Return the extracted top element.

        // Method to calculate the squared distance of a point at the given index in the 'points' array.

        // Method to swap two elements in the 'points' array.
    }
}

// Pseudocode
public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        // result = new array of arrays with size k
        // endElement = length of points - 1

        // for i from endElement down to 0:
        //     Heapify(i)

        // for i from 0 to k - 1:
        //     result[i] = Pop()

        // return result

        // Heapify(x):
        //     parent = x
        //     leftChild = 2 * parent + 1
        //     rightChild = 2 * parent + 2
        //     nodeToSwap = leftChild

        //     if leftChild <= endElement:
        //         if rightChild <= endElement AND Distance(rightChild) < Distance(leftChild):
        //             nodeToSwap = rightChild

        //         if Distance(nodeToSwap) < Distance(parent):
        //             Swap(parent, nodeToSwap)
        //             Heapify(nodeToSwap)

        // Pop():
        //     top = points[0]
        //     points[0] = points[endElement]
        //     endElement--
        //     Heapify(0)
        //     return top

        // Distance(index):
        //     return points[index][0] * points[index][0] + points[index][1] * points[index][1]

        // Swap(p, c):
        //     temp = points[p]
        //     points[p] = points[c]
        //     points[c] = temp
    }
}