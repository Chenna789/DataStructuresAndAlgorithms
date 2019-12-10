using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListDataStructure.SinglyLinkedListDS.WithTail;
using LinkedListDataStructure.SinglyLinkedListDS.WithOutTail;
using LinkedListDataStructure.SinglyLinkedListDS.WithGenerics;
using LinkedListDataStructure.SinglyLinkedListDS;
using LinkedListDataStructure.DoublyLinkedListDS;
using LinkedListDataStructure.SinglyLinkedListDS.Practice;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Test()
        {
            SinglyLinkedListWithOutTail singlyLinked = new SinglyLinkedListWithOutTail();
            singlyLinked.AddLast(2);
            singlyLinked.AddLast(4);
            singlyLinked.AddLast(3);
            SinglyLinkedListWithOutTail singlyLinked2 = new SinglyLinkedListWithOutTail();
            singlyLinked2.AddLast(5);
            singlyLinked2.AddLast(6);
            singlyLinked2.AddLast(4);
            LinkedListPractice practice = new LinkedListPractice();
            practice.AddTwoNumbers(singlyLinked.head, singlyLinked2.head);

        }
        static void Main(string[] args)
        {
            Test();
            DoublyLinkedList<int> doublyLinkedList = new DoublyLinkedList<int>();
            doublyLinkedList.AddFirst(3);
            doublyLinkedList.AddFirst(2);
            doublyLinkedList.AddFirst(1);
            Console.Write("After Adding 1 2 3: ");
            Console.Write(doublyLinkedList);
            doublyLinkedList.AddLast(5);
            doublyLinkedList.AddLast(6);
            Console.Write("After Adding 5 6: ");
            Console.Write(doublyLinkedList);
            doublyLinkedList.Add(-1, 0); 
            Console.Write("After Adding 0 at index -1: ");
            Console.Write(doublyLinkedList);
            doublyLinkedList.Add(10, 7); 
            Console.Write("After Adding 7 at index 10: ");
            Console.Write(doublyLinkedList);
            doublyLinkedList.AddAfter(3, 10); 
            Console.Write("10 Add after 3: ");
            Console.Write(doublyLinkedList);
            doublyLinkedList.AddBefore(10, 9);
            Console.Write("9 Add before 10: ");
            Console.Write(doublyLinkedList);
            Console.WriteLine($"Middle element is: {doublyLinkedList.FindMiddleElement().data}");
            Console.WriteLine($"Middle element with two pointers is: {doublyLinkedList.FindMiddleElement().data}");
            doublyLinkedList.Reverse();
            Console.Write($"After Reversing: ");
            Console.Write(doublyLinkedList);
            //ILinkedList[] singlyLinkedLists = new ILinkedList[]{new SinglyLinkedListWithTail(),
            //                                                    new SinglyLinkedListWithOutTail() };

            //foreach (ILinkedList linkedList in singlyLinkedLists)
            //{
            //    TestLinkedList.Test(linkedList);
            //}

        }
    }
}
