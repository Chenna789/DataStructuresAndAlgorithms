using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListDataStructure.SinglyLinkedListDS;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedListWithTail singlyLinkedList = new SinglyLinkedListWithTail();
            singlyLinkedList.AddLast(10);
            singlyLinkedList.AddLast(20);
            singlyLinkedList.AddLast(30);
            Console.Write("After adding 10 20 30 last: ");
            singlyLinkedList.Print();
            Console.WriteLine();
            singlyLinkedList.AddFirst(5);
            Console.Write("After adding 5 to the first: ");
            singlyLinkedList.Print();
            Console.WriteLine();
            singlyLinkedList.Add(0, 2);
            Console.Write("After adding 2 at 0 index: ");
            singlyLinkedList.Print();
            Console.WriteLine();
            singlyLinkedList.Add(2, 15);
            Console.Write("After adding 15 at 3 index: ");
            singlyLinkedList.Print();
            Console.WriteLine();
            singlyLinkedList.Add(5, 25);
            Console.Write("After adding 25 at 5 index: ");
            singlyLinkedList.Print();
            Console.WriteLine();
            singlyLinkedList.Add(-1, 1);
            Console.Write("After adding 1 at -1 index: ");
            singlyLinkedList.Print();
            Console.WriteLine();
            singlyLinkedList.Add(100, 40);
            Console.Write("After adding 40 at 100 index: ");
            singlyLinkedList.Print();
            Console.WriteLine();
        }
    }
}
