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
            singlyLinkedList.Print();
            singlyLinkedList.AddFirst(5);
            Console.Write("After adding 5 to the first: ");
            singlyLinkedList.Print();
            singlyLinkedList.Add(0, 2);
            Console.Write("After adding 2 at 0 index: ");
            singlyLinkedList.Print();
            singlyLinkedList.Add(3, 15);
            Console.Write("After adding 15 at 3 index: ");
            singlyLinkedList.Print();
            singlyLinkedList.Add(5, 25);
            Console.Write("After adding 25 at 5 index: ");
            singlyLinkedList.Print();
            singlyLinkedList.Add(-1, 1);
            Console.Write("After adding 1 at -1 index: ");
            singlyLinkedList.Print();
            singlyLinkedList.Add(100, 40);
            Console.Write("After adding 40 at 100 index: ");
            singlyLinkedList.Print();
            singlyLinkedList.AddBefore(5, 4);
            Console.Write("After adding 4 before 5: ");
            singlyLinkedList.Print();
            singlyLinkedList.AddBeforeWithImporvedComplexity(4, 3);
            Console.Write("After adding 3 before 4: ");
            singlyLinkedList.Print();
            singlyLinkedList.AddAfter(5, 6);
            Console.Write("After adding 6 after 5: ");
            singlyLinkedList.Print();
            singlyLinkedList.Remove(10);
            Console.Write("After removing 10: ");
            singlyLinkedList.Print();
            Console.WriteLine($"Getting node at index 3: {singlyLinkedList.GetNode(3).data}");
            Object obj = 20;
            Console.WriteLine($"Getting node with the value 20: {singlyLinkedList.GetNode(obj).data}");
            Console.Write("Removing 20 with O(1): ");
            singlyLinkedList.RemoveWith_O_1(singlyLinkedList.GetNode(obj));
            singlyLinkedList.Print();
            Console.Write($"using indexer to get index 4: {singlyLinkedList[4]} \n");
            singlyLinkedList.Reverse();
            Console.Write("After reversing: ");
            singlyLinkedList.Print();
            Console.WriteLine("*****************************************************************************");
        }
    }
}
