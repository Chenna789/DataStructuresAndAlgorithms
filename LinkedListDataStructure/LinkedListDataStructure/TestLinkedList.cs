using LinkedListDataStructure.SinglyLinkedListDS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure
{
    class TestLinkedList
    {
        internal static void Test(ILinkedList singlyLinkedList)
        {
            Console.WriteLine($"Testing {singlyLinkedList.GetType().Name}");
            Console.WriteLine("*****************************************************************************");
            singlyLinkedList.AddLast(10);
            singlyLinkedList.AddLast(20);
            singlyLinkedList.AddLast(30);
            Console.Write("After adding 10 20 30 last: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.ReverseUsingRecursion();
            singlyLinkedList.AddFirst(5);
            Console.Write("After adding 5 to the first: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.Add(0, 2);
            Console.Write("After adding 2 at 0 index: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.Add(3, 15);
            Console.Write("After adding 15 at 3 index: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.Add(5, 25);
            Console.Write("After adding 25 at 5 index: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.Add(-1, 1);
            Console.Write("After adding 1 at -1 index: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.Add(100, 40);
            Console.Write("After adding 40 at 100 index: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.AddBefore(5, 4);
            Console.Write("After adding 4 before 5: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.AddBeforeWithImporvedComplexity(4, 3);
            Console.Write("After adding 3 before 4: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.AddAfter(5, 6);
            Console.Write("After adding 6 after 5: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.Remove(10);
            Console.Write("After removing 10: ");
            Console.WriteLine(singlyLinkedList);
            Console.WriteLine($"Getting node at index 3: {singlyLinkedList.GetNode(3).data}");
            Object obj = 20;
            Console.WriteLine($"Getting node with the value 20: {singlyLinkedList.GetNode(obj).data}");
            Console.WriteLine($"Getting middle Node without count: {singlyLinkedList.FindMiddleWithOutCount().data}");
            Console.WriteLine($"Getting middle Node with count: {singlyLinkedList.FindMiddleWithCount().data}");
            Console.WriteLine($"Getting middle Node with two pointers: {singlyLinkedList.FindMiddleWithTwoPointers().data}");
            Console.Write("After removing 10: ");
            Console.WriteLine(singlyLinkedList);
            Console.Write("Removing 20 with O(1): ");
            singlyLinkedList.RemoveWith_O_1(singlyLinkedList.GetNode(obj));
            Console.WriteLine(singlyLinkedList);
            Console.Write($"using indexer to get index 4: {singlyLinkedList[4]} \n");
            singlyLinkedList.Reverse();
            Console.Write("After reversing: ");
            Console.WriteLine(singlyLinkedList);
            singlyLinkedList.ReverseUsingRecursion();
            Console.Write("Reverse using recursion: ");
            Console.WriteLine(singlyLinkedList);
            //singlyLinkedList.CreateLoop();
            Console.WriteLine($"loop in linked list method1: {singlyLinkedList.LoopInLinkedList1()}");
            Console.WriteLine($"loop in linked list method2: {singlyLinkedList.LoopInLinkedList2()}");
            Console.WriteLine(singlyLinkedList);
            Console.WriteLine("*****************************************************************************");
        }
    }
}
