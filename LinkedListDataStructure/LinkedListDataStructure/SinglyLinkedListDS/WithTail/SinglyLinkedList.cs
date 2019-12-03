using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail : ILinkedList
    {
        public Node head { get; private set; }
        private Node tail;
        public int Count { get; private set; } = 0;
        /// <summary>
        /// printing all the values by iterating the loop from head node
        /// </summary>
        public override string ToString()
        {
            Node current = head;
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            return $" ::: head->data {head.data} and Tail->data {tail.data}";
        }
    }
}
