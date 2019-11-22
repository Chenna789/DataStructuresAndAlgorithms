using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail : ILinkedList
    {
        private Node head;
        public int Count { get; private set; } = 0;
        /// <summary>
        /// printing all the values by iterating the loop from head node
        /// </summary>
        public void Print()
        {
            Node current = head;
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine($" ::: head->data {head.data}");
        }
    }
}
