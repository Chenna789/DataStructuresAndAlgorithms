using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    partial class DoublyLinkedList<AnyType>
    {
        private Node<AnyType> head;
        private Node<AnyType> tail;
        public int Count { get; private set; }

        public override string ToString()
        {
            Node<AnyType> current = head;
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
            return $" ::: head->{head.data} head.next->{head.next.data} tail->{tail.data} " +
                $"tail.previous->{tail.prev.data} \n";
        }
    }
}
