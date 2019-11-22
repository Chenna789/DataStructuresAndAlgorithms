using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        private Node<AnyType> head;
        private Node<AnyType> tail;
        public int Count { get; private set; } = 0;
        /// <summary>
        /// printing all the values by iterating the loop from head node
        /// </summary>
        public void Print()
        {
            Node<AnyType> current = head;
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine($" ::: head->data {head.data} and Tail->data {tail.data}");
        }
    }
}
