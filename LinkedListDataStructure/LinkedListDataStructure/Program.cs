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

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
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
            doublyLinkedList.Add(3, 4); ;
            Console.Write("After Adding 4 at index 3: ");
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
