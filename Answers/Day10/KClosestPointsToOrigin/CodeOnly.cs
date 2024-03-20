public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        int[][] result = new int[k][];
        int endElement = points.Length - 1;

        for (int i = endElement; i >= 0; i--)
        {
            Heapify(i);
        }

        for (int i = 0; i < k; i++)
        {
            result[i] = Pop();
        }

        return result;

        void Heapify(int x)
        {
            int parent = x;
            int leftChild = (2 * parent) + 1;
            int rightChild = (2 * parent) + 2;
            int nodeToSwap = leftChild;

            if (leftChild <= endElement)
            {
                if (rightChild <= endElement && Distance(rightChild) < Distance(leftChild))
                {
                    nodeToSwap = rightChild;
                }

                if (Distance(nodeToSwap) < Distance(parent))
                {
                    Swap(parent, nodeToSwap);
                    Heapify(nodeToSwap);
                }
            }

        }

        int[] Pop()
        {
            int[] top = points[0];

            points[0] = points[endElement];
            endElement--;

            Heapify(0);

            return top;
        }

        int Distance(int index)
        {
            return points[index][0] * points[index][0] + points[index][1] * points[index][1];
        }

        void Swap(int p, int c)
        {
            int[] temp = points[p];
            points[p] = points[c];
            points[c] = temp;
        }
    }
}