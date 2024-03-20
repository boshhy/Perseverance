public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        // Declare a 2D array 'result' with 'k' rows, each row being an integer array(to hold x and y points).
        int[][] result = new int[k][];

        // Calculate the index of the last element in the 'points' array.
        int endElement = points.Length - 1;

        // Heapify the elements starting from the last element going backwards to the first.
        for (int i = endElement; i >= 0; i--)
        {
            Heapify(i);
        }

        // Populate the 'result' array by extracting 'k' elements from the heap.
        for (int i = 0; i < k; i++)
        {
            result[i] = Pop();
        }

        // Return the 'result' array containing the 'k' smallest elements.
        return result;

        // Method to heapify the subtree rooted at index 'x' in the 'points' array.
        void Heapify(int x)
        {
            // Initialize variables for the parent, left child, and right child indices.
            int parent = x;
            int leftChild = (2 * parent) + 1;
            int rightChild = (2 * parent) + 2;
            // Initialize the node to swap: Assume the LeftChild needs to be swaped
            int nodeToSwap = leftChild;

            // Check if the left child is within the bounds of the array. (if its not, then nothing to swap ie. no nodes)
            if (leftChild <= endElement)
            {
                // If the right child exists and is smaller than the left child, update the node to swap.
                if (rightChild <= endElement && Distance(rightChild) < Distance(leftChild))
                {
                    nodeToSwap = rightChild;
                }

                // If the node to swap is smaller than the parent, swap them and recursively heapify the affected subtree.
                if (Distance(nodeToSwap) < Distance(parent))
                {
                    Swap(parent, nodeToSwap);
                    Heapify(nodeToSwap);
                }
            }

        }

        // Method to extract the top element from the heap (minimum element).
        int[] Pop()
        {
            // Store the top element (minimum) of the heap.
            int[] top = points[0];

            // Replace the top element with the last element in the heap and decrement the endElement pointer.
            points[0] = points[endElement];
            endElement--;

            // Restore the heap property by heapifying the root element.
            Heapify(0);

            // Return the extracted top element.
            return top;
        }

        // Method to calculate the squared distance of a point at the given index in the 'points' array.
        int Distance(int index)
        {
            return points[index][0] * points[index][0] + points[index][1] * points[index][1];
        }

        // Method to swap two elements in the 'points' array.
        void Swap(int p, int c)
        {
            int[] temp = points[p];
            points[p] = points[c];
            points[c] = temp;
        }

    }
}