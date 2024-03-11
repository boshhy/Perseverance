public partial class MergeTwoListsSolution
{
    static void PrintAndCheckResult(ListNode result, ListNode expected)
    {
        Console.Write("Output: ");
        PrintList(result);
        bool passed = CompareLists(result, expected);
        Console.ForegroundColor = passed ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Test result: {(passed ? "Passed" : "Failed")}");
        Console.ResetColor();
    }

    static bool CompareLists(ListNode list1, ListNode list2)
    {
        while (list1 != null && list2 != null)
        {
            if (list1.val != list2.val)
            {
                return false;
            }
            list1 = list1.next;
            list2 = list2.next;
        }
        return list1 == null && list2 == null;
    }

    static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " ");
            head = head.next;
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        // Example 1: Merging non-empty lists
        ListNode list1_1 = new ListNode(1);
        ListNode list1_2 = new ListNode(2);
        ListNode list1_3 = new ListNode(4);
        list1_1.next = list1_2;
        list1_2.next = list1_3;

        ListNode list2_1 = new ListNode(1);
        ListNode list2_2 = new ListNode(3);
        ListNode list2_3 = new ListNode(4);
        list2_1.next = list2_2;
        list2_2.next = list2_3;

        ListNode expectedOutput1 = new ListNode(1);
        ListNode expectedOutput1_2 = new ListNode(1);
        ListNode expectedOutput1_3 = new ListNode(2);
        ListNode expectedOutput1_4 = new ListNode(3);
        ListNode expectedOutput1_5 = new ListNode(4);
        ListNode expectedOutput1_6 = new ListNode(4);
        expectedOutput1.next = expectedOutput1_2;
        expectedOutput1_2.next = expectedOutput1_3;
        expectedOutput1_3.next = expectedOutput1_4;
        expectedOutput1_4.next = expectedOutput1_5;
        expectedOutput1_5.next = expectedOutput1_6;

        Console.WriteLine("Example 1:");
        Console.WriteLine("Input: list1 = [1,2,4], list2 = [1,3,4]");
        ListNode mergedList1 = MergeTwoLists(list1_1, list2_1);
        Console.WriteLine("Expected output: [1,1,2,3,4,4]");
        PrintAndCheckResult(mergedList1, expectedOutput1);

        // Example 2: Merging empty lists
        ListNode list3 = null;
        ListNode list4 = null;
        ListNode expectedOutput2 = null;

        Console.WriteLine("\nExample 2:");
        Console.WriteLine("Input: list1 = [], list2 = []");
        ListNode mergedList2 = MergeTwoLists(list3, list4);
        Console.WriteLine("Expected output: []");
        PrintAndCheckResult(mergedList2, expectedOutput2);

        // Example 3: Merging one empty list and one non-empty list
        ListNode list5 = null;
        ListNode list6 = new ListNode(0);
        ListNode expectedOutput3 = new ListNode(0);

        Console.WriteLine("\nExample 3:");
        Console.WriteLine("Input: list1 = [], list2 = [0]");
        ListNode mergedList3 = MergeTwoLists(list5, list6);
        Console.WriteLine("Expected output: [0]");
        PrintAndCheckResult(mergedList3, expectedOutput3);
    }
}
