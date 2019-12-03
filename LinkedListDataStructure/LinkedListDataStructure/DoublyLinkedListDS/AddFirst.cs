using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    partial class DoublyLinkedList<AnyType>
    {
        internal void AddFirst(AnyType data)
        {
            Node<AnyType> newNode = new Node<AnyType>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            Count++;
        }
    }
}
