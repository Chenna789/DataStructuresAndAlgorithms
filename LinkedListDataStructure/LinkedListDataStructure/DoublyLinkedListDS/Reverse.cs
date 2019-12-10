using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    partial class DoublyLinkedList<AnyType>
    {
        public void Reverse()
        {
            Node<AnyType> current = head;
            Node<AnyType> prev = null;
            tail = head;
            while(current != null)
            {
                Node<AnyType> tempNode = current.next;
                current.next = prev;
                prev = current;
                current.prev = tempNode;
                current = tempNode;
            }
            //head = current;
        }
    }
}
