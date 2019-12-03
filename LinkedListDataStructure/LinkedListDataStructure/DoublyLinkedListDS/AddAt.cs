using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    partial class DoublyLinkedList<AnyType>
    {
        internal void Add(int index, AnyType data)
        {
            index = index <= 0 ? index : ((index > Count) ? Count : index);
            Node<AnyType> current = head;
            Node<AnyType> newNode = new Node<AnyType>(data);
            for(int i = 0; i < index - 1; i++)
                current = current.next;
            Node<AnyType> temp = current.next;
            current.next = newNode;
            newNode.prev = current;
            newNode.next = temp;
            current.next.next.prev = newNode;
        }
    }
}
